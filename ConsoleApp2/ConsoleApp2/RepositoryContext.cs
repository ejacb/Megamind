using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ConsoleApp2
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext()
           : base("name=ConsoleApp2ConnectionString")
        {

        }
        public DbSet User { get; set; }
    }
} 

