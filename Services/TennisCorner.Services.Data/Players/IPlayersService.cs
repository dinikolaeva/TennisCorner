namespace TennisCorner.Services.Data.Players
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPlayersService
    {
        Task<IEnumerable<T>> GetAllPlayersByGenderAsync<T>(string player);
    }
}
