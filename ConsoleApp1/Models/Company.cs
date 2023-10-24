using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Company
    {
        string _name;

        public Company(string name)
        {
            Name = name;
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
    }
}
