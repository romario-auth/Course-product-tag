using System.Globalization;
using System.Text;

namespace Tag.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double totalPrice()
        {
            return Price + CustomFee; 
        }

        sealed public override string priceTag()
        {
            StringBuilder tag = new StringBuilder();
            tag.Append(Name);
            tag.Append(" $ ");
            tag.Append(totalPrice().ToString("F2", CultureInfo.InvariantCulture));
            tag.Append(" (Customs fee: $");
            tag.Append(CustomFee.ToString("F2", CultureInfo.InvariantCulture));
            tag.AppendLine(")");

            return tag.ToString();
        }
    }
}