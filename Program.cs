using System.ComponentModel.Design;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Assignment_2_1
{
    /*1. Write a class: “Student” with private data members:
            StudentId ( int), StudentFname (string), StudentLname (string )
            StudentGrade ( char ) and public properties for each data 
            member. Instantiate the class and assign data to properties. 
            Display the data back on console.*/

    public class Student
    {
        //fields
        private int studentId;
        private string studentFname;
        private string studentLname;
        private char studentGrade;
        //fields

        //properties
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentFname
        {
            get { return studentFname; }
            set { studentFname = value; }
        }

        public string StudentLname
        {
            get { return studentLname; }
            set { studentLname = value; }
        }

        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }
        //properties

        
        //format
        public Student(int id, string fname, string lname, char grade)
        {
            StudentId = id;
            StudentFname = fname;
            StudentLname = lname;
            StudentGrade = grade;
        }
        //format
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter Student ID:");
            
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            //student data

            switch (value)
            {
                case 1:
            Student student1 = new Student(1, "John", "Doe", 'A');

            Console.WriteLine("Report Card");
            Console.WriteLine("");
            Console.WriteLine("Student ID: " + student1.StudentId);
            Console.WriteLine("First Name: " + student1.StudentFname);
            Console.WriteLine("Last Name: " + student1.StudentLname);
            Console.WriteLine("Grade: " + student1.StudentGrade);
                break;

                case 2:
            Student student2 = new Student(2, "Jimmy", "Bones", 'D');

            Console.WriteLine("Report Card");
            Console.WriteLine("");
            Console.WriteLine("Student ID: " + student2.StudentId);
            Console.WriteLine("First Name: " + student2.StudentFname);
            Console.WriteLine("Last Name: " + student2.StudentLname);
            Console.WriteLine("Grade: " + student2.StudentGrade);
                    break;

                    //insert non-existant studuent ID
                    // = "Student ID does not exist."
            }
            //student data
        }
    }
}

//Design a class heirarchy (2.1.2)

//Food chains cause why not?

//Burgers
//-McDonalds
//--Big Mac
//---cheese
//---buns
//---burger 
//---pickles?
//-Burger King
//-A&W
//--Root Beer?

//Pizza
//-Little Ceaser's
//--Hot 'n Ready
//-Pizza Hut
//-Dominos

//Subs
//-Subway
//--Footlong Chicken Bacon Ranch
//-Firehouse Subs
//-Tubby's Submarines


/*Overloading: Write a simple Maths class (don’t use the keyword Math, it will be a conflict with standard class from system). 
Write overloaded methods with logic and give choice to user to call different methods:
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static. */
