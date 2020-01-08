﻿using System;
using System.Collections.Generic;

namespace SkunkWorx
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> employees = GetEmployees();
      PrintEmployees(employees);
    }

    static List<string> GetEmployees()
    {
      List<string> employees = new List<string>();
      Console.WriteLine("(Press enter w/o a name to exit)");

      while (true)
      {
        Console.WriteLine("Please enter a name:");
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        Employee currentEmployee = new Employee();
        employees.Add(input);
      };

      return employees;
    }

    static void PrintEmployees(List<string> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        Console.WriteLine(employees[i]);
      }
    }
  }
}
