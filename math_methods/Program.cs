using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(CalculateCost("Teohiuacan"));
      Console.WriteLine(CalculateCost("Taj Mahal"));
      Console.WriteLine(CalculateCost("Great Mosque"));
    }

    static string CalculateCost(string monument){
        string finalMessage = "An invalid monument was introduced.";
        if(monument == "Teohiuacan"){
            double mainBase = RectangleArea(2500, 1500);
            double semiCircularArea = CircleArea(375) / 2;
            double corner = TriangleArea(750, 500);
            double totalArea = mainBase + semiCircularArea + corner;
            double totalCost = totalArea * 180;
            finalMessage = $"The cost of the Teotihuacan city for a total area of {totalArea} square meters is {Math.Round(totalCost, 2)}";
        } else if(monument == "Great Mosque"){
            double northArea = RectangleArea(180, 106);
            double mainBase = RectangleArea(264, 284);
            double triangleCorner = TriangleArea(84, 264);
            double totalArea  = northArea + mainBase - triangleCorner;
            finalMessage = $"The total area of the Great Mosque of Mecca is {totalArea} square meters.";  
        } else if(monument == "Taj Mahal"){
            double mainBase = RectangleArea(90.5, 90.5);
            double corners = (RectangleArea(24,24) / 2) * 4;
            double totalArea = mainBase - corners;
            finalMessage = $"The total area of the Taj Mahal is {totalArea} square meters.";
        }
        return finalMessage;
    }

    static double RectangleArea(double length, double width){
      return length * width;
    }
    static double CircleArea(double radius){
      return Math.PI * Math.Pow(radius, 2);
    }
    static double TriangleArea(double bottom, double height){
      return 0.5 * bottom * height;
    }

  }
}
