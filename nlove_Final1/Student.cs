using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nlove_Final1
{
    //Extends the Person class
    public class Student : Person
    {
        private string _major;
        private string _level;
        private readonly string _studentID;

        //constructor calls the base constructor and passes the name and age to it
        public Student(string name, int age):base()
        {
            this.Name = name;
            this.Age = age;
            
            //creates student id
            _studentID = "S" + (_id + 1000000).ToString();
            _major = "Computer Science";
            _level = "Freshman";

        }

        public string Major { get; set; }= "Computer Science";
        public string Level { get; set; } = "Freshman";
        public string StudentID { get; } = "S" + (_id + 1000000).ToString();

        //to display/print info in  Main
        //overriding abstract method of the parent class
        public override string DisplayInformation()
        {
           string text;
           return text = String.Format("Student ID: {0}, Student Name: {1}, Student Age: {2}, Student Level: {3}, Student Major: {4}.", 
               StudentID, Name, Age, Level, Major );

        }
        // to save in a file through filestresm and streamwriter (or display / print in Main)
        public override string ToString()
        {
            return StudentID + ", " + Name + ", " + Age + ", " + Level + ", " + Major + ".";
        }

        
    }
}

