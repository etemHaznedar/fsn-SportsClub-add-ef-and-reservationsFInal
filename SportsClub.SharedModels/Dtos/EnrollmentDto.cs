namespace SportsClub.SharedModels.Dtos

{
    
    public record EnrollmentDto(
        int Id,
        int LessonId,
        int WorkoutId,
        string Location,
        string Email,
        DateTime StartDateTime,
        string EnrolledStatus,
        DateTime EnrollmentDate //Not relevant anymore....
    );
}