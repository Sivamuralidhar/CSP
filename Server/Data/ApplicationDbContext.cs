namespace CSP.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<GeekProfileInfo> GeekProfiles { get; set; }
        public DbSet<CSPProfileInfo> CSPProfiles { get; set; }

    }
}
