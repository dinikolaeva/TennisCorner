namespace TennisCorner.Services.Data.Tournaments
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using TennisCorner.Data.Common.Repositories;
    using TennisCorner.Data.Models;
    using TennisCorner.Services.Mapping;

    public class TournamentService : ITournamentService
    {
        private readonly IDeletableEntityRepository<Tournament> tournamentRepository;

        public TournamentService(IDeletableEntityRepository<Tournament> tournamentRepository)
        {
            this.tournamentRepository = tournamentRepository;
        }

        public async Task<IEnumerable<T>> GetAllTournamentsAsync<T>()
        {
            var tournaments = await this.tournamentRepository.All()
                                                             .OrderBy(t => t.StartDate.Year)
                                                             .To<T>()
                                                             .ToListAsync();

            return tournaments;
        }
    }
}
