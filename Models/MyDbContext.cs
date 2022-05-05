using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AssignmentDay4MVC5.Models;

namespace Assignment3DayMVC5.Models
{

    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=accountconn")
        {

        }
        public DbSet<Account> Accounts { get; set; }

    }

    
    
   
}