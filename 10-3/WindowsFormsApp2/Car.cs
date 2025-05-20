using CarPriceDisplay.Interfaces;

namespace CarPriceDisplay.Models
{
    public class Car : IPrice
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Car(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double GetPrice() => Price;
        public string GetName() => Name;
    }
}