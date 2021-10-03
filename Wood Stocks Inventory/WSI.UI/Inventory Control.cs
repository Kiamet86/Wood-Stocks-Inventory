using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Wood_Stocks_Inventory.WSI.BL;
using Wood_Stocks_Inventory.WSI.DAL;

namespace Wood_Stocks_Inventory
{
    public partial class InventoryControl : Form
    {
        /// <summary>
        /// Initialiser for main form InventoryControl
        /// </summary>
        public InventoryControl()
        {
            InitializeComponent();     
            xmlStyleComboBox.DataSource = cssStyles;
        }
        /// <summary>
        /// Field that references the currently active DataTable being used by stockItemDataGridView control.
        /// </summary>
        /// <remarks>Used by ExportCSV() when exporting to .csv file.</remarks>
        private DataTable activeDataTable;

        /// <summary>
        /// Field that holds the Value of the CurrentCell.
        /// </summary>
        /// <remarks>Used to reverse changes when incorrect input is performed.</remarks>
        private int activeCellToEdit;

        private string exportFiletype = "CSV";

        private string cssFilePath = Environment.CurrentDirectory + "\\nostyle.css";

        private List<String> cssStyles = new List<string> { "No Style", "Stocktake", "Dark Mode" };

        /// <summary>
        /// Opens a custom Close Dialog form to confirm user exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryControl_Closing(object sender, FormClosingEventArgs e)
        {
            var dialog = new CloseDialog();

            if (dialog.ShowDialog() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Loads main form and sets caption text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryControl_Load(object sender, EventArgs e)
        {
            this.Text = "Wood Stocks Inventory Control";
        }
        
        /// <summary>
        /// Opens Quick Start Guide PDF.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuickStartPictureBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Quick Start Guide.pdf");
        }

        /// <summary>
        /// Allows user to choose what .csv file to import, and displays it in a datagridview.
        /// </summary>
        /// <remarks>1. User selects a filepath from an OpenFileDialog. A new CSVConverter <br/>
        /// object is instantiated and validated by the constructor.<para/>
        /// 2. If the filepath is valid, it is passed into the PopulateStockItemIList() method.<br/>
        /// The returned IList is passed into a new instance of a StockDataSet.<para/>
        /// 3. The StockDataSet generates a StockDataTable, which is displayed <br/>
        /// through a datagridview control. Column sorting behaviours are set, and <br/>
        /// controls that allow Exporting of the CSV are now enabled.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentOutOfRangeException">Raised if the imported CSV has invalid Current Count values.</exception>
        private void ImportButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\StockFile";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Import CSV";
                openFileDialog.DefaultExt = "csv";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var csvFilePath = openFileDialog.FileName;
                    var importedCSVData = new CSVConverter(csvFilePath);
                    
                    if (importedCSVData.IsValid == true)
                    {
                        try
                        {
                            importedCSVData.CsvToStockItems(csvFilePath);
                        }

                        catch (ArgumentOutOfRangeException error)
                        {
                            MessageBox.Show(error.Message);
                        }

                    }
                    else MessageBox.Show("The file is an invalid format. Please use a CSV file.", "Invalid File Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    var stockDataSet = new StockDataSet(importedCSVData.StockItemIList);
                                       
                    stockItemDataGridView.DataSource = stockDataSet.stockDataTable;
                    activeDataTable = stockDataSet.stockDataTable;
                   
                    ExportButton.Enabled = true;
                    exportToolStripMenuItem.Enabled = true;
                    exportToolStripButton.Enabled = true;
                    exportFileTypeGroupBox.Enabled = true;
                    csvRadioButton.Checked = true;
                }
            }  
        }

