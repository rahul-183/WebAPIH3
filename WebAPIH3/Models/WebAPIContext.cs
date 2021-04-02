using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIH3.Models
{
    public class WebAPIContext:DbContext
    {
       // internal static object courses;

        public WebAPIContext():base("Connection")
        {

        }
        public DbSet<Course>Courses { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}