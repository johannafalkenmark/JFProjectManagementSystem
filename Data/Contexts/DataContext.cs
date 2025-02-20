
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

public class DataContext : DbContext
{
    //Här ska vi registrera våra entitetr som blir tabeller i databasen
  
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected DataContext()
        {

        }

        //Det jag skriver döps tabellen till (Customer)
        public virtual DbSet<CustomerEntity> Customers { get; set; }
        public virtual DbSet<ProjectEntity> Projects { get; set; }
        public virtual DbSet<CostEntity> Cost { get; set; }
        public virtual DbSet<CustomerAddressEntity> CustomerAddress { get; set; }
        public virtual DbSet<CustomerReferenceEntity> CustomerReference { get; set; }
        public virtual DbSet<CustomerTypeEntity> CustomerType { get; set; }
        public virtual DbSet<ProjectManagerEntity> ProjectManager { get; set; }
        public virtual DbSet<ProjectManagerOrientationEntity> ProjectManagerOrientation { get; set; }
        public virtual DbSet<ProjectNoteEntity> ProjectNote { get; set; }
        public virtual DbSet<ProjectScheduleEntity> ProjectSchedule { get; set; }
        public virtual DbSet<ServiceCategoryEntity> ServiceCategory { get; set; }
        public virtual DbSet<ServiceTypeEntity> ServiceType { get; set; }
        public virtual DbSet<StatusTypeEntity> StatusType { get; set; }
        public virtual DbSet<TypeOfIndustryEntity> TypeOfIndustry { get; set; }
        public virtual DbSet<UserEntity> User { get; set; }





    

}
