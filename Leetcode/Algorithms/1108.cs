using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _1108
    {
        public String DefangIPaddr(String address)
        {
            StringBuilder sb = new StringBuilder(address, 24);

            sb.Replace(".", "[.]");

            return sb.ToString();
        }
    }
}