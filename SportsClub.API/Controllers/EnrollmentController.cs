using Microsoft.AspNetCore.Mvc;
using SportsClub.API.Repositories.Contracts;
using SportsClub.Models.Dtos;
using SportsClub.SharedModels.Dtos;

namespace SportsClub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {

        private readonly IEnrollmentService _enrollmentService;

        public EnrollmentController(IEnrollmentService enrollmentService)
        {
            _enrollmentService = enrollmentService;
        }

        // POST: api/enrollment/reserve
        [HttpPost("reserve")]
        public async Task<IActionResult> Reserve([FromBody] EnrollmentDto enrollmentDto)
        {
            try
            {
                bool enrollmentExists = await _enrollmentService.EnrollmentExistsAsync(enrollmentDto);

                if (enrollmentExists && enrollmentDto.EnrolledStatus == "Enrolled")
                {
                    return BadRequest("Reservation failed because the enrollment already exists.");
                }

                bool success = await _enrollmentService.ReserveAsync(enrollmentDto);
                return success ? Ok():BadRequest("Reservation failed");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
        
        // GET: api/enrollment/currentUser{}{}
        [HttpGet("currentUser/{email}/{lessonId}")]
        public async Task<ActionResult<IEnumerable<EnrollmentDto>>> GetEnrollmentsCurrentUser(string email, int lessonId)
        {
            try
            {
                var enrollments = await _enrollmentService.GetEnrollmentsCurrentUserandLesson(email, lessonId);

                if(enrollments == null || !enrollments.Any()) {
                    return Ok(new List<EnrollmentDto>()); //Empty list if no enrollments found
                }

                return Ok(enrollments);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
        // DELETE: api/enrollment/cancel/{email}/{lessonId}
        [HttpDelete("cancel/{email}/{lessonId}")]
        public async Task<IActionResult> Cancel(string email, int lessonId)
        {
            try
            {
                await _enrollmentService.CancelEnrollment(email, lessonId);
                return Ok();
            }
            catch (ArgumentException ex) when (ex.Message == "No such enrollment to cancel")
            {
                return NotFound($"Enrollment for user with email {email} for lesson {lessonId} not found");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
        // GET: api/enrollment/lessons{}{}
        [HttpGet("lessons/{workoutId}/{email}")]
        public async Task<IActionResult> GetLessonsByLessonIdWorkoutId(int workoutId, string email)
        {
            try
            {
                var lessons = await _enrollmentService.GetLessonsByLessonIdWorkoutId(workoutId, email);
                return Ok(lessons);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
        // GET: api/enrollment/FetchLesson{}
        [HttpGet("FetchLesson/{lessonId}")]
        public async Task<ActionResult<LessonDto>> FetchLesson(int lessonId)
        {

            try
            {
                var lessons = await _enrollmentService.FetchLessons(lessonId);
                return Ok(lessons);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }

        }
        
    }
}