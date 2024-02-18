namespace SportsClub.API.Entities;

public class Enrollment
{

    public int Id { get; set; }
    public int LessonId { get; set; }
    public int WorkoutId { get; set; }
    //public Lesson Lesson { get; set; } // Navigation property
    public string Location { get; set; }
    public required string Email { get; set; }
    public DateTime StartDateTime { get; set; }
    public string EnrolledStatus { get; set; } //Enrolled, Waiting
    public DateTime EnrollmentDate { get; set; }
}