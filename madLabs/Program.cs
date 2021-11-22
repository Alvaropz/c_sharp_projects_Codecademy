using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program Mad Labs
      Author: Álvaro
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Mad Labs is starting...");

      // Give the Mad Lib a title:
      string title = "'The sweeteest sweetener'";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();
      Console.Write("Give me an adjective: ");
      string adjectiveOne = Console.ReadLine();
      Console.Write("Give me other adjective: ");
      string adjectiveTwo = Console.ReadLine();
      Console.Write("Give me a last adjective: ");
      string adjectiveThree = Console.ReadLine();
      Console.Write("Give me one animal: ");
      string animal = Console.ReadLine();
      Console.Write("Give me one dish or food: ");
      string food = Console.ReadLine();
      Console.Write("Give me a verb: ");
      string verbOne = Console.ReadLine();
      Console.Write("Give me one superhero name: ");
      string superhero = Console.ReadLine();
      Console.Write("Give me one place name: ");
      string place = Console.ReadLine();
      Console.Write("Give me a year: ");
      string year = Console.ReadLine();
      Console.Write("Give me two nouns. When you have wroten the first one, print enter and the program will allow you to enter the second one: ");
      string nounOne = Console.ReadLine();
      string nounTwo = Console.ReadLine();
      Console.Write("Give me a dessert: ");
      string dessert = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of  {animal}s were protesting to keep {food} in stores. They began to _ to the rhythm of the {verbOne}, which made all the {nounOne}s very {adjectiveThree}. Concerned, {name} texted {superhero}, who flew {name} to {place} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";
      // Print the story:
      Console.WriteLine(story);

    }
  }
}
