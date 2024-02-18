using SportsClub.API.Entities;
using SportsClub.Models.Dtos;
using SportsClub.SharedModels.Dtos;

namespace SportsClub.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<WorkoutDto> ConvertToDto(this IEnumerable<Workout> workouts)
        {
            return (from workout in workouts
                    select new WorkoutDto
                    (workout.Id,
                      workout.Title,
                      workout.Description,
                      workout.Category,
                      workout.Image,
                      workout.Duration,
                      workout.Price

                    )).ToList();
        }

        public static IEnumerable<LessonDto> ConvertToDto(this IEnumerable<Lesson> lessons, IEnumerable<Location> locations, IEnumerable<Workout> workouts)
        {
            return (from lesson in lessons
                    let workout = workouts.FirstOrDefault(workouts => workouts.Id == lesson.WorkOutId)
                    let location = locations.FirstOrDefault(locations => locations.Id == lesson.LocationId)
                    select new LessonDto
                    (lesson.Id,
                        lesson.WorkOutId,
                      workout.Title,
                      workout.Description,
                      workout.Category,
                      workout.Image,
                      workout.Duration,
                      workout.Price,

                      lesson.StartDateTime,
                      location.Name,
                      lesson.Instructor,
                      lesson.CurrentCapacity,
                      lesson.MaxCapacity
                    )).ToList();
        }
        
        public static EnrollmentDto ConvertToDto(Enrollment enrollment)
        {
            return new EnrollmentDto(
                enrollment.Id,
                enrollment.LessonId,
                enrollment.WorkoutId,
                enrollment.Location,
                enrollment.Email,
                enrollment.StartDateTime,
                enrollment.EnrolledStatus,
                enrollment.EnrollmentDate
            );
        }


    }
    
}
