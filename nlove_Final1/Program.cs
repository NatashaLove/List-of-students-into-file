using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace nlove_Final1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Students (objects)
            Student s1 = new Student("Nick", 19);
            Student s2 = new Student("Bella", 18);
            Student s3 = new Student("Victor", 21);
            Student s4 = new Student("Susie", 20);

            s1.Level = "Sophomore";
            s3.Level = "Graduate";
            s2.Major = "English";
            s4.Major = "History";

            //create filestream to save the info from ToString() into the file.txt
            FileStream f = new FileStream("file.text", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // streamWriter is used to write into the file.txt
            StreamWriter s = new StreamWriter(f);

            //create an array of students (or list)- to applay methods to each of them
            Student[] stud_array = new Student[] { s1, s2, s3, s4 };

            //use foreach
            foreach (var Stud in stud_array)
            {
                //Prints out info as a list / from array
                Console.WriteLine(Stud.DisplayInformation());
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
      
                //saves info in the file.txt
                Stud.ToString();
                //method to write into streamWriter object (s) - after that the file.txt is created with saved info:
                s.WriteLine(Stud.ToString());

            }
            
            // always close the objects: streamwriter and filestream - after being done with them
            s.Close();
            f.Close();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
