namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class SurfacesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Surfaces.Any())
            {
                return;
            }

            var surfaces = new Surface[]
            {
                // 1
                new Surface { SurfaceType = "Hard" },

                // 2
                new Surface { SurfaceType = "Clay" },

                // 3
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
