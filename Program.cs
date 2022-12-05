using System;
using Board.Pieces;

namespace Board
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("What piece would you like to test?");
      string response = Console.ReadLine();
      Console.WriteLine("Enter your X coordinate");
      int xPos = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter your Y coordinate");
      int yPos = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the enemy X coordinate");
      int xPos2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the enemy Y coordinate");
      int yPos2 = int.Parse(Console.ReadLine());
      if (response == "Queen")
      {
        Queen playerQueen = new Queen(xPos, yPos);
        playerQueen.Attackable(xPos2, yPos2);
        Console.WriteLine("This is a possible attack: " + playerQueen.AttackSuccess);
      }
      else 
      {
        King playerKing = new King(xPos, yPos);
        playerKing.Attackable(xPos2, yPos2);
        Console.WriteLine("This is a possible attack: " + playerKing.AttackSuccess);
      }
      // Print results
      // if (playerQueen.AttackSuccess == true || playerKing.AttackSuccess == true)
      // {
      //   Console.WriteLine("Attack possible!");
      // }
      // else
      // {
      //   Console.WriteLine("Impossible! Try again.");
      // }
    }
  }
}  