using Cyrillic.Convert.Product;
using Cyrillic.Convert.Product.ConcreteProducts;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    internal class MacedonianConversionFactory : ConversionFactory
    {
        public override ConversionDictionaries GetConversionDictionaries() => new Macedonian();
    }
}
