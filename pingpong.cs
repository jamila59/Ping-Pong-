using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter any number");
    int userNum = int.Parse(Console.ReadLine());

    for (int i = 1; i <= userNum; i++)
    {
      if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("Ping-Pong");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}
