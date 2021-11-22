using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
       Console.Write("How much money would like to calculate? Give me an amount in cents...: ");
      string amountString = Console.ReadLine();
      double amount = Convert.ToDouble(amountString);
      Console.WriteLine($"{amountString} is equal to...");
      int gold = 10;
      int silver = 5;
      double goldCoins = Math.Floor(amount / gold);
      amount = amount % gold;
      double silverCoins = Math.Floor(amount / silver);
      int remainder = Convert.ToInt32(amount % silver);
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {remainder}");
    }
  }
}
