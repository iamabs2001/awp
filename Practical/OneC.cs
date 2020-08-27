using System;

namespace Sigma.Practical
{
    class OneC
    {
        struct Student
        {
            public string studid, name, cname;
            public int day, month, year;
        }
        static void Main(string[] args)
        {
            Student[] s = new Student[2];
            int i;
            Console.WriteLine("Abhijeet Sharma");
            for (i = 0; i < 2; i++)
            {
                Console.Write("Enter student Id : ");
                s[i].studid = Console.ReadLine();
                Console.Write("Enter student name : ");
                s[i].name = Console.ReadLine();
                Console.Write("Enter Course name : ");
                s[i].cname = Console.ReadLine();
                Console.Write("Enter date of birth \t Enter day(1=31) : ");
                s[i].day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter month(1-12) : ");
                s[i].month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter year : ");
                s[i].year = Convert.ToInt32(Console.ReadLine());
            }
                Console.WriteLine("\n\nStudent's List\n");
                for(i=0;i<2;i++)
                {
                    Console.WriteLine("Student ID : "+ s[i].studid);
                    Console.WriteLine("Student Name : " + s[i].name);
                    Console.WriteLine("Course Name : " + s[i].cname);
                    Console.WriteLine("Date of birth(dd-mm-yy) : " + s[i].day+ "-" +s[i].month +"-"+ s[i].year);

                }
            }      
    }
}
