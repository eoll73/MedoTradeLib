using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedoTradeLib.Models
{
    public class LibDbContext : DbContext
    {
        public LibDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Messages> Messages { get; set; }
    }
}
