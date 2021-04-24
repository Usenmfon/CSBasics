using System;

namespace consoleApp
{
    public class Dog
    {
        public Dog()
        {
            
        }

        public string name;
        public string Name
        {
            get
            {
               return name;
            }

            set
            {
                name = value;
            }
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} Dogs Bark");
        }
    }
}