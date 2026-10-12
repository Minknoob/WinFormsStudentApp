using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class Exer1DbContext : DbContext
    {
        public Exer1DbContext() : base("name=MyConn")
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
