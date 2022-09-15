using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date obj = new Date();
            Console.WriteLine(obj.Displayvalue());

            Date obj1 = new Date(16, "sept", 2020);
            Console.WriteLine(obj1.Displayvalue());


            circle cir = new circle(12);
            cir.Area();
            Console.WriteLine(cir.displayarea());

            Employee emp = new Employee(9250, "Rahul", 20000, 200);
            emp.Totalsalary();
            Console.WriteLine(emp.Displaysalary());

            Rectangle rect = new Rectangle(20, 30);
            rect.Perimeter();
            Console.WriteLine(rect.displayperimeter());






        }
    }
}
