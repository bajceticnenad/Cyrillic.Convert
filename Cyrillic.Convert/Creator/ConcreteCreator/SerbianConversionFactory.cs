using Cyrillic.Convert.Product;
using Cyrillic.Convert.Product.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    /// <summary>  
    /// SerbianConversionFactory 'ConcreteCreator' class  
    /// </summary>  
    class SerbianConversionFactory : ConversionFactory
    {
        public SerbianConversionFactory() 
        { 
        }
        public override ConversionDictionaries GetConversionDictionaries()
        {
            return new Serbian();
        }
    }
}