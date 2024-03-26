using Cyrillic.Convert.Product.ConcreteProducts;
using Cyrillic.Convert.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    internal class GeorgianConversionFactory : ConversionFactory
    {
        public GeorgianConversionFactory()
        {
        }
        public override ConversionDictionaries GetConversionDictionaries()
        {
            return new Georgian();
        }
    }
}
