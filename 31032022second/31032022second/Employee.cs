using System;
using System.Collections.Generic;
using System.Text;

namespace _31032022second
{
    class Employee:Person
    {
        private int _workinghour;
        public int SalaryOfHour;
        public int WorkingHour {
            get
            {
                return _workinghour;
            }
            set 
            {
                if (value > 8)
                {
                    Console.WriteLine("gundelik is saati 8-den cox olmamalidir!");
                }
                else
                {
                    _workinghour = value;
                }
            }
            }
        public void CalculateSalary()
        {
            int Salary=0;
            Salary = SalaryOfHour * WorkingHour;
            if (Salary >= 250)
            {
                Console.WriteLine($" Salary= {Salary}");
            }
            else
            {
                Console.WriteLine("Maas 250-den kicik ola bilmez");
            }
            
        }


        public Employee(string name, string surname, byte age, int salaryofhour, int workinghour)
        {

        }
    }
}
