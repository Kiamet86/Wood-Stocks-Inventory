using System;
using System.Collections.Generic;
using System.Text;

namespace WSI.Common
{
    public static class FileTypeCheck
    {
        public static bool SetterCheck(string value, string filetype)
        {
            if (value.EndsWith("." + filetype)) return true;
            else return false;
        }
    }
}
