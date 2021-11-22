using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 
  		// Rover[] myRovers = {lunokhod, apollo, sojourner};
      // DirectAll(myRovers);

      // Object[] myProbes = { lunokhod, apollo, sojourner, sputnik };
      // foreach(Object probe in myProbes){
      //   Console.WriteLine($"Tracking a {probe.GetType()}");
      // }

      IDirectable[] directables = { lunokhod, apollo, sojourner, sputnik };
      DirectAll(directables);
    }

    // This is a previous method before using interfaces.
    // public static void DirectAll(Rover[] rovers){
    //   foreach(Rover rover in rovers) {
    //     Console.WriteLine(rover.GetInfo());
    //     Console.WriteLine(rover.Explore());
    //     Console.WriteLine(rover.Collect());
    //   }

    public static void DirectAll(IDirectable[] directables) {
      foreach(IDirectable d in directables) {
        Console.WriteLine(d.GetInfo());
        Console.WriteLine(d.Explore());
        Console.WriteLine(d.Collect());
      }
    }
  }
}
