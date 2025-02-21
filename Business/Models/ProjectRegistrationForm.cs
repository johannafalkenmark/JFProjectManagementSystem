namespace Business.Models;

public class ProjectRegistrationForm
{

    public string ProjectName { get; set; } = null!;

    public int CustomerId { get; set; } 

    public int ProjectManagerId { get; set; }

    public int ServiceTypeId { get; set; }

    public int StatusTypeId {  get; set; }

    public int UserId { get; set; }

    public int ProjectNoteId { get; set; }

    public int ProjectScheduleId { get; set; }
}
