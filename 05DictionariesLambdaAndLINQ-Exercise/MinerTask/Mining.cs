using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Mining
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> mining = new Dictionary<string, decimal>();

            while(true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                    break;

                decimal quantity = decimal.Parse(Console.ReadLine());

                if (mining.ContainsKey(resource))
                {
                    mining[resource] += quantity;
                }
                else
                {
                    mining[resource] = quantity;
                }

            }

            foreach (KeyValuePair<string, decimal> resourceQ in mining)
            {
                Console.WriteLine($"{resourceQ.Key} -> {resourceQ.Value}");
            }
        }
    }
}
