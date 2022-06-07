namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class TournamentsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Tournaments.Any())
            {
                return;
            }

            var tournaments = new Tournament[]
            {
                // 1
                new Tournament
                {
                    TournamentName = "Australian Open",
                    Location = "Australia",
                    StartDate = new DateTime(2022, 01, 17),
                    EndDate = new DateTime(2022, 01, 30),
                    SurfaceId = 1,
                },

                // 2
                new Tournament
                {
                    TournamentName = "Roland Garos",
                    Location = "France",
                    StartDate = new DateTime(2022, 05, 23),
                    EndDate = new DateTime(2022, 06, 05),
                    SurfaceId = 2,
                },

                // 3
                new Tournament
                {
                    TournamentName = "Australian Open",
                    Location = "Australia",
                    StartDate = new DateTime(2021, 02, 08),
                    EndDate = new DateTime(2021, 02, 21),
                    SurfaceId = 1,
                },

                // 4
                new Tournament
                {
                    TournamentName = "Roland Garos",
                    Location = "France",
                    StartDate = new DateTime(2021, 05, 31),
                    EndDate = new DateTime(2021, 06, 13),
                    SurfaceId = 2,
                },

                // 5
                new Tournament
                {
                    TournamentName = "Wimbledon",
                    Location = "Great Britain",
                    StartDate = new DateTime(2021, 06, 28),
                    EndDate = new DateTime(2021, 07, 11),
                    SurfaceId = 3,
                },

                // 6
                new Tournament
                {
                    TournamentName = "US Open",
                    Location = "USA",
                    StartDate = new DateTime(2021, 08, 30),
                    EndDate = new DateTime(2021, 09, 12),
                    SurfaceId = 1,
                },
            };

            foreach (var tournament in tournaments)
            {
                await dbContext.Tournaments.AddAsync(tournament);
                await dbContext.SaveChangesAsync();
            };
        }
    }
}
