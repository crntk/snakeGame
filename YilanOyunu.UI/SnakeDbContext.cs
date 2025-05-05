using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YilanOyunu.UI.Models;

namespace YilanOyunu.UI
{
    public class SnakeDbContext: DbContext
    {
        public DbSet<Kullanici> Kullanici { get; set; }
       public  DbSet<OyunKaydi> OyunKaydi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=CRNTK\\SQLEXPRESS;Database=YilanOyunu;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
