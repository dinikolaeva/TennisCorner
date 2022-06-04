namespace TennisCorner.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TennisCorner.Common;
    using TennisCorner.Data.Common.Models;

    public class Surface : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(GlobalConstants.StringLengthValidations.SurfaceTypeStringLenght)]
        public string SurfaceType { get; set; }
    }
}
