using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Full_Stack_Demo.Models;

namespace Full_Stack_Demo.Data
{
    public class Full_Stack_DemoContext : DbContext
    {
        public Full_Stack_DemoContext (DbContextOptions<Full_Stack_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Full_Stack_Demo.Models.Person> Person { get; set; } = default!;
    }
}
