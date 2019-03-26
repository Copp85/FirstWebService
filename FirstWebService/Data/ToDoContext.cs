using FirstWebService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebService.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext>options)
            : base(options)
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

    }
}
