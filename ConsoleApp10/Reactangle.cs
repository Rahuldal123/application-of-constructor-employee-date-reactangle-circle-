using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Rectangle
    {
        private int length, width,perimeter ;


       public  Rectangle(int length,int width)
        {
            this.length = length;
            this.width = width;

        }
        public void Perimeter()
        {
            perimeter = 2 * (length + width);
        }
        public string displayperimeter()
        {
           return $"Perimeter of rectangle is {perimeter}";
        }

    }
}
