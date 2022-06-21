using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DropDown1.Models
{
    public class DataDBContext : DbContext
    {

        public  DataDBContext():base("connection")
        {

        }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }    
        
    }
}