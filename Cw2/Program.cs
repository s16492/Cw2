using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var path = @"c:\Users\jd\Desktop\dane.csv";
            var lines = File.ReadLines(path);

            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }

            var parsedDate = DateTime.Parse("2020-03-10");
            Console.WriteLine(parsedDate);
            var today = DateTime.Today;
            // var today = DateTime.UtcNow;
            Console.WriteLine(today);
            Console.WriteLine(today.ToShortDateString());



            var has = new HashSet<Student>();

            var stud1 = new Student
            {
                FirstName = "Jan";
            LastName = "Kowalski";
            Index= 1234;
            }



        HashSet<Student> studenci = new HashSet<Student>(new OwnComparator());











  

        }
    }
}
