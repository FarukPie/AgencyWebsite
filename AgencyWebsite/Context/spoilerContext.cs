using AgencyWebsite.Entities;
using Microsoft.EntityFrameworkCore;


namespace AgencyWebsite.Context
{
    public class spoilerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-GCC8HOTA\\SQLEXPRESS;initial Catalog=SpoilerDb;integrated Security=true;TrustServerCertificate=True;");
        }

        public  DbSet<About> Abouts { get; set; }
        public  DbSet<Contact> Contacts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TwoPhoto> TwoPhotos { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}
