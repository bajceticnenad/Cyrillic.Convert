using Cyrillic.Convert.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Creator
{
    /// <summary>  
    /// The 'Creator' Abstract Class  
    /// </summary>  
    abstract class ConversionFactory
    {
        public abstract ConversionDictionaries GetConversionDictionaries();
    }
}