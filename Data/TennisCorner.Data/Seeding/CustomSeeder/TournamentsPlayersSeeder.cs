namespace TennisCorner.Data.Seeding.CustomSeeder
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using TennisCorner.Data.Models;

    public class TournamentsPlayersSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.TournamentsPlayers.Any())
            {
                return;
            }

            var tournamentsId = dbContext.Tournaments.Select(t => t.Id).ToList();

            foreach (var tournamentId in tournamentsId)
            {
                var players = dbContext.Players.ToList();

                foreach (var player in players)
                {
                    var tournamentPlayer = new TournamentPlayer
                    {
                        PlayerId = player.Id,
                        TournamentId = tournamentId,
                    };

                    await dbContext.TournamentsPlayers.AddAsync(tournamentPlayer);
                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
