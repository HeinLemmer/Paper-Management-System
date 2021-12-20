using System;
using Section2_IPG521.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Section2_IPG521.Data
{
    public class PapersDbContext : DbContext
    {
        public PapersDbContext()
            : base("PapersConnection") { }

        public DbSet<Papers> Paper { get; set; }
        public DbSet<Topic> Topics { get; set; }
            
    }
}