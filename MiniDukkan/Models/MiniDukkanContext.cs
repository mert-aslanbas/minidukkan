using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniDukkan.Models
{
    public class MiniDukkanContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {

        
            optionsBuilder.UseSqlServer("Server=PC-AYDINMUTLU\\MSSQLSERVER01;Database=MiniDukkanDB;Trusted_Connection=True");
    
        }
        public MiniDukkanContext(DbContextOptions<MiniDukkanContext> options ): base(options)
        {
       
        }
        public DbSet<Urun>Urunler { get; set; }
    }
}