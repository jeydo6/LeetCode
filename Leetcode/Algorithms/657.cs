using System;

public class _657
{
    public Boolean JudgeCircle(String moves)
    {
        (Int32 x, Int32 y) coordinates = (0, 0);

        foreach (Char move in moves)
        {
            switch (Char.ToLower(move))
            {
                case 'u':
                {
                    coordinates.y += 1;
                    break;
                }
                case 'd':
                {
                    coordinates.y -= 1;
                    break;
                }
                case 'r':
                {
                    coordinates.x += 1;
                    break;
                }
                case 'l':
                {
                    coordinates.x -= 1;
                    break;
                }
            }
        }
        
        return coordinates.x == 0 && coordinates.y == 0;
    }
}