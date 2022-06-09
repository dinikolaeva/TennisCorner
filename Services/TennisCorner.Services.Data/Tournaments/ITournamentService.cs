namespace TennisCorner.Services.Data.Tournaments
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using TennisCorner.Web.ViewModels.Tournaments;

    public interface ITournamentService
    {
        Task<IEnumerable<T>> GetAllTournamentsAsync<T>();
    }
}
