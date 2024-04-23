using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Constants
{
    public static class DataConstants
    {
        // Team
        public const int TeamNameMaxLenght = 30;
        public const int TeamNameMinLenght = 4;

        public const int TeamCountryMaxLenght = 30;
        public const int TeamCountryMinLenght = 4;

		// Manager
		public const int ManagerNameMaxLenght = 30;
		public const int ManagerNameMinLenght = 4;

		public const int ManagerAgeMax = 100;
		public const int ManagerAgeMin = 18;

		public const int ManagerNationalityMaxLenght = 40;
		public const int ManagerNationalityMinLenght = 3;

		// Stadium
		public const int StadiumNameMaxLenght = 30;
		public const int StadiumNameMinLenght = 3;

        // Transfer Market Player
        public const double PlayerPriceMax = 750;
        public const int PlayerPriceMin = 1;


        // Messages
        public const string RequierMessage = "Field {0} is requiered";
		public const string FieldMinAndMaxRequired = "Field {0} must be between {2} and {1} charecters long";
		public const string FieldMinAndMaxAgeRequired = "Field {0} must be between {1} and {2} years old";
        public const string FieldMinAndMaxPriceRequired = "Field {0} must be between {1} and {2} coins";
    }
}
