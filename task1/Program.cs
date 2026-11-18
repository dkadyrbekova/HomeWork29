using task1;
using Task1;
class Program
{
    static void Main(string[] args)
    {
        var employee = new Employee(1, "John Doe", 30, 500000, 5);
        Console.WriteLine(employee.ToString());

        List<Employee> employees = new List<Employee>
{
    new Employee(1, "John Doe", 30, 500000, 5),
    new Employee(2, "Jane Smith", 28, 90000, 3),
    new Employee(3, "Bob Johnson", 35, 400000, 10),
     new Employee(4, "Бакыт", 41, 120000, 15),
    new Employee(5, "Эльдар", 23, 55000, 1),
    new Employee(6, "Зарина", 28, 90000, 6),
    new Employee(7, "Алия", 30, 80000, 7)
};
        Console.WriteLine("==========Исходный список==========");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp.ToString());
        }
        Console.WriteLine();
        employees.Sort();
        Console.WriteLine("==========Список после сортировки==========");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp.ToString());
        }

        Console.WriteLine();
        employees.Sort(new EmployeeAgeComparer());

        Console.WriteLine("========== После сортировки по возрасту ==========");
        foreach (Employee e in employees)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine();
        employees.Sort(new EmployeeNameComparer());

        Console.WriteLine("========== После сортировки по имени ==========");
        foreach (var e in employees)
        {
            Console.WriteLine(e);
        }

        //для сортировки по имени в алфавитном порядке, можно использовать метод Sort() с передачей компаратора EmployeeNameComparer. Этот компаратор реализует интерфейс IComparer<Employee> и сравнивает имена сотрудников с помощью метода string.Compare().
        //конкретно EmployeeNameComparer реализует метод Compare, который принимает два объекта Employee и возвращает целое число, указывающее порядок их следования в списке. Если имя первого сотрудника меньше имени второго, метод возвращает отрицательное число, если больше - положительное число, если равны - ноль. Таким образом, при вызове метода Sort() с передачей компаратора EmployeeNameComparer, список сотрудников будет отсортирован по именам в алфавитном порядке.
        // метод же который прописан это готовый метод который сортирует по имени в алфавитном порядке. StringCompare

        Console.WriteLine();
        employees.Sort(new EmployeeExperienceComparer());

        Console.WriteLine("\n========== По опыту по убыванию ==========");
        foreach (var e in employees)
        {
            Console.WriteLine(e);
        }

        Console.WriteLine();
        employees.Sort(new EmployeeSalaryAndAgeComparer());

        Console.WriteLine("========== Зарплата по убыванию, возраст по возрастанию, имя ==========");
        foreach (var e in employees)
        {
            Console.WriteLine(e);
        }
    }
}

