using Cyrillic.Convert.Creator;
using Cyrillic.Convert.Product.ConcreteProducts;
using Cyrillic.Convert.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    /// <summary>  
    /// UkrainianConversionFactory 'ConcreteCreator' class  
    /// </summary>  
    class UkrainianConversionFactory : ConversionFactory
    {
        public UkrainianConversionFactory()
        {
        }

        public override ConversionDictionaries GetConversionDictionaries()
        {
            return new Ukrainian();
        }
    }
}