using Microsoft.EntityFrameworkCore;

namespace NextSoftAPI.Data
{
    public class NextSoftAPIDataContext : DbContext
    {
        public NextSoftAPIDataContext(DbContextOptions<NextSoftAPIDataContext> opt) : base(opt)
        { }

        public DbSet<Models.Condominio> Condominio { get; set; }
        public DbSet<Models.Familia> Familia { get; set; }
        public DbSet<Models.Morador> Morador { get; set; }
    }
}
