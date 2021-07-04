using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BillFactory factory = null;
            Console.Write("Uncle sent a bill from: ");
            string country = Console.ReadLine();
            int value = -1;
            while (value <= -1)
            {
                Console.WriteLine("It has a value of (number): ");
                string a = Console.ReadLine();
                if (int.TryParse(a, out int i))
                    value = int.Parse(a);
                else
                    value = -1;
            }
            int year = -1;
            while (year <= -1)
            {
                Console.WriteLine("And the year it was emitted was: (number): ");
                string b = Console.ReadLine();
                if (int.TryParse(b, out int i))
                    year = int.Parse(b);
                else
                    year = -1;
            }
            switch (country.ToLower())
            {
                case "japan":
                    factory = new YenFactory(value, year);
                    break;
                case "india":
                    factory = new RupeeFactory(value, year);
                    break;
                case "mexico":
                    factory = new PesoFactory(value, year);
                    break;
                case "england":
                    factory = new PoundFactory(value, year);
                    break;
                default:
                    break;
            }
            Bill newBill = factory.GetBillInformation();
            Console.WriteLine("The "+newBill.Value+" "+newBill.Name+" bill is from "+newBill.Year );
            Console.ReadKey();
        }
    }
}
