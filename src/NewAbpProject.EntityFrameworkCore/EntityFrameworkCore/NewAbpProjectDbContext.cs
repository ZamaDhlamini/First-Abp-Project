using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NewAbpProject.Authorization.Roles;
using NewAbpProject.Authorization.Users;
using NewAbpProject.MultiTenancy;
using NewAbpProject.Domain;

namespace NewAbpProject.EntityFrameworkCore
{
    public class NewAbpProjectDbContext : AbpZeroDbContext<Tenant, Role, User, NewAbpProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lecture> Lecturers { get; set; }
        public DbSet<LectureModule> LecturersModules { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RegisterModule> RegisteredModules { get; set; }
        public DbSet<Person> ARFPersons { get; set; }

        public NewAbpProjectDbContext(DbContextOptions<NewAbpProjectDbContext> options)
            : base(options)
        {
        }
    }
}
