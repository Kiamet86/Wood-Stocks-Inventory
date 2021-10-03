using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Stocks_Inventory
{
    class StockItem
    {
        private int currentCount;
        
        public string ItemCode { get; }
        public string ItemDescription { get; }
        public int CurrentCount
        {
            get { return currentCount; }
            set
            {
                if (value.GetType() == typeof(int) && value >= 0)
                    currentCount = value;
                else
                {
                    InventoryControl.InputError();
                }
            }
        }
        
        public bool OnOrder { get; }

        public StockItem(string itemCode, string itemDescription, int currentCount, bool onOrder)
            // Constructor method that initialises all properties of the StockItem object.
        {
            this.ItemCode = itemCode;
            this.ItemDescription = itemDescription;
            this.CurrentCount = currentCount;
            this.OnOrder = onOrder;
        }
    }

    




}
