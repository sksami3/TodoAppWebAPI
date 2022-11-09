using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using TodoAppDomain.Model;

namespace CManager.Web.Context
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext() : base()
        {

        }
        public DbSet<Todo> Todos { get; set; }
        
    }
}
