using System;

namespace q3
{
    public delegate void TrafficDel();
    class TrafficSignal
    {
       public void Yellow()
        {
            Console.WriteLine("Yellow");
        }
        public void Green()
        {
            Console.WriteLine("Green");
        }
        public void Red()
        {
            Console.WriteLine("Red");
        }
        static void Main(string[] args)
        {
            TrafficSignal ts = new TrafficSignal();
            TrafficDel deltraffic = new TrafficDel(ts.Yellow);
            deltraffic();
            deltraffic += ts.Green;
            deltraffic();
            deltraffic += ts.Red;
            deltraffic();
        }
    }

    
}
