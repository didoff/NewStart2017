using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixMails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> personalInfo = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                string domain = email.Substring(email.Length - 2, 2).ToLower(); // ToLower only for DOMAIN !!!

                if (domain != "uk" && domain != "us")
                {
                    personalInfo[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var pair in personalInfo)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
