namespace TennisCorner.Services.Data.Tournaments
{
    using System.Threading.Tasks;

    public interface ITournamentService
    {
        Task<T> GetTournamentByIdAsync<T>(int id);
    }
}
