namespace Currency
{
    /// <summary>
    /// This is the main form the application uses to run.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// This is the class for the main form that instantiates it
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Here we instantiate the CurrencyList for later use, creating a currencylist object.
        /// </summary>
        public CurrencyList CurrencyList { get; set; } = new CurrencyList();

        /// <summary>
        /// This code activates when the form loads and get the currency data
        /// </summary>
        /// <param name="sender"> The event that triggers this is on start up </param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Creating a OpenFileDialog object named dialog
            using (var dialog = new OpenFileDialog())
            {
                // Setting initial dialog default settings
                dialog.InitialDirectory = @"c:\";
                dialog.Filter = "csv files (*.csv)|*.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Creating a new instance of CurrencyList and adding new items to it.
                    this.CurrencyList = CurrencyList.NewInstance(dialog.FileName);
                    // Creating a new instance of CurrencyItem for each item in the CurrencyList
                    foreach (var item in this.CurrencyList.Items)
                    {
                        // Displaying the Country names of the objects in CurrencyList to the 
                        // checkbox.
                        this.CountriesCheckBox.Items.Add(item.ItemDescription);
                    }
                }
            }
        }

        /// <summary>
        /// Converting the user intered amount into another currency using the CurrencyItem objects
        /// conversion rate values
        /// </summary>
        /// <param name="sender"> It is a click event </param>
        /// <param name="e"></param>
        private void ConversionButton_Click(object sender, EventArgs e)
        {
            // Clearing the OutputRichTextBox
            this.OutputRichTextBox.Clear();
            // getting the index for each item checked in the checkbox and setting it to a variable
            foreach (int indexChecked in this.CountriesCheckBox.CheckedIndices)
            {
                // using the index variable to access the appropriate items int he list checkbox for 
                // use in conversion process.
                var countSelected = this.CurrencyList.Items[indexChecked];
                decimal.TryParse(this.ConversionTextBox.Text, out decimal amount);
                // Calculating the newRate of the currency.
                var newRate = countSelected.ConversionRate * amount;

                // This is a string for display purposes.
                string outPut = $"{amount:C} in USD is:{Environment.NewLine}" +
                    $"{newRate:C} {countSelected.Currency} in {countSelected.CountryName}" +
                    $"{Environment.NewLine}{Environment.NewLine}";

                // Displaying the string created to the OutPutRichTextBox
                this.OutputRichTextBox.AppendText(outPut);
            }
        }

        /// <summary>
        /// Checks and Unchecks all countries
        /// </summary>
        /// <param name="sender"> It is a click event </param>
        /// <param name="e"></param>
        private void AllCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            // Checks to see if the check box has been checked
            if (AllCheckBox.Checked)
            {
                // If it was sets i as a counter variable to 0, then says that if i is less the
                // the number of items in checkbox perform task, and then add 1 to i.
                for (int i = 0; i < this.CountriesCheckBox.Items.Count; i++)
                {
                    // Uses the current int that i is as a index value to set the appropriate item
                    // to checked.
                    this.CountriesCheckBox.SetItemChecked(i, true);
                }
            }
            else
            {
                // The same as above but in reverse this for loop unchecks all the boxes.
                for (int i = 0; i < this.CountriesCheckBox.Items.Count; i++)
                {
                    this.CountriesCheckBox.SetItemChecked(i, false);
                }
            }
        }

        /// <summary>
        /// Saves the data in the OutPutRichTextBox for the user.
        /// </summary>
        /// <param name="sender"> This is a click event </param>
        /// <param name="e"></param>
        private void SaveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = @"c:\";
                dialog.Filter = "csv files (*.csv)|*.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(dialog.FileName))
                    {
                        writer.WriteLine(this.OutputRichTextBox.Text.ToString());
                    }
                }
            }
        }
    }
}