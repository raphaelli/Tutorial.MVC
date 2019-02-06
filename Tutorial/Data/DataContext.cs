using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial.Model;

namespace Tutorial.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DbContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
