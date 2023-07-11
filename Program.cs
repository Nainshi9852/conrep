using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to c#");
            // Console.ReadKey();
            //DataType variable name Example-2
            /*
             string firstName;
            string lastName;
            Console.WriteLine("Enter First Name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();
            Console.WriteLine("Welcome MR/MS. "+firstName+" "+lastName); 
            Console.ReadKey();
            */
            //Eaxmple 3
            //DataType.parse()
            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter Name");
            name= Console.ReadLine();
            Console.WriteLine("Enter age");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");
            grade=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter DOJ");
            doj=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Name : \t" + name + "\n Age: " + age + "\n Grade: \t"
                + grade + "\n Salary: \t " + salary + "\n Date Of Joining: \t " + doj);
            Console.ReadKey();

        }
    }
}
