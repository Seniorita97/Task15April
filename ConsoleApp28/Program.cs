using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student ali = new Student();
            Console.WriteLine(ali.Age);

            Student murad = new Student();
            Console.WriteLine(murad.Age);

            Student gadir = new Student();
            Console.WriteLine(gadir.Age);

            Student nicat = new Student();
            Console.WriteLine(nicat.Age);
        }

        public class Student
        {
            private static int lastAge = 0;
            public int Age { get; }

            public Student()
            {
                lastAge++;
                Age = lastAge;
            }
        }
    }
}
