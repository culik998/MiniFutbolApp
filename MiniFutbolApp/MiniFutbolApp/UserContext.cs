using MiniFutbolApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFutbolApp
{
     
      public  class UserContext : DbContext
        {
            public UserContext()
                : base("football")
            { }

       public DbSet<User> Users { get; set; }
       public DbSet<Team> Teams { get; set; }
       public DbSet<Game> Games { get; set; }
      


        
        }
    
}
