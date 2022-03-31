using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022second
{
   public abstract class Person
    {
        private byte _age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get { return _age; }
            set 
            {
                if (value < 18)
                {
                    Console.WriteLine("Isleme huququ yoxdur!");
                }
                else
                {
                    _age = value;

                }
            
            }
        }
    }
}
