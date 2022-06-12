namespace TennisCorner.Services.Data.Tournaments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using TennisCorner.Web.ViewModels.Tournaments;

    public interface ITournamentsService
    {
        Task<IEnumerable<T>> GetAllTournamentsByYearAsync<T>(int year);

        Task<T> GetTournamentByIdAsync<T>(int id);
    }
}
