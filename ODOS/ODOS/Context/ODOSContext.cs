using Microsoft.EntityFrameworkCore;

namespace ODOS.Context
{
    public class ODOSContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public ODOSContext(DbContextOptions options) : base(options)
        {
            // TODO: This seems a bit too long. Why has this been set this high?
            //Database.SetCommandTimeout(180);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }
}
