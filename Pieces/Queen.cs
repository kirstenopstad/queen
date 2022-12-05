using System;
// using System.Collections.Generic;

namespace Board.Pieces
{
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
}