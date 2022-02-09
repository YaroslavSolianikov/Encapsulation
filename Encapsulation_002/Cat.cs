using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_002
{
    class Cat
    {
        private string name;
        private int age;
        private string skinColor;
        private string eyesColor;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string SkinColor
        {
            get { return skinColor; }
            set { skinColor = value; }
        }
        public string EyesColor
        {
            get { return eyesColor; }
            set { eyesColor = value; }
        }
        public void Info() => Console.WriteLine($"\nName:{name} \nAge:{age}\nSkin color:{skinColor}\nEyes color:{eyesColor}");
        public void Meow(int m)
        {
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("\nMeow");
            }
        }
    }
}
