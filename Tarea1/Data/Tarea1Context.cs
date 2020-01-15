using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarea1.Models;

namespace Tarea1.Data
{
    public class Tarea1Context : DbContext
    {
        public Tarea1Context (DbContextOptions<Tarea1Context> options)
            : base(options)
        {
        }

        public DbSet<Tarea1.Models.Usuario> Usuario { get; set; }
    }
}
