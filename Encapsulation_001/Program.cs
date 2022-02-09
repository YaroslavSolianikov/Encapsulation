using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу в которой создайте класс «Адрес».
/// В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
/// Для каждого поля, создать свойство с двумя методами доступа.Также в классе необходимо создать метод для отображения информации про адрес.
/// В методе Main() создайте экземпляр класса «Адрес», присвойте всем полям значение через свойства доступа,
/// а также на экземпляр класса вызовите метод, который выводит информацию про адрес.
/// </summary>
namespace Encapsulation_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            Console.WriteLine("Enter your country");
            adress.Country = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your city");
            adress.City = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your street");
            adress.Street = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter number of your house");
            adress.House = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of your flat");
            adress.Flat = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your index");
            adress.Index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            adress.Info();
            Console.ReadLine();
        }
    }
}
