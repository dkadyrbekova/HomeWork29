using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class EmployeeSalaryAndAgeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            
            if (x.Salary < y.Salary)
            {
                return 1;
            }
            if (x.Salary > y.Salary)
            {
                return -1;
            }

            if (x.Salary == y.Salary && x.Age > y.Age)
            {
                return 1;
            }
            if (x.Salary == y.Salary && x.Age < y.Age)
            {
                return -1;
            }


            if (x.Salary == y.Salary && x.Age == y.Age)
            {
                return string.Compare(x.Name, y.Name);
            }

            return 0;
        }
    }
}
//Создай EmployeeSalaryAndAgeComparer.
//Он должен сортировать сотрудников по следующим правилам:
//Сначала по зарплате в порядке убывания.
//Если зарплата одинаковая, по возрасту в порядке возрастания.
//Если совпадают и зарплата, и возраст, по имени в алфавитном порядке.
//Используй этот компаратор для сортировки списка.
