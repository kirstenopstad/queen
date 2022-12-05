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

  public void attackable(int x2, int y2)
  {
    float fX2 = x2;
    float fY2 = y2;
    float pX1 = XPos;
    float pY1 = YPos;

    Console.WriteLine(fY2, pY1, fX2, pX1);
    if (XPos == x2 || YPos == y2 || ((fY2 - pY1)/(fX2 - pX1) == 1))
    {
    AttackSuccess = true;
    // return AttackSuccess;
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
    playerQueen.attackable(xPos2, yPos2);
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

