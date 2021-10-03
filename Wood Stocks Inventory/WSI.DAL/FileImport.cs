using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Stocks_Inventory.WSI.DAL
{
    /// <summary>
    /// Abstract base class for importing different kinds of files.
    /// </summary>
    abstract class FileImport
    {
        /// <summary>
        /// Determines whether the file is valid and can be passed into the program.
        /// </summary>
        public virtual bool IsValid { get; set; }

        /// <summary>
        /// Abstract method containing logic for ensuring the correct file has been imported.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        protected abstract bool ValidateFile(string filePath);
    }


}
