using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Login.Models
{
    public class LoginContext : DbContext
    {
        public LoginContext (DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public DbSet<Login.Models.Persona> Persona { get; set; }
    }
}
