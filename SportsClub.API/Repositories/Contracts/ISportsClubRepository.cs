using SportsClub.API.Entities;
using SportsClub.SharedModels.Dtos;

namespace SportsClub.API.Repositories.Contracts;

public interface ISportsClubRepository
{
    Task<IEnumerable<Location>> GetLocations();
    Task<IEnumerable<Workout>> GetAllWorkouts();
    Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime);
    Task<IEnumerable<Enrollment>> GetEnrollmentsCurrentUserandLesson(string email, int lessonId);
    Task<Enrollment> GetEnrollmentByUserAndLessonAsync(string userId, int lessonId);

    
    Task<Enrollment> AddEnrollment(Enrollment enrollment);
    Task<bool> EnrollmentExists(int lessonId, string email);
    Task<List<string>> GetWaitingListByLessonId(int lessonId);
    Task<IEnumerable<Lesson>> GetLessonsByWorkout(int workoutId);
    
    
    Task<Enrollment> GetEnrollmentByEmailAndLessonId(string email, int lessonId);
    Task<Lesson> GetLessonById(int lessonId);
    void RemoveEnrollment(Enrollment enrollment);
    void UpdateLesson(Lesson lesson);
    Task<int> SaveChangesAsync();
    Task DeleteEnrollmentsByLessonIdAndStatus(int lessonId, string status);
    
    Task<List<int>> GetEnrollmentsForUser(string email);
    Task<IEnumerable<Lesson>> FetchLessons(int lessonId);
}

