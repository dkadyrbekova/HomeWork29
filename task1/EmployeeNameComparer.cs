using System;
using System.Collections.Generic;
using System.Text;
using Task1;
namespace task1
{
    public  class EmployeeNameComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }
}
