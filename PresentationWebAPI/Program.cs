using Business.Interfaces;
using Business.Services;
using Data.Contexts;
using Data.Interfaces;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "_myAllowSpecificOrgins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,

        policy =>
        {
            policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
        });
});


builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddScoped<ICustomerAddressRepository, CustomerAddressRepository>();
builder.Services.AddScoped<ICustomerAddressService, CustomerAddressService>();

builder.Services.AddScoped<ICustomerTypeRepository, CustomerTypeRepository >();
builder.Services.AddScoped<ICustomerTypeService, CustomerTypeService >();

builder.Services.AddScoped<IProjectManagerOrientationRepository, ProjectManagerOrientationRepository>();
builder.Services.AddScoped<IProjectManagerOrientationService, ProjectManagerOrientationService>();

builder.Services.AddScoped<IProjectManagerRepository, ProjectManagerRepository>();
builder.Services.AddScoped<IProjectManagerService, ProjectManagerService>();

builder.Services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
builder.Services.AddScoped<IServiceTypeService, ServiceTypeService>();

builder.Services.AddScoped<IStatusTypeRepository, StatusTypeRepository>();
builder.Services.AddScoped<IStatusTypeService, StatusTypeService>();

builder.Services.AddScoped<ITypeOfIndustryRepository, TypeOfIndustryRepository>();
builder.Services.AddScoped<ITypeOfIndustryService, TypeOfIndustryService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IProjectNoteRepository, ProjectNoteRepository>();
builder.Services.AddScoped<IProjectNoteService, ProjectNoteService>();

builder.Services.AddScoped<IProjectScheduleRepository, ProjectScheduleRepository>();
builder.Services.AddScoped<IProjectScheduleService, ProjectScheduleService>();


builder.Services.AddScoped<ICostRepository, CostRepository>();
builder.Services.AddScoped<ICostService, CostService>();


builder.Services.AddScoped<ICustomerReferenceRepository, CustomerReferenceRepository>();
builder.Services.AddScoped<ICustomerReferenceService, CustomerReferenceService>();

builder.Services.AddScoped<IServiceCategoryRepository, ServiceCategoryRepository>();
builder.Services.AddScoped<IServiceCategoryService, ServiceCategoryService>();







var app = builder.Build();
app.MapOpenApi();
app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.UseCors(MyAllowSpecificOrigins);

app.Run();
