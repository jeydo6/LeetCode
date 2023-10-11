using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _682
    {
        public Int32 CalPoints(String[] ops)
        {
            Stack<Int32> points = new Stack<Int32>();
            points.Push(0);
            points.Push(0);

            foreach (String op in ops)
            {
                switch(op)
                {
                    case "+":
                        {
                            Int32 value1 = points.Pop();
                            Int32 value2 = points.Pop();
                            Int32 value = value1 + value2;

                            points.Push(value2);
                            points.Push(value1);
                            points.Push(value);

                            break;
                        }
                    case "D":
                        {
                            Int32 value1 = points.Pop();
                            Int32 value = value1 * 2;

                            points.Push(value1);
                            points.Push(value);

                            break;
                        }
                    case "C":
                        {
                            Int32 value1 = points.Pop();

                            break;
                        }
                    default:
                        {
                            if (Int32.TryParse(op, out Int32 value))
                            {
                                points.Push(value);
                            }

                            break;
                        }
                }
            }

            Int32 sum = 0;
            while (points.Count > 0)
            {
                sum += points.Pop();
            }

            return sum;
        }
    }
}
