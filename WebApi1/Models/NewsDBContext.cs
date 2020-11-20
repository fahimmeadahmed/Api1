using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Models
{
    public class NewsDBContext:DbContext
    {
        public NewsDBContext(DbContextOptions<NewsDBContext> options):base(options)
        {

        }
        public DbSet<NList> NLists { get; set; }
        public DbSet<NDate> NDates { get; set; }

    }
}
