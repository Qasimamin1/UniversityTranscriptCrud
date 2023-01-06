using EFMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMVC.Context
{
    public class MVCContext: DbContext
    {
        // create a constructor 

        public MVCContext(DbContextOptions options): base(options)
        {



        }
        // these are the enitities which are mapped into the database
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Subject> Teachers { get; set; }
    
    }
}
