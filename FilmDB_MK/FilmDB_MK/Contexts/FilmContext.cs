using FilmDB_MK.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmDB_MK.Contexts
{
    public class FilmContext : DbContext
    {
        public DbSet<FilmModel> Films { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder dbContextOptions)
        {
            var cs = @"Data Source=DESKTOP-CRJ29E0\SQLDAST;Initial Catalog=FilmDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbContextOptions.UseSqlServer(cs);
        }
    }
}
