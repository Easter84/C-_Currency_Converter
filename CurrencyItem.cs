namespace Currency
{
    /// <summary>
    /// Creates a class called CurrencyItem
    /// </summary>
    public class CurrencyItem
    {
        /// <summary>
        /// Creates an attribute to hold the Name of the Country
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Creates an attribute to hold the name of the Currency
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Creates an attribute to hold the description of the currency
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Creates an attribute to hold the conversion rate of the currency
        /// </summary>
        public decimal ConversionRate { get; set; }

        /// <summary>
        /// Creates a new instance of a CurrencyItem using input from line and parsing it into the 
        /// appropriate pieces.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static CurrencyItem NewInstance(string line)
        {
            var tokens = line.Split(',');
            var countryName = tokens[1];
            var currency = tokens[2];
            var description = tokens[3];
            decimal.TryParse(tokens[4], out var conversionRate);

            var currencyItem = new CurrencyItem
            {
                CountryName = countryName,
                Currency = currency,
                Description = description,
                ConversionRate = conversionRate
            };
            return currencyItem;
        }

        /// <summary>
        /// Is used to display when called the Country name of the object.
        /// </summary>
        public string ItemDescription => $"{this.CountryName}";

    }
}
