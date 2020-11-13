using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace WpfApp1
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Human(string name = "unknow", string surname = "unknow", int age = 0)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
       
    }
}
