using System;
using AdvancedWebTechnologies.Shared;
using AdvancedWebTechnologiesHRM.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;


namespace AdvancedWebTechnologiesHRM.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
               

            //seed categories
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Belgium" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Serbia" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 9, Name = "Brazil" });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 1, JobCategoryName = "Development" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 2, JobCategoryName = "Sales" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 3, JobCategoryName = "Management" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 4, JobCategoryName = "HRM" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 5, JobCategoryName = "Finance" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 6, JobCategoryName = "QA" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 7, JobCategoryName = "DevOps" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 8, JobCategoryName = "Cleaning" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 9, JobCategoryName = "BA" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                CountryId = 2,
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Belgrade",
                Email = "draginja.andjelkovic@advancedwebtechnologies.com",
                EmployeeId = 1,
                FirstName = "Draginja",
                LastName = "Andjelkovic",
                Gender = Gender.Male,
                PhoneNumber = "381641684783",
                Smoker = false,
                Street = "Mihaila Avramovica 40",
                Zip = "11000",
                JobCategoryId = 1,
                Comment = "-",
                ExitDate = null,
                JoinedDate = new DateTime(2017, 12, 24),
                Latitude = 44.763750,
                Longitude = 20.461730
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {              
                EmployeeId = 2,
                CountryId = 1,
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1979, 1, 16),
                City = "Brussels",
                Email = "ana.smith@advancedwebtechnologies.com",
                FirstName = "Ana",
                LastName = "Smith",
                Gender = Gender.Female,
                PhoneNumber = "324777888773",
                Smoker = false,
                Street = "Grote Markt 1",
                Zip = "1000",
                JobCategoryId = 6,
                Comment = "-",
                ExitDate = null,
                JoinedDate = new DateTime(2015, 3, 1),
                Latitude = 50.846829,
                Longitude = 4.352894
            });
        }
    }
}
