using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //i added this
using netProject2.Models.Entity; //and this

namespace netProject2.Models.Entity
{
    public class Context:DbContext
    {
       public DbSet<Hotels> Hotel { get; set; }
    }
}