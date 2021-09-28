using ListOfTrackModels;
using Microsoft.EntityFrameworkCore;


namespace ListOfTrackDAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Track> Tracks { get; set; }
        public DbSet<ListOfTracks> ListOfTracks { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=track;Trusted_Connection=True;");
        }

    }

}
