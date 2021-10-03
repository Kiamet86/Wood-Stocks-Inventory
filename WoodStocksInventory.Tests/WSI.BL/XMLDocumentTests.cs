using Xunit;
using Wood_Stocks_Inventory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Wood_Stocks_Inventory.WSI.BL;

namespace Wood_Stocks_Inventory.Tests
{
    public class XMLDocumentTests
    {
        [Fact]
        public void XMLDocument_ValidData_ConstructorSuccessful()
        {
            // Arrange
            var testFilePath = "C:\\Stockfile\\TestFilePath.xml";
            var testStylingPath = "C:\\Stockfile\\TestStylingSheet.css";

            // Act
            var testObject = new XMLDocument(testFilePath, testStylingPath);

            // Assert
            Assert.Equal(testFilePath, testObject.XmlFilePath);
            Assert.Equal(testStylingPath, testObject.CssStylesheetPath);
        }

        // TODO - test constructor with no styling.

        [Fact]
        public void XMLDocument_InvalidFilePathString_ThrowsException()
        {
            // Arrange
            var validStylingPath = "C:\\Stockfile\\TestStylingSheet.css";
            var validFilePath = "C:\\Stockfile\\TestFilePath.xml";
            
            var invalidFilePath = "C:\\Stockfile\\TestFilePath.xlm";

            // Act
            XMLDocument testObject = new XMLDocument(validFilePath, validStylingPath);
            Action<string> editPath = x => testObject.XmlFilePath = x;

            // Assert
            Assert.Throws<ArgumentException>(() => editPath(invalidFilePath));
        }


    }
}