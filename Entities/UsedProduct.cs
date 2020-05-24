using System;
using System.Globalization;
using System.Text;

namespace Tag.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureProduct { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureProduct) : base(name, price)
        {
            ManufactureProduct = manufactureProduct;
        }

        sealed public override string priceTag()
        {
            StringBuilder tag = new StringBuilder();
            tag.Append(Name);
            tag.Append(" (used) $ ");
            tag.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            tag.Append(" (Manufacture Date: ");
            tag.Append(ManufactureProduct.ToString("dd/MM/yyyy"));
            tag.AppendLine(")");

            return tag.ToString();
        }
    }
}