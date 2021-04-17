using System.Globalization;

namespace Exerc_HP_2.Entities
{
    class ImportedProduct : Product
    {
        public double  customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double totalPrice()
        {
            return Price + customsFee;
        }

        public override string priceTag()
        {
            return Name
                + " $ "
                + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + customsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
