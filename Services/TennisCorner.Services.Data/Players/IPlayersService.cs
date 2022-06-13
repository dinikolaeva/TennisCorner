namespace TennisCorner.Services.Data.Players
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IPlayersService
    {
        Task<IEnumerable<T>> GetAllMalePlayersByGenderAsync<T>();

        Task<IEnumerable<T>> GetAllFemalePlayersByGenderAsync<T>();

        Task<T> GetPlayerByIdAsync<T>(int id);
    }
}
