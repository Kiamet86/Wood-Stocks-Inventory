using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Stocks_Inventory
{
    /// <summary>
    /// Business Logic Layer class that converts CSV data into DataSet and DataTable.
    /// </summary>
    public class StockDataSet
    {
        /// <summary>
        /// DataSet for stock information.
        /// </summary>
        public DataSet stockDataSet { get; private set; }

        /// <summary>
        /// DataTable for stock information.
        /// </summary>
        public DataTable stockDataTable { get; private set; }
        
        /// <summary>
        /// Constructor for StockDataSet. Creates a new DataSet and DataTable, adding the DataTable to the DataSet.
        /// </summary>
        /// <remarks>1. Columns are created to match the stocklist CSV.<br/>
        /// 2. A new DataRow is created for each StockItem in <paramref name="stockItems"/>, each column in populated by a StockItem property.</remarks>
        /// <param name="stockItems">IList of StockItem</param>
        public StockDataSet(IList<StockItem> stockItems)
        {
            var newStockData = new DataSet("StockData");
            var newStockTable = newStockData.Tables.Add("Stock");

            var itemCodeColumn = new DataColumn();
            itemCodeColumn.ColumnName = "Item Code";
            itemCodeColumn.DataType = Type.GetType("System.String");
            itemCodeColumn.ReadOnly = true;
            newStockTable.Columns.Add(itemCodeColumn);

            var itemDescriptionColumn = new DataColumn();
            itemDescriptionColumn.ColumnName = "Item Description";
            itemDescriptionColumn.DataType = Type.GetType("System.String");
            itemDescriptionColumn.ReadOnly = true;
            newStockTable.Columns.Add(itemDescriptionColumn);

            var currentCountColumn = new DataColumn();
            currentCountColumn.ColumnName = "Current Count";
            currentCountColumn.DataType = Type.GetType("System.Int32");
            currentCountColumn.ReadOnly = false;
            newStockTable.Columns.Add(currentCountColumn);

            var onOrderColumn = new DataColumn();
            onOrderColumn.ColumnName = "On Order";
            onOrderColumn.DataType = Type.GetType("System.Boolean");
            onOrderColumn.ReadOnly = true;
            newStockTable.Columns.Add(onOrderColumn);

            foreach(var stockItem in stockItems)
            {
                var newRow = newStockTable.NewRow();
                newRow[itemCodeColumn] = stockItem.ItemCode;
                newRow[itemDescriptionColumn] = stockItem.ItemDescription;
                newRow[currentCountColumn] = stockItem.CurrentCount;
                newRow[onOrderColumn] = stockItem.OnOrder;
                newStockTable.Rows.Add(newRow);
            }

            this.stockDataSet = newStockData;
            this.stockDataTable = newStockTable;
        }
    }
}
