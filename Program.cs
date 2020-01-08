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

      while (true)
      {
        Console.WriteLine("Please enter a name:");
        Console.WriteLine("(Press enter w/o a name to exit)");
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
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