using System.Globalization;
using System.Text;

namespace Tag.Entities
{
    class Product
    {
        public string Name { get; set; }

        protected double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
                StringBuilder tag = new StringBuilder("");
                tag.Append(Name);
                tag.Append(" $ ");
                tag.AppendLine(Price.ToString("F2", CultureInfo.InstalledUICulture));

                return tag.ToString();
        }
    }
}