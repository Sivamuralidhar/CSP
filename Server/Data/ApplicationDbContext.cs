namespace CSP.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<GeekProfileInfo> CSPGeekProfiles { get; set; }
        public DbSet<CSPProfileInfo> CSPProfiles { get; set; }

    }
}
