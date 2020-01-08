using System;
using System.Collections.Generic;

namespace SkunkWorx
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = GetEmployees();
      PrintEmployees(employees);
    }

    static List<Employee> GetEmployees()
    {
      Console.WriteLine("(Press enter w/o a name to exit)");

      List<Employee> employees = new List<Employee>();

      while (true)
      {
        Console.WriteLine("Enter first name:");
        string firstName = Console.ReadLine();
        if (firstName == "")
        {
          break;
        }
        Console.WriteLine("Enter last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Id:");
        int id = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter photo URL:");
        string photoUrl = Console.ReadLine();

        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        employees.Add(currentEmployee);
      };

      return employees;
    }

    static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoURL()));
      }
    }
  }
}
