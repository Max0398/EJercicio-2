using Microsoft.EntityFrameworkCore;
using UniversityBackend.Models.DataModels;

namespace UniversityBackend.DataAccess
{
    public class UniversityDBContex:DbContext
    {
        public UniversityDBContex(DbContextOptions <UniversityDBContex>options):base (options)
        {

        }

        //TODO: Add DBSets(Tablas de la base de datos)

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set;}
        public DbSet<Chapter>? Chapters{ get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set;}
       
    }
}
