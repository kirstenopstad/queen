using System;
// using System.Collections.Generic;

public class Queen
{
  public int XPos;
  public int YPos;
  public bool AttackSuccess;
  
  // Constructor
  public Queen(int xPos, int yPos)
  {
    XPos = xPos;
    YPos = yPos;
    AttackSuccess = false;   
  }

  public void Attackable(int x2, int y2)
  {
    float fX2 = x2;
    float fY2 = y2;
    
    if (XPos == x2 || YPos == y2)
    {
    AttackSuccess = true;
    }
    else if (Math.Abs((fY2 - YPos)/(fX2 - XPos)) == 1)
    {
    AttackSuccess = true;
    }
    }  
}


public class Program
{
  static void Main()
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

