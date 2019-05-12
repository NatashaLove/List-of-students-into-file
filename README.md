# nlove_Final1
creates list of students and saves it to a file
CIS-2023 – Intro to C# – Final Project
Prompt
The final project is a two-part exercise showcasing an understanding of the skills and concepts we have covered this semester. The first part will showcase the student’s understanding of object-oriented programming. The second part will focus on creating a Graphical User Interface that demonstrates a basic level of understanding of working with files and streams.
General Requirements
1.	The completed parts of this exercise must compile without crashing. Files that do not compile without error will receive – at most – a 50%.
2.	All classes must be self-contained in their own files.
3.	Both parts of the project should be zipped individually as we’ve done all semester. Then, the two parts should be placed into a folder and zipped. This final zip file will be submitted to Canvas.
4.	Unlike prior assignments, the .exe file does NOT need to be moved prior to zipping.
5.	The first part of the assignment is a Console Application and therefore needs to wait for the user to press any key to exit. As the second part will be a Windows Form Application, this is not need for that part
Part 1 – Object-Oriented Programming Requirements
1.	Create a public abstract class Person (in its own file)
a.	Two private properties: string _name and int _age
b.	One protected property: static int _id – initialized to zero (0)
c.	One default constructor that calls the overloaded constructor with an empty string and the number zero (“” , 0)
d.	An overloaded constructor that accepts a string name and int age as parameters and sets the following properties:
i.	Name = name
ii.	Age = age
iii.	_id++
e.	A public string Name property with a getter that returns _name and a setter that sets the _name to value
f.	A public int Age property with a getter that returns _age and a setter that checks to see if the value entered is below zero. If it is, it sets _age to zero and displays a message telling the user a negative value for age is not valid; otherwise, it sets the _age to value
g.	A public abstract string method called DisplayInformation that accepts no parameters
2.	Create a public Student class (in its own file)
a.	Extends the Person class
b.	Two private string properties: _major and _level
c.	A private readonly string called _studentID
d.	A public constructor that accepts a string name and int age
i.	This constructor calls the base constructor and passes the name and age to it
ii.	This constructor sets _studentID = “S” + (_id + 1000000).ToString()
iii.	Set Major to Computer Science by default
iv.	Set Level to Freshman by default
e.	A public string Major property with a basic getter and setter
f.	A public string Level property with a basic getter and setter
g.	A public string StudentID property with a basic getter (no setter, as _studentID is readonly
h.	A public override string method called DisplayInformation that returns a String.Format with all of the student information (StudentID, Name, Age, Level, and Major) using string formatting to produce consistent output
i.	The formatting string will be available as a text file that can be copied/pasted
i.	Override the ToString method to return a formatted string with all information (StudentID, Name, Age, Level, and Major) separated by commas
3.	In the Program.Main method
a.	Create three to six Student objects with names and ages
i.	Student s1 = new Student(“Joe”, 15); // and so on..
b.	Use the setters to update the majors and levels of a couple students to values of your choice
i.	 Majors could be “English”, “History”, “Engineering”, and so on
ii.	Levels could be “Sophomore”, “Junior”, “Senior”, “Graduate”
c.	Create an array (or list) of students and initialize this array (or list) with the students you’ve created
d.	Loop through the array/list and call the DisplayInformation method on each object
e.	Loop through the array/list and call the ToString method on each object
