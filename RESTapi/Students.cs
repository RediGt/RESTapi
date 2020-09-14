using System;
using System.Collections.Generic;
using System.Text;

namespace RESTapi
{
    class Students
    {
        public String name;
        public String lastName;
        public int age;


        public Students(String name, String lastName, int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine(name + "  " + lastName + "  " + age);
        }
    }
}
