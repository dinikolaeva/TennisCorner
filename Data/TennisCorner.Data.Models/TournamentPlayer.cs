namespace TennisCorner.Data.Models
{
    using TennisCorner.Data.Common.Models;

    public class TournamentPlayer : BaseDeletableModel<int>
    {
        public int TournamentId { get; set; }

        public Tournament Tournament { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}
