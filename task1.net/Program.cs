namespace task1.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of small carpets");
            int smallcarpets = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter number of large carpets");
            int largecarpets = Convert.ToInt32(Console.ReadLine()); 
            int small = 25; int large = 35; double cost = small * smallcarpets + large * largecarpets; 
            Console.WriteLine($"the cost before tax : {cost:C}"); 
            double tax = 0.06; Console.WriteLine($"the tax : {cost * tax:C}");
            Console.WriteLine($"Total estimate : {cost * tax + cost:C}"); 
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
