using System;
using System.Collections.Generic;
using System.Text;
using Task1;

namespace Task1
{
    public class EmployeeExperienceComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Experience < y.Experience)
            {
                return 1;
            }
            else if (x.Experience > y.Experience)
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
//EmployeeExperienceComparer — сортировка по опыту работы (по убыванию).
