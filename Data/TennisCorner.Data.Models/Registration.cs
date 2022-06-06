namespace TennisCorner.Data.Models
{
    using System;

    using TennisCorner.Data.Common.Models;

    public class Registration : BaseDeletableModel<int>
    {
        public int PlayerId { get; set; }

        public Player Player { get; set; }

        public DateTime? RegistrationDate { get; set; }
    }
}
