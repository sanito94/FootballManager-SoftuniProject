namespace FootballManager_SoftuniProject.Extensions
{
    public static class RandomGenerator
    {
        private static readonly string[] firstNames = { "John", "Paul", "Ringo", "George" };

        private static readonly string[] lastNames = { "Lennon", "McCartney", "Starr", "Harrison" };

        private static readonly string[] countries = { "Bulgaria", "England", "Germany", "Italy" };

        private static readonly int[] ages = { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        private static readonly string[] positions = { "GK", "CB", "LB", "RB", "CDM", "CM", "RM", "LM", "CAM", "ST", "RF" };

        private static readonly decimal[] prices = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750 };


        private static string GenerateName()
        {
            var random = new Random();
            string firstName = firstNames[random.Next(0, firstNames.Length)];
            string lastName = firstNames[random.Next(0, firstNames.Length)];

            return $"{firstName} {lastName}";
        }

        private static string GenerateCountry()
        {
            var random = new Random();
            string country = countries[random.Next(0, countries.Length)];

            return $"{country}";
        }

        private static int GenerateAge()
        {
            var random = new Random();
            int age = ages[random.Next(0, ages.Length)];

            return age;
        }

        private static string GeneratePosition()
        {
            var random = new Random();
            string position = positions[random.Next(0, positions.Length)];

            return $"{position}";
        }

        private static decimal GeneratePrice()
        {
            var random = new Random();
            decimal price = prices[random.Next(0, prices.Length)];

            return price;
        }
    }
}
