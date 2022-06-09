namespace TennisCorner.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TennisCorner.Common;
    using TennisCorner.Data.Common.Models;

    public class PlayingCategory : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.CategoryNameStringLenght)]
        public string CategoryName { get; set; }
    }
}
