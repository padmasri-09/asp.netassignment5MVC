using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AssignmentDay4MVC5.Models;

namespace AssignmentDay4MVC5.Controllers
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=accountconn")
        {

        }
        public DbSet<Account> Accounts { get; set; }

    }
}