using System;

class Program {
  public static void Main (string[] args) {
    InvertValues(5,4);
    
  }

  public static void InvertValues(int a , int b){
    a = a + b;
    b = a - b;
    a = a - b;

    Console.WriteLine("A: " + a + " \nB: " + b);
    
    
  }
}