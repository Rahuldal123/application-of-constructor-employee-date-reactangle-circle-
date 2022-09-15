using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class circle
    {
       
        private double radius, area;
       
        public circle(int radius)
        {
            this.radius = radius;
        }

        public void Area()
        {
            area = 3.14 * radius * radius;
        }
        public string  displayarea()
        {
            return $"area of circle is {area}";
        }
    }
}
