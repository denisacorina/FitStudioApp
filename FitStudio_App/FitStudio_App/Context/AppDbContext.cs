using FitStudio_App.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.DependencyResolver;

namespace FitStudio_App.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            //model.Entity<Employee>().ToTable("Employees");
            //model.Entity<Trainer>().ToTable("Trainers");
            AddDefaultData(model);

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<MembershipInfo> MembershipInfos { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Role> Roles { get; set; }

        private static void AddDefaultData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role() { RoleId = 1, RoleType = "Admin" },
                new Role() { RoleId = 2, RoleType = "Client" },
                new Role() { RoleId = 3, RoleType = "Receptionist" },
                new Role() { RoleId = 4, RoleType = "Trainer" });

            modelBuilder.Entity<PaymentType>().HasData(
                new PaymentType() { Id = 1, Type = "Cash" },
                new PaymentType() { Id = 2, Type = "Card" });

            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType() { Id = 1, Type = "Bronze", Price = 19.99 },
                new MembershipType() { Id = 2, Type = "Silver", Price = 34.99 },
                new MembershipType() { Id = 3, Type = "Gold", Price = 49.99 });

            modelBuilder.Entity<Class>().HasData(
                new Class() { ClassId = 1, ClassName = "Kangoo Jumps", Activity = "Fitness", Intensity = "Medium", StartTime = new DateTime(2011, 6, 10, 15, 24, 16), EndTime = new DateTime(2022, 12, 12, 10, 50, 00), WeekDay = "Monday" },
                new Class() { ClassId = 2, ClassName = "Real Ryder", Activity = "Cardio", Intensity = "Extreme", StartTime = new DateTime(2022, 12, 12, 11, 00, 00), EndTime = new DateTime(2022, 12, 12, 11, 50, 00), WeekDay = "Monday" },
                new Class() { ClassId = 3, ClassName = "Kangoo Jumps", Activity = "Fitness", Intensity = "Medium", StartTime = new DateTime(2022, 12, 12, 14, 00, 00), EndTime = new DateTime(2022, 12, 12, 14, 50, 00), WeekDay = "Monday" },
                new Class() { ClassId = 4, ClassName = "Kangoo Jumps", Activity = "Fitness", Intensity = "Medium", StartTime = new DateTime(2022, 12, 13, 10, 00, 00), EndTime = new DateTime(2022, 12, 13, 10, 50, 00), WeekDay = "Tuesday" },
                new Class() { ClassId = 5, ClassName = "Real Ryder", Activity = "Cardio", Intensity = "Extreme", StartTime = new DateTime(2022, 12, 14, 10, 00, 00), EndTime = new DateTime(2022, 12, 14, 10, 50, 00), WeekDay = "Wednesday" }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { EmployeeId = 2, Name = "Adi", RoleId = 3 },
                new Employee() { EmployeeId = 5, Name = "Andra", RoleId = 3 },
                 new Employee() { EmployeeId = 1, Name = "Anca", RoleId = 4, ClassId = 1 },
                new Employee() { EmployeeId = 3, Name = "Alex", RoleId = 4, ClassId = 2 },
                new Employee() { EmployeeId = 4, Name = "Maria", RoleId = 4, ClassId = 4 },
                new Employee() { EmployeeId = 6, Name = "Cristian", RoleId = 4, ClassId = 3 },
                new Employee() { EmployeeId = 7, Name = "Lucian", RoleId = 4, ClassId = 5 });

            //modelBuilder.Entity<Trainer>().HasData(
            //    new Trainer() { EmployeeId = 1, Name = "Anca", RoleId = 4, ClassId = 1 },
            //    new Trainer() { EmployeeId = 3, Name = "Alex", RoleId = 4, ClassId = 2 },
            //    new Trainer() { EmployeeId = 4, Name = "Maria", RoleId = 4, ClassId = 4 },
            //    new Trainer() { EmployeeId = 6, Name = "Cristian", RoleId = 4, ClassId = 3 },
            //    new Trainer() { EmployeeId = 7, Name = "Lucian", RoleId = 4, ClassId = 5 });
        }

        
    }
}
