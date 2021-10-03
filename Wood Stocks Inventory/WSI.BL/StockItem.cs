using System;

namespace Wood_Stocks_Inventory
{
    /// <summary>
    /// Contains data for each stock item.
    /// </summary>
    public class StockItem
    {
        private int currentCount;
        /// <value>String containing Item Code of the StockItem.</value>
        public string ItemCode { get; }
        /// <value>String containing Item Description of the StockItem.</value>
        public string ItemDescription { get; }
        /// <value>Integer containing Current Count of the StockItem.</value>
        /// <remarks>Set method throws an exception if the input is not an integer, or less than 0, or greater than 100.</remarks>
        /// <exception cref="ArgumentOutOfRangeException">Input is not an integer, less than 0, or greater than 100.</exception>
        public int CurrentCount
        {
            get { return currentCount; }
            set
            {
                if (value.GetType() != typeof(int) || value < 0 || value >= 100)
                {
                    throw new ArgumentOutOfRangeException("Current Count", "Please check .csv file. Current Count " +
                        "column must contain numbers between 0 and 100, with no symbols or characters.");
                }
                    
                    else currentCount = value;
            }
        }

        /// <value>Boolean containing True/False status of On Order status of StockItem.</value>
        public bool OnOrder { get; }

        /// <summary>
        /// Constructor method for StockItem object.
        /// </summary>
        /// <param name="itemCode">String containing Item Code of the StockItem.</param>
        /// <param name="itemDescription">String containing Item Description of the StockItem.</param>
        /// <param name="currentCount">Integer containing Current Count of the StockItem.</param>
        /// <param name="onOrder">Boolean containing True/False status of On Order status of StockItem.</param>
        public StockItem(string itemCode, string itemDescription, int currentCount, bool onOrder)
        {
            this.ItemCode = itemCode;
            this.ItemDescription = itemDescription;
            this.CurrentCount = currentCount;
            this.OnOrder = onOrder;
        }

        /// <summary>
        /// Displays the Item Description and Current Count of the object.
        /// </summary>
        /// <remarks>This allows easier debugging and testing when working with StockItem objects.</remarks>
        /// <returns>string</returns>
        public override string ToString() =>
        $"{this.ItemDescription}: {this.CurrentCount} in stock.";
    }

    




}
