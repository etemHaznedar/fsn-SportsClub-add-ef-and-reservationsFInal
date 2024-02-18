using SportsClub.Models.Dtos;

namespace SportsClub.API.Repositories.Contracts;
using SportsClub.SharedModels.Dtos;

public interface IEnrollmentService
{
    Task<IEnumerable<EnrollmentDto>> GetEnrollmentsCurrentUserandLesson(string email, int lessonId);
    Task<bool> ReserveAsync(EnrollmentDto enrollDto);
    Task CancelEnrollment(string email, int lessonId);
    Task<bool> EnrollmentExistsAsync(EnrollmentDto enrollmentDto);

    Task<IEnumerable<LessonDto>> GetLessonsByLessonIdWorkoutId(int workoutId, string emaail);


    Task<IEnumerable<LessonDto>> FetchLessons(int lessonId);
}