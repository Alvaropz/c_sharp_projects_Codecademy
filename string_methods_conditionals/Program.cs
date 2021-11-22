using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Do you want to build your own creature or print a random one? 1: Customize creature. 2: Random. --> ");
      string answer = Console.ReadLine();
      int answerNum = Int32.Parse(answer);
      if(answerNum == 1){
        Console.Write("What creature part would you like for the head? Ghost, Bug, Monster. --> ");
        string headAns = Console.ReadLine();
        Console.Write("What creature part would you like for the body? Ghost, Bug, Monster. --> ");
        string bodyAns = Console.ReadLine();
        Console.Write("What creature part would you like for the feet? Ghost, Bug, Monster. --> ");
        string feetAns = Console.ReadLine();
        BuildACreature(headAns, bodyAns, feetAns);
      } else if(answerNum == 2){
        RandomMode();
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }

    static void BuildACreature(string head, string body, string feet){
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);
      SwitchCase(headNum, bodyNum, feetNum);
    }

    static void RandomMode(){
      Random randomNumber = new Random();
      int headNum = randomNumber.Next(1, 4);
      int bodyNum = randomNumber.Next(1, 4);
      int feetNum = randomNumber.Next(1, 4);
      SwitchCase(headNum, bodyNum, feetNum);
    }

    static void SwitchCase(int head, int body, int feet){
      switch(head){
        case 1:
          GhostHead();
          break;
        case 2:
          BugHead();
          break;
        case 3:
          MonsterHead();
          break;
      }
      switch(body){
        case 1:
          GhostBody();
          break;
        case 2:
          BugBody();
          break;
        case 3:
          MonsterBody();
          break;
      }
      switch(feet){
        case 1:
          GhostFeet();
          break;
        case 2:
          BugFeet();
          break;
        case 3:
          MonsterFeet();
          break;
      }
    }

    static int TranslateToNumber(string creature){
      switch(creature){
        case "ghost":
          return 1;
        case "bug":
          return 2;
        case "monster":
          return 3;
        default:
          return 1;
      }
    }
  }
}
