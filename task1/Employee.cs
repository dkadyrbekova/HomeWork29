using System.Security.Cryptography.X509Certificates;

namespace Task1;

public class Employee : IComparable<Employee>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public int Experience { get; set; }
    public Employee(int id, string name, int age, decimal salary, int experience)
    {
        Id = id;
        Name = name;
        Age = age;
        Salary = salary;
        Experience = experience;
    }
    //public override string ToString()
    //{
    //    //return Id.ToString() + " " + Name + " " + Age.ToString() + " " + Salary.ToString() + " " + Experience.ToString();
    //    //return base.ToString();
    //}
    public int   CompareTo(Employee other)
    {
        if (this.Salary > other.Salary)
        {
            return 1;
        }
        else if (this.Salary < other.Salary)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
        public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, Experience: {Experience}";

    }
}