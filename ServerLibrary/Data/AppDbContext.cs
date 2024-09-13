﻿using BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace ServerLibrary.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<GeneralDepartment> GeneralDepartments { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Branch> Branches { get; set; }
   //city-town
    public DbSet<Country> Countries { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Town> Towns { get; set; }
    //role
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<SystemRole> SystemRoles { get; set; }
    public DbSet<RefreshTokenInfo> RefreshTokenInfos { get; set; }

    // other
    public DbSet<Vacation> Vacations { get; set; }
    public DbSet<VacationType> VacationTypes { get; set; }
    public DbSet<OverTime> OverTimes { get; set; }
    public DbSet<OverTimetype> OverTimetypes { get; set; }
    public DbSet<Sanction> Sanctions { get; set; }
    public DbSet<SanctionType> SanctionTypes { get; set; }
    public DbSet<Doctor> Doctors { get; set; }


}

