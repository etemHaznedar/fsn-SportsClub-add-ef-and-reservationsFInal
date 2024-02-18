using System.Threading.Tasks;
using SportsClub.API.Repositories.Contracts;
using SportsClub.API.Entities;
using SportsClub.API.Extensions;
using SportsClub.Models.Dtos;
using SportsClub.SharedModels.Dtos;
using SportsClub.SharedModels;

namespace SportsClub.API.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly ISportsClubRepository _repository;
        private readonly IEmailService _emailService; 

        public EnrollmentService(ISportsClubRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;

        }
        
        public async Task<bool> ReserveAsync(EnrollmentDto enrollmentDto)
        {
            try
            {
                var lesson = await _repository.GetLessonById(enrollmentDto.LessonId);
                var existingEnrollment = await _repository.GetEnrollmentByUserAndLessonAsync(enrollmentDto.Email, enrollmentDto.LessonId);
                if (lesson == null)
                    return false; // Lesson not found
                string status;
                
                
                
                if (existingEnrollment != null && existingEnrollment.EnrolledStatus == "Waiting" && lesson.CurrentCapacity < lesson.MaxCapacity) {
                    // There is still room for one more and the user is on the waiting list
                    existingEnrollment.EnrolledStatus = "Enrolled";
                    lesson.CurrentCapacity++;
                    _repository.UpdateLesson(lesson);
                    await _repository.SaveChangesAsync();
                    return true; // Reservation succeeded
                }
                else if (existingEnrollment == null)
                {
                    if (lesson.CurrentCapacity < lesson.MaxCapacity)
                    {
                        lesson.CurrentCapacity++;
                        status = "Enrolled";
                    }
                    else
                    {
                        status = "Waiting";
                    }

                    var enrollment = new Enrollment
                    {
                        LessonId = enrollmentDto.LessonId,
                        WorkoutId = enrollmentDto.WorkoutId,
                        Location = enrollmentDto.Location,
                        Email = enrollmentDto.Email,
                        StartDateTime = enrollmentDto.StartDateTime,
                        EnrolledStatus = status,
                        EnrollmentDate = DateTime.Now
                    };
                    await _repository.AddEnrollment(enrollment);

                    _repository.UpdateLesson(lesson); // Update the lesson CurrentCapacity
                    await _repository.SaveChangesAsync();

                    return true; // Reservation succeeded
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false; // Reservation failed
            }
        }

        public async Task<IEnumerable<EnrollmentDto>> GetEnrollmentsCurrentUserandLesson(string email, int lessonId)
        {
            var enrollments = await _repository.GetEnrollmentsCurrentUserandLesson(email, lessonId);

            var enrollmentDtos = enrollments.Select(e => new EnrollmentDto(
                e.Id, 
                e.LessonId, 
                e.WorkoutId,
                e.Location, 
                e.Email, 
                e.StartDateTime, 
                e.EnrolledStatus, 
                e.EnrollmentDate
            )).ToList();

            return enrollmentDtos;
        }




        public async Task CancelEnrollment(string email, int lessonId)
        {
            var enrollment = await _repository.GetEnrollmentByEmailAndLessonId(email, lessonId);

            if (enrollment != null)
            {
                var lesson = await _repository.GetLessonById(lessonId);

                _repository.RemoveEnrollment(enrollment);

                if (lesson != null && lesson.CurrentCapacity > 0)
                {
                    lesson.CurrentCapacity--;
                    _repository.UpdateLesson(lesson);
                }

                await CheckWaitingListAndNotifyUsers(enrollment.LessonId);

                await _repository.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException("No such enrollment to cancel");
            }
        }
        public async Task CheckWaitingListAndNotifyUsers(int lessonId)
        {
            // Fetch the waiting list for the given lesson.
            List<string> waitingListEmails = (await _repository.GetWaitingListByLessonId(lessonId)).ToList();   
            if (!waitingListEmails.Any()) return; 

            if (waitingListEmails.Count == 0)
            {
                return; // No one on the waiting list
            }
            foreach (var email in waitingListEmails)
            {
                var mailData = new MailData(
                    to: new List<string> { email },
                    subject: "A spot just opened up!",
                    body: "Hello, a spot in your desired lesson has just opened up. Act fast!"
                );
                await _emailService.SendEmailAsync(mailData); //Send mail Waiting users
                
            }
            await ClearWaitingListForLesson(lessonId); //All Enrollments "Waiting" removed 
        }

            public async Task<bool> EnrollmentExistsAsync(EnrollmentDto enrollmentDto)
            {
                // This is just a mock implementation, replace it with the real one.
                var enrollment = await _repository.GetEnrollmentByUserAndLessonAsync(enrollmentDto.Email, enrollmentDto.LessonId);
        
                if (enrollment != null)
                {
                    return true;
                }

                return false;
            }
            
            public async Task ClearWaitingListForLesson(int lessonId)
            { 
                await _repository.DeleteEnrollmentsByLessonIdAndStatus(lessonId, "Waiting");  
            }
            
            public async Task<IEnumerable<LessonDto>> GetLessonsByLessonIdWorkoutId(int workoutId, string email)
            
            {
                var lessonIds = await _repository.GetEnrollmentsForUser(email);
                var lessonsFound = await _repository.GetLessonsByWorkout(workoutId);
                var filteredLessons = lessonsFound.Where(lesson => lessonIds.Contains(lesson.Id)).ToList();
                var locations = await _repository.GetLocations();
                var workouts = await _repository.GetAllWorkouts();
                var lessenDtos = filteredLessons.ConvertToDto(locations, workouts);

                return lessenDtos;
            }
            public async Task<IEnumerable<LessonDto>> FetchLessons(int lessonId)
            {


                var lessonsFound = await _repository.FetchLessons(lessonId);
                
                var locations = await _repository.GetLocations();
                var workouts = await _repository.GetAllWorkouts();
                
                var lessenDtos = lessonsFound.ConvertToDto(locations, workouts);

                return lessenDtos;
            }

    }
    
    
}