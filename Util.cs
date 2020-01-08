using System;
using System.Collections.Generic;
using System.IO;

namespace SkunkWorx
{
  class Util
  {
    public static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoURL()));
      }
    }

    public static void MakeCSV(List<Employee> employees)
    {
      if (!Directory.Exists("data")
      {
        Directory.CreateDirectory("data");
      }
    }
  }
}