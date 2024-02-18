using SportsClub.API.Data;
using SportsClub.API.Entities;
using SportsClub.API.Repositories.Contracts;
using SportsClub.SharedModels.Dtos;

namespace SportsClub.API.Repositories;

public class SportsClubInMemoryRepository : ISportsClubRepository
{
    public async Task<IEnumerable<Location>> GetLocations()
    {
        await Task.Delay(100);
        IEnumerable<Location> locations
            = SportClubSeedData.Locations;

        return locations;
    }

    public async Task<IEnumerable<Workout>> GetAllWorkouts()
    {
        await Task.Delay(100);

        return SportClubSeedData.Workouts;
    }

    public async Task<IEnumerable<Lesson>> GetSchedule(DateTime startDateTime, DateTime endDateTime)
    {
        await Task.Delay(100);

        IEnumerable<Lesson> found
            = SportClubSeedData.Lessons
            .Where((Lesson w) => w.StartDateTime >= startDateTime && w.StartDateTime <= endDateTime);

        return found;
    }

    public Task<IEnumerable<Enrollment>> GetEnrollmentsCurrentUserandLesson(string email, int lessonId)
    {
        throw new NotImplementedException();
    }

    public Task<Enrollment> GetEnrollmentByUserAndLessonAsync(string userId, int lessonId)
    {
        throw new NotImplementedException();
    }

    public Task<Enrollment> AddEnrollment(Enrollment enrollment)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EnrollmentExists(int lessonId, string email)
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> GetWaitingListByLessonId(int lessonId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsByWorkout(int workoutId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsByLessonIdWorkoutId(int workoutId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsByWorkoutAndUser(int workoutId, string userEmail)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public Task CancelEnrollment(string email, int lessonId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEnrollmentsByLessonIdAndStatus(int lessonId, string status)
    {
        throw new NotImplementedException();
    }

    public Task<List<int>> GetEnrollmentsForUser(string email)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> FetchLessons(int lessonId)
    {
        throw new NotImplementedException();
    }


    public Task<bool> ReserveAsync(EnrollmentDto enrollmentDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EnrollmentExistsAsync(EnrollmentDto enrollmentDto)
    {
        throw new NotImplementedException();
    }

    public Task CheckWaitingListAndNotifyUsers(int lessonId)
    {
        throw new NotImplementedException();
    }

    public Task<Lesson> GetLessonByWorkoutAndUser(int workoutId, string userEmail)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lesson>> GetLessonsUserWorkout(int workoutId)
    {
        throw new NotImplementedException();
    }

    public Task<Enrollment> GetEnrollmentByEmailAndLessonId(string email, int lessonId)
    {
        throw new NotImplementedException();
    }

    public Task<Lesson> GetLessonById(int lessonId)
    {
        throw new NotImplementedException();
    }

    public void RemoveEnrollment(Enrollment enrollment)
    {
        throw new NotImplementedException();
    }

    public void UpdateLesson(Lesson lesson)
    {
        throw new NotImplementedException();
    }
}
