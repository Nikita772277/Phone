using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Contact
    {
        private string _number;
        private string _name;
        private string _surname;
        public Contact(string number, string name, string surname)
        {
            _number = number;
            _name = name;
            _surname = surname;
        }
        public void GetName()
        {
            Console.WriteLine($"{_name}");
        }
        public string GetNumber()
        {
            return _number;
        }
        public void GetInformation()
        {
            Console.WriteLine();
            Console.WriteLine($"Имя {_name}");
            Console.WriteLine($"Faмилия {_surname}");
            Console.WriteLine($"номер {_number}");
            Console.WriteLine();
        }
    }
}
