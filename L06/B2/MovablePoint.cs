using System;
class MovablePoint: Movable
{
    int x, y;
    public void moveUp()
    {
        y++;
    }
    public void moveDown()
    {
        y--;
    }
    public void moveLeft()
    {
        x--;
    }
    public void moveRight()
    {
        x++;
    }
}