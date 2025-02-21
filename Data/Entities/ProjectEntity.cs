
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class ProjectEntity
{
    [Key]
    public int Id { get; set; }
    public string ProjectName { get; set; } = null!;

    public int CustomerId { get; set; }
    public CustomerEntity Customer { get; set; } = null!;
  
    public int ServiceTypeId { get; set; }
    public ServiceTypeEntity ServiceType { get; set; } = null!;


    public int ProjectManagerId { get; set; }
    public ProjectManagerEntity ProjectManager { get; set; } = null!;


    public int StatusTypeId { get; set; }
    public StatusTypeEntity StatusType { get; set; } = null!;


    public int UserId { get; set; } 
    public UserEntity User { get; set; } = null!;

    public int ProjectNoteId { get; set; }
    public ProjectNoteEntity ProjectNote { get; set; } = null!;

    public int ProjectScheduleId {  get; set; }
    public ProjectScheduleEntity ProjectSchedule { get; set; } = null!;

}
