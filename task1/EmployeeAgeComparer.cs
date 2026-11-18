using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class EmployeeAgeComparer : IComparer<Employee>
    {
       public int  Compare (Employee employee1 , Employee employee2)
        {
            if (employee1.Age > employee2.Age)
            {
                return 1;
            }
            else if (employee1.Age < employee2.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
