using System;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Static_keyword_extention_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            string input="0" ;
            do
            {
                Console.WriteLine("Create Student");
                string fullname="";
                string groupno="";
                byte age = 0;
                do
                {
                    Console.WriteLine("\nStudent Fullname daxil edin:");
                    fullname = Console.ReadLine();
                } while (!Student.CheckFullname(fullname));

                do
                {
                    Console.WriteLine("Group No daxil edin:");
                    groupno = Console.ReadLine();
                } while (!Student.CheckGroupNo(groupno));

                do
                {
                    Console.WriteLine("Age daxil edin:");
                    age = Convert.ToByte(Console.ReadLine());
                } while (!Student.CheckAge(age));

                Console.WriteLine("Student created.");
            } while (input != "0") ;

        }
    

       
    }
}
