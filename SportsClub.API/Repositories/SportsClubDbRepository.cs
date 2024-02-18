using Microsoft.EntityFrameworkCore;
using SportsClub.API.Data;
using SportsClub.API.Entities;
using SportsClub.API.Repositories.Contracts;
using SportsClub.Models.Dtos;
using SportsClub.SharedModels.Dtos;
using SportsClub.SharedModels;

namespace SportsClub.API.Repositories
{
    public class SportsClubDbRepository : ISportsClubRepository
    {
        private readonly SportsClubDbContext sportsClubDbContext;

        public SportsClubDbRepository(SportsClubDbContext sportsClubDbContext )
        {
            this.sportsClubDbContext = sportsClubDbContext;
    
        }
        public async Task<IEnumerable<Location>> GetLocations()
        {
            return await sportsClubDbContext.Locations.ToListAsync();
        }

        public async Task<IEnumerable<Workout>> GetAllWorkouts()
        {
            return await sportsClubDbContext.Workouts.ToListAsync();
        }

        public async Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime)
        {
            var found = new List<Lesson>();
            found = await sportsClubDbContext.Lessons
                .Where((Lesson w) => w.StartDateTime >= startDateTime && w.StartDateTime <= endDateTime)
                .ToListAsync();

            return found;
        }


        public async Task<IEnumerable<Enrollment>> GetEnrollmentsCurrentUserandLesson(string email, int lessonId)
        {
            return await sportsClubDbContext.Enrollments
                .Where(e => e.Email == email && e.LessonId == lessonId)
                .ToListAsync();
        }

        public async Task<Enrollment> AddEnrollment(Enrollment enrollment)
        {
            var result = await sportsClubDbContext.Enrollments.AddAsync(enrollment);
            return result.Entity;
        }

        public async Task<bool> EnrollmentExists(int lessonId, string email)
        {
            return await sportsClubDbContext.Enrollments
                .AnyAsync(e => e.LessonId == lessonId && e.Email == email);
        }

        public async Task<List<string>> GetWaitingListByLessonId(int lessonId)
        {
            return await sportsClubDbContext.Enrollments
                .Where(e => e.LessonId == lessonId && e.EnrolledStatus == "Waiting")
                .Select(e => e.Email)
                .ToListAsync();
        }

        public async Task<IEnumerable<Lesson>> GetLessonsByWorkout(int workoutId)
        {
            return await sportsClubDbContext.Lessons
                .Where(e => e.WorkOutId == workoutId)
                .ToListAsync();
        }

        public async Task<Enrollment> GetEnrollmentByEmailAndLessonId(string email, int lessonId)
        {
            return await sportsClubDbContext.Enrollments
                .Where(e => e.Email == email && e.LessonId == lessonId)
                .FirstOrDefaultAsync();
        }

        public async Task<Lesson> GetLessonById(int lessonId)
        {
            return await sportsClubDbContext.Lessons
                .Where(lesson => lesson.Id == lessonId)
                .FirstOrDefaultAsync();
        }

        public void RemoveEnrollment(Enrollment enrollment)
        {
            sportsClubDbContext.Enrollments.Remove(enrollment);
        }

        public void UpdateLesson(Lesson lesson)
        {
            sportsClubDbContext.Lessons.Update(lesson);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await sportsClubDbContext.SaveChangesAsync();
        }
        public async Task CancelEnrollment(string email, int lessonId)
        {
            var enrollment = await GetEnrollmentByEmailAndLessonId(email, lessonId);
            if (enrollment != null)
            {
                RemoveEnrollment(enrollment);
                await SaveChangesAsync();
            }
            else
            {
                //throw error
            }
        }
        public async Task<Enrollment> GetEnrollmentByUserAndLessonAsync(string userId, int lessonId)
        {
            return await sportsClubDbContext.Enrollments.FirstOrDefaultAsync(e => e.Email == userId && e.LessonId == lessonId);
        }



        public async Task<List<int>> GetEnrollmentsForUser(string userId)
        {
            var enrollments = await sportsClubDbContext.Enrollments
                .Where(e => e.Email == userId)
                .ToListAsync();

            var lessonIds = enrollments.Select(e => e.LessonId).ToList();
            return lessonIds;
        }



        public async Task DeleteEnrollmentsByLessonIdAndStatus(int lessonId, string status)
        {
            var enrollments = sportsClubDbContext.Enrollments
                .Where(e => e.LessonId == lessonId && e.EnrolledStatus == status)
                .ToList();

            foreach (var entry in enrollments)
            {
                sportsClubDbContext.Enrollments.Remove(entry);
            }
    
            await sportsClubDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Lesson>> FetchLessons(int lessonId)
        {
            return await sportsClubDbContext.Lessons
                .Where(e => e.Id == lessonId)
                .ToListAsync();
            
        }
        
        
    }
}
