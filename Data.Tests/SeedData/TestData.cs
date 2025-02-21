

using Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Data.Tests.SeedData;
//Här har vi all data vi vill använda för att populera saker i testningen
public static class TestData
{

    public static readonly UserEntity[] UsersEntities =
    [
    new UserEntity {Id = 1, FirstName = "Johan", LastName = "Hansson", Email = "Johan@mail.com" },
    new UserEntity {Id = 2, FirstName = "Gabriel", LastName = "Garcia", Email = "GG@mail.com" }
     ];


    public static readonly CostEntity[] CostsEntities =
    [
    new CostEntity {Id = 1, Cost = 100 }, 
    new CostEntity {Id = 2, Cost = 1200 }
     ];

    public static readonly ServiceTypeEntity[] ServiceTypeEntities =
  [
  new ServiceTypeEntity {Id = 1, TypeName = "Monthly" },
    new ServiceTypeEntity {Id = 2, TypeName = "Hourly" }
   ];


      public static readonly ServiceCategoryEntity[] ServiceCategoryEntities =
  [
  new ServiceCategoryEntity {Id = 1, CategoryName = "Blue" },
    new ServiceCategoryEntity {Id = 2, CategoryName = "Green" }
   ];      
    
    
    public static readonly CustomerAddressEntity[] CustomerAddressEntities =
  [
  new CustomerAddressEntity {Id = 1, Address = "Kungsgatan 1" },
    new CustomerAddressEntity {Id = 2, Address = "Torstenssonsgatan 12" }
   ];  
    
    public static readonly CustomerEntity[] CustomerEntities =
  [
  new CustomerEntity {Id = 1, CustomerName = "Company" },
    new CustomerEntity {Id = 2, CustomerName = "Företag" }
    
   ];

    public static readonly CustomerReferenceEntity[] CustomerReferencesEntities =
[
new CustomerReferenceEntity {Id = 1, Reference = "123" },
    new CustomerReferenceEntity {Id = 2, Reference = "Note" }

];

    public static readonly CustomerTypeEntity[] CustomerTypesEntities =
[
new CustomerTypeEntity {Id = 1, TypeName = "New" },
    new CustomerTypeEntity {Id = 2, TypeName = "Loyal" }

];


    public static readonly ProjectManagerEntity[] ProjectManagersEntities =
[
new ProjectManagerEntity {Id = 1, FirstName = "Ivan", LastName = "Andersson" },
    new ProjectManagerEntity {Id = 2, FirstName = "Hanna", LastName = "Sanden" }

];

    public static readonly ProjectManagerOrientationEntity[] ProjectManagerOrientationsEntities =
[
new ProjectManagerOrientationEntity {Id = 1, TypeOfOrientation = "New" },
    new ProjectManagerOrientationEntity {Id = 2, TypeOfOrientation = "Experienced" }

];

    public static readonly ProjectNoteEntity[] ProjectNotesEntities =
[
new ProjectNoteEntity {Id = 1, Notes = "Take note" },
    new ProjectNoteEntity {Id = 2, Notes = "Information" }

];

//    public static readonly ProjectScheduleEntity[] ProjectSchedulesEntities =
//[
//new ProjectScheduleEntity {Id = 1, StartDate = 01.01.2001, EndDate = "1924-01-05" },
//    new ProjectScheduleEntity {Id = 2, StartDate = 01-01-01, EndDate = "1924-01-05" }
//];


    public static readonly StatusTypeEntity[] StatusTypeEntities =
[
new StatusTypeEntity {Id = 1, TypeName = "Ongoing" },
new StatusTypeEntity {Id = 1, TypeName = "Finished" },

];

    public static readonly TypeOfIndustryEntity[] TypeOfIndustryEntities =
[
new TypeOfIndustryEntity {Id = 1, TypeName = "Forest" },
new TypeOfIndustryEntity {Id = 1, TypeName = "Industry" },

];






    public static readonly ProjectEntity[] ProjectsEntities = //lägg till de andra delarna
       [
       new ProjectEntity    { 
           Id = 1,
       ProjectName = "ProjektNamn 1", 
       CustomerId = 1, 
       ProjectManagerId = 1,
       ProjectScheduleId = 1,
       StatusTypeId = 1,
       ServiceTypeId = 1,
       UserId = 1,
       ProjectNoteId = 1,
       },



        //Upprepa
        new ProjectEntity { ProjectName = "Projektnamn 2"},
        new ProjectEntity { ProjectName = "Projektnamn 3"}
       ];







   
}
