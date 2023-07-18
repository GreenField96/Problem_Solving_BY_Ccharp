//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace helloAppCcharp
{
    public class Employee
    {
        int salary;
        String Name;
       
        public Employee(String name , int salary)
        {
            this.Name = name;
            this.salary = salary;  
        }
        public String getName()
        {
            return this.Name;
        }
        public int getSalary()
        {
            return this.salary;
        }

    }
}