        /// <summary>
        /// Displays an error message if a string is entered into an integer-only column.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockItemDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            {
                MessageBox.Show("Non-numbers are invalid. Please input a number between 0-100, whole numbers only.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                stockItemDataGridView.CancelEdit();
            }
        }

        /// <summary>
        /// Allows user to export datagridview data to a CSV, or XML.
        /// </summary>
        /// <remarks>Opens a SaveFileDialog, with a default filename that contains today's date.<br/>
        /// If a CSV file is chosen, it is sent to the static class method CSVConverter.ExportCSV(), <br/>
        /// along with the DataTable that datagridview has been using as a datasource.<br/><br/>
        /// If an XML file is chosen, the method calls on the XElementGenerator and <br/>
        /// XDocument classes to generate the XML file.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportButton_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            var editDate = currentDate.ToString("dd'-'MM'-'yyyy");

            if (exportFiletype == "CSV")
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Export CSV";
                    saveFileDialog.InitialDirectory = "c:\\Stockfile";
                    saveFileDialog.DefaultExt = "csv";
                    saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                    saveFileDialog.FileName = $"stocklist edited {editDate}";
                    saveFileDialog.CheckPathExists = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var csvFilePath = saveFileDialog.FileName;
                        CSVConverter.ExportCSV(csvFilePath, activeDataTable);
                    }
                }
            }

            else
            { 

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Export XML";
                    saveFileDialog.InitialDirectory = "c:\\Stockfile";
                    saveFileDialog.DefaultExt = "xml";
                    saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                    saveFileDialog.FileName = $"stocklist edited {editDate}";
                    saveFileDialog.CheckPathExists = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var xElementGenerator = new XElementGenerator();
                        var elementList = xElementGenerator.CreateXElementFromDataTable(activeDataTable);
                        var xmlFilePath = saveFileDialog.FileName;
                        var xmlDoc = new XMLDocument(saveFileDialog.FileName, cssFilePath, 
                            elementList, editDate);
                        xmlDoc.Add(elementList);
                        xmlDoc.SaveToDisk(xmlFilePath);
                        System.Diagnostics.Process.Start("IExplore", xmlFilePath);
                    }
                }
            }


        }

        /// <summary>
        /// Starts the FormClosing event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens the SkillageIT website in a new browser window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skillageitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.skillageit.com.au/");
            skillageitLinkLabel.LinkVisited = true;
        }

        /// <summary>
        /// Opens the SkillageIT website in a new explorer window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SkillageITPictureBox_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://www.skillageit.com.au/");
            skillageitLinkLabel.LinkVisited = true;
        }

        /// <summary>
        /// Opens the User Manual PDF.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userManualToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wood Stocks Inventory User Manual.pdf");
        }

        /// <summary>
        /// Sets the field activeCellToEdit to the value of the most recent Current Count cell opened for editing.
        /// </summary>
        /// <remarks>activeCellToEdit can then be used to reverse incorrect cell input to the value it had before editing.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockItemDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (stockItemDataGridView.CurrentCell.ColumnIndex == 2)
            {
                var cellToEdit = Convert.ToInt32(stockItemDataGridView.CurrentCell.Value);
                activeCellToEdit = cellToEdit;
            }
        }

        /// <summary>
        /// Validates the input of a Current Count cell after it has been edited.
        /// </summary>
        /// <remarks>The edited cell's value is checked to see if it is in the acceptable range. <br/>
        /// If not, the changes are reverted using field activeCellToEdit and an error message is displayed.</remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (stockItemDataGridView.CurrentCell.ColumnIndex == 2)
            {
                var changedCellValue = Convert.ToInt32(stockItemDataGridView.CurrentCell.Value);
                if (changedCellValue < 0 || changedCellValue > 100)
                {
                    MessageBox.Show($"{stockItemDataGridView.CurrentCell.Value} is invalid. Please input a value between 0 and 100, whole numbers only.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    stockItemDataGridView.CurrentCell.Value = activeCellToEdit;
                }
            }
        }

        /// <summary>
        /// Once data is imported, makes every column programmatically sortable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockItemDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in stockItemDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        /// <summary>
        /// When a column header is clicked, the datagridview is sorted using that column in ascending order. <br/>
        /// If the column was already clicked, and the sorting order is not already "Descending", it sorts it in descending order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockItemDataGridView_ColumnHeaderMouseClick(object sender, 
            DataGridViewCellMouseEventArgs e)
        {
            var clickedColumn = stockItemDataGridView.Columns[e.ColumnIndex];
            var alreadySortedColumn = stockItemDataGridView.SortedColumn;
            var gridSortDirection = Convert.ToString(stockItemDataGridView.SortOrder);
            ListSortDirection newSortDirection;
            
            if ((clickedColumn == alreadySortedColumn) && (gridSortDirection != "Descending"))  
                newSortDirection = ListSortDirection.Descending;
            
            else newSortDirection = ListSortDirection.Ascending;
            
            stockItemDataGridView.Sort(clickedColumn, newSortDirection);
        }

        /// <summary>
        /// Checks if the CSV Radio Button is selected, and sets the <br/>
        /// program's Export type to CSV. Also disables the XML Style combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void csvRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (csvRadioButton.Checked == true) exportFiletype = "CSV";
            ExportButton.Text = "Export CSV";
            xmlStyleComboBox.Enabled = false;
        }

        /// <summary>
        /// Checks if the XML Radio Button is selected, and sets the <br/>
        /// program's Export type to XML. Also enables the XML Style combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xmlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (xmlRadioButton.Checked == true) exportFiletype = "XML";
            ExportButton.Text = "Export XML";
            xmlStyleComboBox.Enabled = true;
        }

        /// <summary>
        /// Sets the value of the CSS File Path, depending on what option is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xmlStyleComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (xmlStyleComboBox.SelectedIndex)
            {
                case 0:
                    cssFilePath = Environment.CurrentDirectory + "\\nostyle.css";
                    break;
                case 1:
                    cssFilePath = Environment.CurrentDirectory + "\\defaultstyle.css";
                    break;
                case 2:
                    cssFilePath = Environment.CurrentDirectory + "\\darkstyle.css";
                    break;

            }
        }
    }
}
