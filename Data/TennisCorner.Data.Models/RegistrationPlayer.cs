namespace TennisCorner.Data.Models
{
    using TennisCorner.Data.Common.Models;

    public class RegistrationPlayer : BaseDeletableModel<int>
    {
        public int RegistrationId { get; set; }

        public Registration Registration { get; set; }

        public int PlayerId { get; set; }

        public Player Player { get; set; }
    }
}
