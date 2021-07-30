using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _999
    {
        public Int32 NumRookCaptures(Char[][] board)
        {
            Int32 result = 0;

            Int32 rx = -1;
            Int32 ry = -1;

            for (Int32 i = 0; i < board.Length; i++)
            {
                for (Int32 j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        rx = i;
                        ry = j;
                    }
                }
            }

            if (rx > -1 && ry > -1)
            {
                Int32 i = -1;
                Int32 j = -1;

                i = rx - 1;
                while (i > 0)
                {
                    if (board[i][ry] != '.')
                    {
                        if (board[i][ry] == 'p')
                        {
                            result++;
                        }
                        break;
                    }
                    i--;
                }
                i = rx + 1;
                while (i < board.Length)
                {
                    if (board[i][ry] != '.')
                    {
                        if (board[i][ry] == 'p')
                        {
                            result++;
                        }
                        break;
                    }
                    i++;
                }

                j = ry - 1;
                while (j > 0)
                {
                    if (board[rx][j] != '.')
                    {
                        if (board[rx][j] == 'p')
                        {
                            result++;
                        }
                        break;
                    }
                    j--;
                }
                j = ry + 1;
                while (j < board[rx].Length)
                {
                    if (board[rx][j] != '.')
                    {
                        if (board[rx][j] == 'p')
                        {
                            result++;
                        }
                        break;
                    }
                    j++;
                }
            }

            return result;
        }
    }
}
