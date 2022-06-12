namespace TennisCorner.Services.Data.Players
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using TennisCorner.Data.Common.Repositories;
    using TennisCorner.Data.Models;
    using TennisCorner.Services.Mapping;

    public class PlayersService : IPlayersService
    {
        private readonly IDeletableEntityRepository<Player> playerRepository;

        public PlayersService(IDeletableEntityRepository<Player> playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public async Task<IEnumerable<T>> GetAllMalePlayersByGenderAsync<T>()
        {
            var players = await this.playerRepository
                                    .All()
                                    .Where(p => p.Gender == "M")
                                    .OrderBy(p => p.CurrentRank)
                                    .To<T>()
                                    .ToListAsync();

            return players;
        }

        public async Task<T> GetPlayerByIdAsync<T>(int id)
        {
            var player = await this.playerRepository
                                   .All()
                                   .Where(s => s.Id == id)
                                   .To<T>()
                                   .FirstOrDefaultAsync();

            return player;
        }
    }
}
