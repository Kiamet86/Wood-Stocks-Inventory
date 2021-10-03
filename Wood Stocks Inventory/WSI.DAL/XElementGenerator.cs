using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wood_Stocks_Inventory.WSI.DAL
{
    public class XElementGenerator
    {
        private DataTable stockData;
        public DataTable StockData { get; set; }

        public XElementGenerator()
        {
        }

        /// <summary>
        /// Converts a Wood Stocks DataTable into a List of XML Elements.
        /// </summary>
        /// <param name="stockData"></param>
        /// <returns>List<XElement></returns>
        public List<XElement> CreateXElementFromDataTable(DataTable stockData)
        {
            var stockElementList = new List<XElement>();

            foreach (DataRow row in stockData.Rows)
            {
                var itemCode = row.Field<string>(0);
                var itemDescription = row.Field<string>(1);
                var currentCount = Convert.ToString(row.Field<int>(2));
                var onOrder = Convert.ToString(row.Field<bool>(3));

                var stockElement = 
                    new XElement("StockItem",
                        new XElement("ItemCode", itemCode),
                        new XElement("ItemDescription", itemDescription),
                        new XElement("CurrentCount", currentCount),
                        new XElement("OnOrder", onOrder));

                stockElementList.Add(stockElement);
            }

            return stockElementList;
        }
    }
}
