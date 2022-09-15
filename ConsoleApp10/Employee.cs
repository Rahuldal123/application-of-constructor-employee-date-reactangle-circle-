using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Employee
    {
        private int empid;
       private int  basic;
       private string name;
       private double da, hra, pf, pt, totalsal;



        public Employee(int empid,string name,int basic,int pt )
        {
            this.empid= empid;
            this.name=name;
            this.basic=basic;
            this.pt = pt;
        }
       
        public void Totalsalary()
        { 
            da = basic * 0.2;
            hra = basic * 0.4;
            pf = basic * 0.12;
            totalsal=basic +da+hra-pf-pt;
        }
        public string Displaysalary()
        {
            return $" emp id= {empid} Name= {name} totalnet paid salary= {totalsal}";
        }

    }
  
        
}
