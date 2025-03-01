

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
    new CostEntity {Id = 1, Cost = 150, ServiceTypeId = 1 }, 
    new CostEntity {Id = 2, Cost = 500, ServiceTypeId = 2 }
     ];

    public static readonly ServiceTypeEntity[] ServiceTypeEntities =
  [
  new ServiceTypeEntity {Id = 1, TypeName = "Monthly", ServiceCategoryId = 2 },
    new ServiceTypeEntity {Id = 2, TypeName = "Hourly", ServiceCategoryId = 1}

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
  new CustomerEntity {Id = 1, CustomerName = "Company", CustomerTypeId = 1, TypeOfIndustryId = 1, CustomerAddressId = 1, CustomerReferenceId = 1 },
    new CustomerEntity {Id = 2, CustomerName = "Företag", CustomerTypeId = 2, TypeOfIndustryId = 2, CustomerAddressId = 2, CustomerReferenceId = 2  }
    
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

    public static readonly ProjectScheduleEntity[] ProjectSchedulesEntities =
[
new ProjectScheduleEntity {Id = 1, StartDate = new DateOnly(2025, 1, 1), EndDate = new DateOnly(2025, 2, 2)},
    new ProjectScheduleEntity {Id = 2, StartDate = new DateOnly(2025, 5, 5), EndDate = new DateOnly(2025, 6, 6) }
];


    public static readonly StatusTypeEntity[] StatusTypeEntities =
[
new StatusTypeEntity {Id = 1, TypeName = "Ongoing" },
new StatusTypeEntity {Id = 2, TypeName = "Finished" },

];

    public static readonly TypeOfIndustryEntity[] TypeOfIndustryEntities =
[
new TypeOfIndustryEntity {Id = 1, TypeName = "Forest" },
new TypeOfIndustryEntity {Id = 2, TypeName = "Industry" },

];






    public static readonly ProjectEntity[] ProjectsEntities = 
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

        new ProjectEntity {  Id = 2,
       ProjectName = "ProjektNamn 2",
       CustomerId = 2,
       ProjectManagerId = 2,
       ProjectScheduleId = 2,
       StatusTypeId = 2,
       ServiceTypeId = 2,
       UserId = 2,
       ProjectNoteId = 2,},
        
       ];







   
}
