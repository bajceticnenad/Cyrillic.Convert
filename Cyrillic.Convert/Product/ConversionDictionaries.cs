using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Product
{
    /// <summary>  
    /// ConversionDictionary - The 'Product' Abstract Class  
    /// </summary>  
    public abstract class ConversionDictionaries
    {
        public abstract Dictionary<char, string> GetToLatinDictionary();
        public abstract Dictionary<char, string> GetStartDictionary();

        public abstract Dictionary<string, string> GetStartToCyrillicDictionary();

        public abstract Dictionary<string, string> GetToCyrillicDictionary();

        public abstract Dictionary<string, string> GetSpecialDictionary();
    }
}
