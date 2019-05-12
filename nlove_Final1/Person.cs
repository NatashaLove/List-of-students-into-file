using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nlove_Final1
{
   public abstract class Person
    {
        private string _name;
        private int _age;
        protected static int _id = 0;

       // overloaded constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            _id++;
        }
        //default constructor that calls the overloaded constructor with an empty string and the number zero (“” , 0)

        public Person() : this("", 0)
        {

        }


        //Name property 
        public string Name { get; set; }

        //Age property
        public int Age
        {

            get
            {
                return _age;
            }

            set
            {
             if (value<0)
                {
                    Console.WriteLine("Negaive value for age is not valid.");
                }
                // checks to see if the value entered is below zero
                _age = (value >= 0) ? value : 0;// if value>=0, _age=value; else - _age=0 

               
            }

        }
        //abstract method - will be overridden in the child class
        public abstract string DisplayInformation();
    }
}
