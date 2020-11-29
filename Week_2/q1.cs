using System;

namespace q1
{
    public delegate void PriceChangedEventHandler();
    class Item
    {
        string name;
        double price;
        public string Name
        {
            get; set;
        }
        
        public event PriceChangedEventHandler PriceChanged;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                if(PriceChanged != null)
                {
                    PriceChanged();
                }
            }
        }
       
    }
    class Subscriber
    {
        
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Price = 24;
            item.PriceChanged += ChangeDetected;
            Console.WriteLine("Enter price: ");
            double price;
            double.TryParse(Console.ReadLine(), out price);
            item.Price = price;
        }
        public static void ChangeDetected()
        {
            Console.WriteLine("Price changed!");
        }
    }
}
