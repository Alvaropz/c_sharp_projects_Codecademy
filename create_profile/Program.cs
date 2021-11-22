using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
      // sam.SetHobbies(new string[] {"listening to music", "playing video games", "suck people's blood"});
      Console.WriteLine(sam.ViewProfile());
    }
  }
}
