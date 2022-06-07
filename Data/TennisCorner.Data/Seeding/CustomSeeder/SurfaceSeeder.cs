namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class SurfaceSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Surfaces.Any())
            {
                return;
            }

            var surfaces = new Surface[]
            {
                new Surface { SurfaceType = "Hard" },
                new Surface { SurfaceType = "Clay" },
                new Surface { SurfaceType = "Grass" },
            };

            foreach (var surface in surfaces)
            {
                await dbContext.Surfaces.AddAsync(surface);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
