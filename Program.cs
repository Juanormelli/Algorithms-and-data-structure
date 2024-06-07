using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Algrt
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] ints = { 1, 2, 3, 4, 5 };

      Console.WriteLine(soma(ints));
      Console.WriteLine(count(ints));

      Console.ReadLine();
    }
    public static int soma(int[] arr) // Divisao e conquista simples 

    {

      if (arr.Length == 0)
      {
       
        return 0;
      }
      else
      {
        
        int[] newArr = arr.Where(val => val != arr[0]).ToArray();
        //Console.WriteLine(arr[0]);

        return arr[0] + soma(newArr);
      }

    }
    public static int count(int[] arr)
    {
      if (arr.Length == 0)
      {

        return 0;
      }
      else
      {

        int[] newArr = arr.Where(val => val != arr[0]).ToArray();
        //Console.WriteLine(arr[0]);

        return 1 + count(newArr);
      }
    }
  }
}

