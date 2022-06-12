namespace TennisCorner.Services.Data.Tournaments
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using TennisCorner.Data.Common.Repositories;
    using TennisCorner.Data.Models;
    using TennisCorner.Services.Mapping;

    public class TournamentsService : ITournamentsService
    {
        private readonly IDeletableEntityRepository<Tournament> tournamentRepository;

        public TournamentsService(IDeletableEntityRepository<Tournament> tournamentRepository)
        {
            this.tournamentRepository = tournamentRepository;
        }

        public async Task<IEnumerable<T>> GetAllTournamentsByYearAsync<T>(int year)
        {
            var tournaments = await this.tournamentRepository.All()
                                                             .Where(t => t.StartDate.Year == year)
                                                             .OrderBy(t => t.StartDate)
                                                             .To<T>()
                                                             .ToListAsync();

            return tournaments;
        }

        public async Task<T> GetTournamentByIdAsync<T>(int id)
        {
            var tournament = await this.tournamentRepository.All()
                                                            .Where(s => s.Id == id)
                                                            .To<T>()
                                                            .FirstOrDefaultAsync();

            return tournament;
        }
    }
}
