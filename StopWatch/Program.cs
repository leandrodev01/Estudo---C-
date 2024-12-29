
using System;
namespace StopWatch
{
  class Program 
  {
    static void Main(string[] args) 
    {
      Menu();
      
    }

    static void Menu() 
    {
      Console.Clear();
      Console.WriteLine("S - Segundo => 10s = 10 segundos");
      Console.WriteLine("M - Minuto 1m = 1 minuto");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("Escolha o formato ");

      string data = Console.ReadLine() .ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time  = int.Parse(data.Substring(0,data.Length-1));
      int multiplier = 1;

      if (type == 'm')
        multiplier = 60;
      
      if (time == 0)
        System.Environment.Exit(0);

      PreStart(time * multiplier);
    }

    static void  PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Preparando para iniciar...");
      Thread.Sleep(2000); // Simula 2 segundos

      Start(time);
    }
    static void  Start (int time)
    {
      int currentTime = 0;
      
      while (currentTime != time) 
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine("" + currentTime);
        Thread.Sleep(1000); // Simula 1 segundo
      }

      Console.Clear();
      Console.WriteLine("StopWatch finalizado");
      Thread.Sleep(1000);
      Menu();
    }
  }
  
}