namespace TennisCorner.Data.Models
{
    public class TournamentPlayer : BaseDelitableModel<int>
    {
        public int TournamentId { get; set; }

        public Tournament Tournament { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}
