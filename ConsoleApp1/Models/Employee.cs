using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
     public class Employee
    {

        string _name;
        string _surname;
        string _username;
        int _age;

        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Username = _name.ToUpper() + "_" + _surname.ToUpper();
         
        }

        public string Name 
        { 
            get => _name;
            set
            {
                _name = value;
                _name = char.ToUpper(_name[0]) + _name.Substring(1);
            } 
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("yasi duzgun daxil edin");
                }
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
            }
        }

        public string Surname 
        { 
            get => _surname; 
            set 
            {
                _surname = value;
            }
        }

    }
}
