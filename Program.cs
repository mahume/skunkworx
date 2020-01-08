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
        Console.WriteLine("Please enter a name:");
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        Employee currentEmployee = new Employee(input, "Hume");
        employees.Add(currentEmployee);
      };

      return employees;
    }

    static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        Console.WriteLine(employees[i].GetName());
      }
    }
  }
}
