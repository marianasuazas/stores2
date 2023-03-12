using Microsoft.EntityFrameworkCore;
using Stores.Shared.Entities;

namespace Stores.API.Data
{
    //HERENCIA CONECION BASE DE DATOS
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        //OVERRAIDE MODEL
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //MAPEO ENTIDADES

            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique();

        }
    }
}
