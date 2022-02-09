using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Console.WriteLine("Enter the name of cat");
            cat.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the age of cat");
            cat.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter color of skin");
            cat.SkinColor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter color of eyes");
            cat.EyesColor = Convert.ToString(Console.ReadLine());
            cat.Info();
            cat.Meow(3);
            Console.ReadKey();
        }
    }
}
