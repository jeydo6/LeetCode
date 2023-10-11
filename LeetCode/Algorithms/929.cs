using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _929
    {
        public Int32 NumUniqueEmails(String[] emails)
        {
            ICollection<String> normalizedEmails = new List<String>();

            foreach (String email in emails)
            {
                Int32 atPosition = email.IndexOf('@');
                String localName = email.Substring(0, atPosition);
                String domainName = email.Substring(atPosition);

                Int32 plusPosition = localName.IndexOf('+');
                if (plusPosition >= 0)
                {
                    localName = localName.Substring(0, localName.IndexOf('+'));
                }

                localName = localName.Replace(".", "");

                String normalizedEmail = localName + domainName;
                if (!normalizedEmails.Contains(normalizedEmail))
                {
                    normalizedEmails.Add(normalizedEmail);
                }
            }

            Int32 result = normalizedEmails.Count;

            return result;
        }
    }
}
