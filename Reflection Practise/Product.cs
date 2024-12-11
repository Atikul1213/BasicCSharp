namespace Reflection_Practise
{
    public class Product : IPurchable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public Product(string name, double price, double tax)
        {
            this.Name = name;
            this.Price = price;
            this.Tax = tax;
        }
        public double CalculatePriceAfterTax()
        {
            return Price + Tax;
        }

        public double CalculateDiscount(double discount)
        {
            return Price * discount / 100;
        }
    }
}
