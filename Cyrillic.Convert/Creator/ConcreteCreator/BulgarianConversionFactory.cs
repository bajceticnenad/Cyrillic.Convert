using Cyrillic.Convert.Product.ConcreteProducts;
using Cyrillic.Convert.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    internal class BulgarianConversionFactory : ConversionFactory
    {
        public BulgarianConversionFactory()
        {
        }
        public override ConversionDictionaries GetConversionDictionaries()
        {
            return new Bulgarian();
        }
    }
}
