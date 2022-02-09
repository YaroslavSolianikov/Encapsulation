using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_001
{
    class Adress
    {
        private string country;
        private string city;
        private string street;
        private int house;
        private int flat;
        private int index;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public int Flat
        {
            get { return flat; }
            set { flat = value; }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        public void Info() => Console.WriteLine($"Country:{country} \nCity:{city}\nStreet:{street}\nHouse:{house}\nFlat:{flat}\nIndex:{index}");
    }
}
