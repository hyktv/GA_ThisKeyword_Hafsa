using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_ThisKeyword_Hafsa
{
    public class Person
    {
        //feilds
        private string name;
        private int age;

        //constructor that uses 'this' to distinguish feilds from parameters
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //method to display the persons details
        public void Display()
        {
            Console.WriteLine($"Name: {this.name}, Age: {this.age}");
        }

        //overload constructor
        //this additional constructor only takes a name and calls the main one using "this" passing a default age
        public Person(string name) : this(name, 0) //call the main constructor
        {
        }

        //method to update the persons age
        public void SetAge(int age)
        {
            this.age = age; //'this' clarifies that we're assigning to the instance field
        }

    }//class


}//namespace
