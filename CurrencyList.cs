namespace Currency
{
    /// <summary>
    /// Creates a class called CurrencyList to hold a list of CurrencyItem objects
    /// </summary>
    public class CurrencyList
    {
        /// <summary>
        /// Makes an internal private backing field for use.
        /// </summary>
        private List<CurrencyItem> items = new();

        /// <summary>
        /// Makes a public backing field for use that references the private field.
        /// </summary>
        public List<CurrencyItem> Items => this.items;

        /// <summary>
        /// Loops over the provided file and fills the CurrencyList with new objects.
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static CurrencyList NewInstance(string file)
        {
            var list = new CurrencyList();
            using (var reader  = new StreamReader(file))
            {
                var line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    list.Items.Add(CurrencyItem.NewInstance(line));
                }
            }
            return list;
        }
    }
}
