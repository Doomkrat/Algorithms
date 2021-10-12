using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoadToGoogle.Challenges
{
    public static class UniqueEmailAddresses
    {
        //"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com"

        public static int NumUniqueEmails(string[] emails)
        {
            var uniqueEmails = new HashSet<string>();
            foreach (string email in emails)
            {
                StringBuilder cleanEmail = new StringBuilder();

                foreach (var currChar in email)
                {
                    if (currChar == '+' || currChar == '@')
                        break;
                    if (currChar != '.')
                        cleanEmail.Append(currChar);
                }

                StringBuilder domainName = new StringBuilder();

                for (int i = email.Length - 1; i > 0; --i)
                {
                    char currChar = email[i];
                    domainName.Append(currChar);
                    if (currChar == '@')
                        break;
                }

                string domain = new string(domainName.ToString().Reverse().ToArray());
                cleanEmail.Append(domain);
                uniqueEmails.Add(cleanEmail.ToString());
            }

            return uniqueEmails.Count();
        }

        public static int numUniqueEmails(String[] emails)
        {
            // hash set to store all the unique emails
            var uniqueEmails = new HashSet<string>();

            foreach (String email in emails)
            {
                // split into two parts local and domain
                String[] parts = email.Split("@");

                // split local by '+'
                String[] local = parts[0].Split("+");

                // remove all '.', and concatenate '@' and append domain
                uniqueEmails.Add(local[0].Replace(".", "") + "@" + parts[1]);
            }

            return uniqueEmails.Count;
        }
    }
}
