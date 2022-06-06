namespace TennisCorner.Common
{
    public static class GlobalConstants
    {
        public const string SystemName = "TennisCorner";

        public const string AdministratorRoleName = "Administrator";

        // from another app, not good name for cloud with many apps :)
        public const string CloudName = "be-gorgeous";

        public static class StringLengthValidations
        {
            public const int SurfaceTypeStringLenght = 50;
            public const int CategoryNameStringLenght = 30;
            public const int TournamentNameStringLenght = 100;
            public const int LocationStringLenght = 50;
            public const int CountryAbbreviationStringLenght = 3;
            public const int CountryNameStringLenght = 50;
            public const int PlayerFirstNameStringLenght = 30;
            public const int PlayerLastNameStringLenght = 50;
            public const int PlayerGenderStringLenght = 1;
            public const int PlayerCoachStringLenght = 100;
            public const int IsOpponentRetiredStringLenght = 1;
        }

        public static class Images
        {
            public const string Loading = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654511540/images/TennisCorner/loading_img_bpnliu.gif";

            public const string Logo = "https://res.cloudinary.com/be-gorgeous/image/upload/v1654511536/images/TennisCorner/logo_olch1f.png";
        }
    }
}
