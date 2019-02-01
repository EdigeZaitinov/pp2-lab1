using System;


namespace task2
{
    public class Student //Class Student
    {
        public String Name; // details of Class
        public String ID;
        public int Year;


        public Student(string Id, string name, int year) // Instance constructor
        {
            Name = name; // details of constructor
            ID = Id;
            Year = year;

        }

    }

    class Program
    {
        static void Main()
        {
            Student stud = new Student(" ", " ", 2); //Creating a new Student object
            stud.ID = Console.ReadLine(); //Input
            stud.Name = Console.ReadLine();
            stud.Year = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(stud.ID + " " + stud.Name + " " + stud.Year); //output  
        }
    }
}