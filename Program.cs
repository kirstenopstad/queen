using System;
using Board.Pieces;

namespace Board
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your X coordinate");
      int xPos = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter your Y coordinate");
      int yPos = int.Parse(Console.ReadLine());
      Queen playerQueen = new Queen(xPos, yPos);
      Console.WriteLine("Enter the enemy X coordinate");
      int xPos2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the enemy Y coordinate");
      int yPos2 = int.Parse(Console.ReadLine());
      // Check for PP attackability
      playerQueen.Attackable(xPos2, yPos2);
      // Print results
      if (playerQueen.AttackSuccess == true)
      {
        Console.WriteLine("Attack possible!");
      }
      else
      {
        Console.WriteLine("Impossible! Try again.");
      }
    }
  }
}  