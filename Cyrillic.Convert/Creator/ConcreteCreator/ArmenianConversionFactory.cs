using Cyrillic.Convert.Product;
using Cyrillic.Convert.Product.ConcreteProducts;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    internal class ArmenianConversionFactory : ConversionFactory
    {
        public override ConversionDictionaries GetConversionDictionaries() => new Armenian();
    }
}
