using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;

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
      // If no directory exists, create one
      if (!Directory.Exists("data"))
      {
        Directory.CreateDirectory("data");
      };

      // Create a file
      using (StreamWriter file = new StreamWriter("data/employees.csv"))
      {
        file.WriteLine("ID, Name, PhotoURL");

        for (int i = 0; i < employees.Count; i++)
        {
          string template = "{0},{1},{2}";
          file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoURL()));
        }
      }
    }
    public static void MakeBadges(List<Employee> employees)
    {
      Image newImage = Image.FromFile("badge.png");
    }
  }
}