﻿namespace TennisCorner.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TennisCorner.Common;
    using TennisCorner.Data.Common.Models;

    public class Player : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.PlayerFirstNameStringLenght)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.PlayerLastNameStringLenght)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.PlayerGenderStringLenght)]
        public string Gender { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CareerWin { get; set; }

        public int CareerLoss { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.PlayerCoachStringLenght)]
        public string Coach { get; set; }

        public int CurrentRank { get; set; }

        public double TotalPrizeMoney { get; set; }

        public ICollection<RegistrationPlayer> RegistrationsPlayers { get; set; } = new HashSet<RegistrationPlayer>();
    }
}
