namespace Business.Models;

public class ProjectScheduleRegistrationForm
{

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public int ProjectId { get; set; }
}
