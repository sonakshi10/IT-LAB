using System;

namespace q2
{
   class Item
    {
        string name;
        public static double cost;
        public string Name { get; set; }

        public static double CalcGST()
        {
            return 0.08 * cost;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            item.Name = "item1";
            Item.cost = 24;
            double gst = Item.CalcGST();
            Console.WriteLine("GST: {0}", gst);
        }
    }
}
