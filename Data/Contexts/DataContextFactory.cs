using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;


//HA DENNA FRAM TILLS ATT WEB API ÄR PÅ PLATS
//public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
//{
//    public DataContext CreateDbContext(string[] args)
//    {
//        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
//        optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\ProjectsSchool\\JFProjectManagementSystem\\Data\\Databases\\DataBasePMSystem.mdf;Integrated Security=True;Connect Timeout=30");

//        return new DataContext(optionsBuilder.Options);
//    }
//}

