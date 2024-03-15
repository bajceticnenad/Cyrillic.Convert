using Cyrillic.Convert.Product.ConcreteProducts;
using Cyrillic.Convert.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    class RussianConversionFactory : ConversionFactory
    {
        public RussianConversionFactory()
        {
        }
        public override ConversionDictionaries GetConversionDictionaries()
        {
            return new Russian();
        }
    }
}
