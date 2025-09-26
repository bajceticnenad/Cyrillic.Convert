using Cyrillic.Convert.Product;
using Cyrillic.Convert.Product.ConcreteProducts;

namespace Cyrillic.Convert.Creator.ConcreteCreator
{
    internal class GreekConversionFactory : ConversionFactory
    {
        public GreekConversionFactory()
        {
        }
        public override ConversionDictionaries GetConversionDictionaries()
        {
            return new Greek();
        }
    }
}
