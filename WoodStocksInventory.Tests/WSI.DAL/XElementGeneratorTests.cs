using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Wood_Stocks_Inventory.WSI.DAL;
using System.Data;
using System.Xml.Linq;
using System.Xml.XPath;
using Wood_Stocks_Inventory.WSI.BL;

namespace Wood_Stocks_InventoryTests.WSI.DAL
{
    public class XElementGeneratorTests
    {
        [Fact]
        public void CreateXElementFromDataTable_ValidInput_ConvertsAllValuesToStrings()
        {
            // Arrange

            // Create a DataTable and new empty XML document.
            var testXmlDoc = new XMLDocument("test.xml", "test.css");
            var testXElementGenerator = new XElementGenerator();
            var testDataTable = new DataTable("Test Data");
            testDataTable.Columns.Add("ItemCode", Type.GetType("System.String"));
            testDataTable.Columns.Add("ItemDescription", Type.GetType("System.String"));
            testDataTable.Columns.Add("CurrentCount", Type.GetType("System.Int32"));
            testDataTable.Columns.Add("OnOrder", Type.GetType("System.Boolean"));

            // Populate a row with different data types
            var testRow = testDataTable.NewRow();
            testRow[0] = "Test1";
            testRow[1] = "Test2";
            testRow[2] = 1;
            testRow[3] = true;
            testDataTable.Rows.Add(testRow);

            // Act
            
            // Pass test DataTable into CreateXElementFromDataTable method
            var elementList = testXElementGenerator.CreateXElementFromDataTable(testDataTable);
            // Add elementList to testXmlDoc
            testXmlDoc.Add(elementList);

            // Using XPath, create references to the elements that should contain valid strings.
            var itemCodeElement = testXmlDoc.XmlDoc.XPathSelectElement("//ItemCode").Value;
            var itemDescriptionElement = testXmlDoc.XmlDoc.XPathSelectElement("//ItemDescription").Value;
            var currentCountElement = testXmlDoc.XmlDoc.XPathSelectElement("//CurrentCount").Value;
            var onOrderElement = testXmlDoc.XmlDoc.XPathSelectElement("//OnOrder").Value;

            // Assert
            Assert.Equal("Test1", itemCodeElement);
            Assert.Equal("Test2", itemDescriptionElement);
            Assert.Equal("1", currentCountElement);
            Assert.Equal("True", onOrderElement);

        }
    }
}
