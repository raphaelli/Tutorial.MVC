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
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            //Options = options;
        }

        //public DbContextOptions<DataContext> Options { get; }

        public DbSet<Student> Students { get; set; }
    }
}
