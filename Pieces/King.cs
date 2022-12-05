using System;

namespace Board.Pieces 
{
  public class King
  {
    public int XPos;
    public int YPos;
    public bool AttackSuccess = false;

    // Constructor
    public King(int xPos, int yPos)
    {
      XPos = xPos;
      YPos = yPos;
      AttackSuccess = false;
    }

    public void Attackable(int x2, int y2)
    {
      if (Math.Abs(YPos - y2) == 1 || Math.Abs(XPos - x2) == 1)
      {
      AttackSuccess = true;
      }    
      else if (Math.Abs(YPos - y2) == 1 && Math.Abs(XPos - x2) == 1)
      {
      AttackSuccess = true;
      }
    }
  
  }
}