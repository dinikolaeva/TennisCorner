namespace TennisCorner.Services.Data.Players
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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

        public async Task<IEnumerable<T>> GetAllPlayersByGenderAsync<T>(string player)
        {
            var players = await this.playerRepository
                .All()
                .Where(p => p.Gender == player)
                .OrderBy(p => p.CurrentRank)
                .Select(p => p) // ???
                .To<T>()
                .ToListAsync();

            return players;
        }
    }
}
