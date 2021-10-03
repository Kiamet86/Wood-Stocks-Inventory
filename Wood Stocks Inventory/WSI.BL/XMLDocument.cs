using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WSI.Common;
using System.Xml.XPath;

namespace Wood_Stocks_Inventory.WSI.BL
{
    public class XMLDocument
    {
        private XDocument xmlDoc;
        private List<XElement> elementList;
        private string xmlFilePath;
        private string cssStylesheetPath;
        private string dateCreated;

        public string DateCreated { get; set; }
        public XDocument XmlDoc { get; set; }
        public List<XElement> ElementList { get; set; }

        /// <summary>
        /// Get - returns xmlFilePath. <br/>
        /// Set - checks file ends with .xml extension, if not an exception is thrown.
        /// </summary>
        public string XmlFilePath
        {
            get { return xmlFilePath; }
            set { if (value.EndsWith(".xml") == false) 
                    throw new ArgumentException("{0} is invalid. Please provide a filepath to an XML file.", value);
                    else xmlFilePath = value;
            }
        }

        /// <summary>
        /// Get - returns cssFilePath. <br/>
        /// Set - checks file ends with .css extension, if not an exception is thrown.
        /// </summary>
        public string CssStylesheetPath
        {
            get { return cssStylesheetPath; }
            set
            {
                if (value.EndsWith(".css") == false)
                    throw new ArgumentException("{0} is invalid. Please provide a filepath to a CSS file.", value);
                else cssStylesheetPath = value;
            }
        }

        /// <summary>
        /// Constructs a new XDocument object, with filepath to save to disk, <br/> 
        /// CSS filepath for styling, List of Elements to generate elements from, <br/> 
        /// current date to timestamp the file, XDeclaration, XProcessing Instruction, <br/>
        /// and root element labeled StockItems.
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="cssStylesheetPath"></param>
        /// <param name="elementList"></param>
        /// <param name="dateCreated"></param>
        public XMLDocument(string xmlFilePath, string cssStylesheetPath, 
            List<XElement> elementList, string dateCreated)
        {
            XmlFilePath = xmlFilePath;
            CssStylesheetPath = cssStylesheetPath;
            ElementList = elementList;
            DateCreated = dateCreated;

            var xmldoc =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XProcessingInstruction("xml-stylesheet", 
                        $"type='text/css' href='{CssStylesheetPath}'"),
                    new XElement("StockItems", 
                        $"Wood Stocks Inventory Report for {dateCreated}"));

            XmlDoc = xmldoc;
        }

        /// <summary>
        /// Constructs XML doc with file path to save to, CSS styling sheet, and Stock Items root node.
        /// </summary>
        /// <param name="xmlFilePath"></param>
        /// <param name="cssStylesheetPath"></param>
        public XMLDocument(string xmlFilePath, string cssStylesheetPath)
        {
            XmlFilePath = xmlFilePath;
            CssStylesheetPath = cssStylesheetPath;

            var xmldoc =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XProcessingInstruction("xml-stylesheet", $"type='text/css' href='{CssStylesheetPath}'"),
                    new XElement("StockItems"));

            XmlDoc = xmldoc;
        }

     
        /// <summary>
        /// Constructs empty XML document, no styling. <br/> Used for testing.
        /// </summary>
        public XMLDocument()
        {
            var xmldoc =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"));

            XmlDoc = xmldoc;
        }

        /// <summary>
        /// Constructor that passes in List of XElement, with "Stock Items" root node. 
        /// <br>Used for Testing.</br>
        /// </summary>
        /// <param name="elementList"></param>
        public XMLDocument(List<XElement> elementList)
        {
            ElementList = elementList;

            var xmldoc =
                new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement ("StockItems"));

            XmlDoc = xmldoc;

        }

        /// <summary>
        /// Adds a list of XElements as children to the root node of the XML document.
        /// </summary>
        /// <param name="elementList"></param>
        public void Add(List<XElement> elementList)
        {
            foreach (XElement element in elementList)
            {
                XmlDoc.Root.Add(element);
            }
        }

        /// <summary>
        /// Saves XML document to disk using filepath given.
        /// </summary>
        /// <param name="filePath"></param>
        public void SaveToDisk(string filePath)
        {
            XmlDoc.Save(filePath);
        }





    }
}
