using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = new string[] {"Is chuchi the best dog in the world?", "Is Hermione a character from Harry Potter?", "Is Madrid the capital of Spain?", "Are puzzles interesting?"};
      bool[] answers = new bool[] {true, true, true, true};
      bool[] responses = new bool[answers.Length];
      if (answers.Length != responses.Length) {
        Console.WriteLine("WARNING! Arrays length is not the same!");
      }
      int askingIndex = 0;
      string input;
      bool isBool;
      bool inputBool;
      foreach(string question in questions){
        do {
          Console.WriteLine(question);
          Console.WriteLine("True or False?");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
          if (isBool == true) {
            responses[askingIndex] = inputBool;
            askingIndex++;
          }
        } while(isBool == false);
      }
      int score = 0;
      for(int i = 0; i < answers.Length; i++){
        Console.WriteLine($"For the question {i+1} the right answer is {answers[i]} and your answer is {responses[i]}");
        if(answers[i] == responses[i]){
          score++;
        }
      }
      Console.WriteLine($"You got {score} out of {answers.Length} correct!");
    }
  }
}