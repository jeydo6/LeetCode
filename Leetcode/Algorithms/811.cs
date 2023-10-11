using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Algorithms
{
    public class _811
    {
        public IList<String> SubdomainVisits(String[] cpdomains)
        {
            IList<String> resultList = new List<String>();

            Dictionary<String, Int32> cpsubdomains = new Dictionary<String, Int32>();
            foreach (String cpdomain in cpdomains)
            {
                Int32 spacePos = cpdomain.IndexOf(' ');
                Int32 number = Convert.ToInt32(cpdomain.Substring(0, spacePos));
                String domain = cpdomain.Substring(spacePos + 1);

                String[] parts = domain
                    .Split('.');

                String subdomain = "";
                for (Int32 i = parts.Length - 1; i >= 0; i--)
                {
                    if (subdomain.Length == 0)
                    {
                        subdomain = parts[i];
                    }
                    else
                    {
                        subdomain = parts[i] + "." + subdomain;
                    }

                    if (!cpsubdomains.ContainsKey(subdomain))
                    {
                        cpsubdomains[subdomain] = number;
                    }
                    else
                    {
                        cpsubdomains[subdomain] += number;
                    }
                }
            }

            foreach (KeyValuePair<String, Int32> cpsubdomain in cpsubdomains)
            {
                resultList.Add(cpsubdomain.Value + " " + cpsubdomain.Key);
            }

            return resultList;
        }
    }
}
