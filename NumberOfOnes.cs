using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
  class Program
  {
    static void Main (string [] args)
    {
      int m ,count = 0;
      Console.WriteLine("Enter the limit : ");
      m = int.Parse(Console.ReadLine());
      int [] a = new int [m];
      Console.WriteLine("Enter the numbers : ");
      for (int i = 0 ;i < m; i++)
      {
        a[i] = Convert.ToInt32(Console.ReadLine());
      }
      foreach (int o in a){
        if (o == 1)
        {
          count++;
        }
      }
      Console.WriteLine("Number of 1's in the Entered Number : ");
      Console.WriteLine(count);
      Console.ReadLine();
    }
  }
}
