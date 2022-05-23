using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public double Weight
        {
            get;
            set;
        }

        public Person(string name, string surname, int age, double weight)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
