namespace TennisCorner.Data.Models
{
    using TennisCorner.Data.Common.Models;

    public class TournamentPlayingCategory : BaseDeletableModel<int>
    {
        public int TournamentId { get; set; }

        public Tournament Tournament { get; set; }

        public int PlayingCategoryId { get; set; }

        public PlayingCategory PlayingCategory { get; set; }
    }
}
