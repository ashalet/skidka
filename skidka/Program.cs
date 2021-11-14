using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skidka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price;

            price = double.Parse(Console.ReadLine());


            if (price < 500)
            {
                Console.WriteLine($"Стоимость покупки составляет: {price}");
            
            }
            else if (price < 1000 && price >= 500)
            {
                Console.WriteLine($"Стоимость покупки составляет: {price * 0.95}");
            }
            else
            {
                Console.WriteLine($"Стоимость покупки составляет: {price * 0.9}");
            }
            Console.ReadLine();
        }
    }
}
