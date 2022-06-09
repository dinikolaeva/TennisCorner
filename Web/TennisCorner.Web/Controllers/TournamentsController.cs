namespace TennisCorner.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    using TennisCorner.Services.Data.Tournaments;

    public class TournamentsController : BaseController
    {
        private readonly ITournamentService tournamentService;

        public TournamentsController(ITournamentService tournamentService)
        {
            this.tournamentService = tournamentService;
        }

        public async Task<IActionResult> Details(int id)
        {
            // TODO implement the tournament from HomePage
        }
    }
}
