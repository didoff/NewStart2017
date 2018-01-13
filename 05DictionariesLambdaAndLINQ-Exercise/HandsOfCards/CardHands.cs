using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class CardHands
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> playersAndHands = new Dictionary<string, string[]>();

            string[] input = Console.ReadLine().Split(':').ToArray();
            string name = input[0];
            string[] cards = input[1].Split(',').Where(c => c != "").ToArray();

            while(true)
            {
                playersAndHands.Add(name, cards);

                input = Console.ReadLine().Split(':').ToArray();
                name = input[0];
                if (name == "JOKER")
                {
                    break;
                }
                cards = input[1].Split(',').Where(c => c != "").ToArray();
            }

            foreach (var player in playersAndHands)
            {
                Console.WriteLine($"{player.Key} -> {string.Join(" ", player.Value)}");
            }
        }
    }
}
