using Cyrillic.Convert.Product;
using Cyrillic.Convert.Product.ConcreteProducts;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    internal class BelarusianConversionFactory : ConversionFactory
    {
        public override ConversionDictionaries GetConversionDictionaries() => new Belarusian();
    }
}
