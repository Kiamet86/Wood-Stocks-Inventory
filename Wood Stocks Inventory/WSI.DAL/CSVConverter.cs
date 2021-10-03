using System.Collections.Generic;
using System.Data;
using System.IO;
using Wood_Stocks_Inventory.WSI.DAL;
using WSI.Common;

namespace Wood_Stocks_Inventory
{
    /// <summary>
	/// Reads/writes CSV files and converts them into useable runtime data types.
	/// </summary>6.
	/// 
	class CSVConverter : FileImport
    {
		
		/// <value>IList of StockItem objects.</value>
		public IList<StockItem> StockItemIList { get; private set; }
        /// <summary>
		/// <value>String containing filepath to CSV file.</value>
		/// </summary>
		public string CsvFilepath { get; set; }

        /// <summary>
        /// Constructs a new CSVConverter object.
        /// </summary>
        /// <param name="importedCsvFilepath">String containing filepath of CSV file.</param>
        public CSVConverter(string importedCsvFilepath)
        {
			CsvFilepath = importedCsvFilepath;
			StockItemIList = new List<StockItem>();
			IsValid = ValidateFile(importedCsvFilepath);
        }

		public CSVConverter()
        {

        }

		/// <summary>
		/// Populates an IList of StockItem objects, from a CSV specified by <paramref name="csvFilepath"/>
		/// </summary>
		/// <remarks>1. The method counts how many non-null lines are in the CSV, <br/> skipping the header line.
		/// This tells the method what size the IList will be. <para/>
		/// 2. The method populates an array of StockItem using a for loop <br/>
		/// and the AddStockItem method.
		/// </remarks>
		/// <param name="csvFilepath">String containing the CSV filepath.</param>
		public void CsvToStockItems(string csvFilepath) 
		{					            
			var totalCsvLines = 0;
			         
			using (StreamReader sr = new StreamReader(csvFilepath))
			{
				var csvLine = "";
				sr.ReadLine();

				while ((csvLine = sr.ReadLine()) != null)
					totalCsvLines++;
				
			}
			
			IList<StockItem> stockItemIList = new StockItem[totalCsvLines];
			
			using (StreamReader sr = new StreamReader(csvFilepath))
			{
				sr.ReadLine();

				for (int i = 0; i < totalCsvLines; i++)
				{
					var csvLine = sr.ReadLine();
					stockItemIList[i] = AddStockItem(csvLine);
				}
			}

			this.StockItemIList = stockItemIList;
		}

		/// <summary>
		/// Creates a StockItem object from a string provided by <paramref name="csvLine"/>.
		/// </summary>
		/// <remarks>1. The method creates an array of string from <paramref name="csvLine"/> using the <br/>
		/// SplitByComma() extension method.<para/>
		/// 2. Each string in the array is assigned to a variable that <br/>
		/// corresponds with each column of the csv file. These variables<br/>
		/// are used to return a new StockItem.</remarks>
		/// <param name="csvLine">String containing comma-delimited information</param>
		/// <returns>StockItem</returns>
		private StockItem AddStockItem(string csvLine)
		{
			var columns = csvLine.SplitByComma();
			var itemCode = columns[0];
			var itemDescription = columns[1];
			var currentCount = int.Parse(columns[2]);
			var onOrder = false;
			if (columns[3] == "Yes") onOrder = true;
						
			return new StockItem(itemCode, itemDescription, currentCount, onOrder);
		}

		/// <summary>
		/// Converts the active <paramref name="stockDataTable"/> into a CSV, to a 
		/// filepath defined by <paramref name="csvFilepath"/>.
		/// </summary>
		/// <remarks>StreamWriter writes the header line, then iterates
		/// through every DataRow in the DataTable, <br/> writing the value of 
		/// each column separated by commas, to a new CSV file.</remarks>
		/// <param name="csvFilepath">New filepath to write to.</param>
		/// <param name="stockDataTable">Values as displayed by DataGridView control.</param>
		public static void ExportCSV(string csvFilepath, DataTable stockDataTable)
        {
			using (StreamWriter sw = new StreamWriter(csvFilepath))
			{
				sw.WriteLine("Item Code,Item Description,Current Count,On Order");

				foreach (DataRow row in stockDataTable.Rows) 
				{
					var itemCode = row.Field<string>(0);
					var itemDescription = row.Field<string>(1);
					var currentCount = row.Field<int>(2);
					var onOrder = row.Field<bool>(3);

					sw.Write($"{itemCode},{itemDescription},{currentCount},");
					if (onOrder == true) sw.WriteLine("Yes");

					else sw.WriteLine("No");
					
				}
			}
		}

		/// <summary>
		/// Checks that the filepath given points to a .csv file.
		/// </summary>
		/// <param name="csvFilepath">Path to the CSV file.</param>
		/// <returns>Boolean</returns>
        protected override bool ValidateFile(string csvFilepath)
        {
			if (csvFilepath.EndsWith(".csv") == true) return true;
			else return false;
		}
    }
}
