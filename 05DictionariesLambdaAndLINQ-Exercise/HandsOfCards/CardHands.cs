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
            Dictionary<string, string> playersAndHands = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string[] inputArr = input.Split(':').ToArray();
                string name = inputArr[0];
                string cards = inputArr[1];

                if (playersAndHands.ContainsKey(name))
                {
                    playersAndHands[name] += cards;
                }
                else
                {
                    playersAndHands[name] = cards;
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> cardType = new Dictionary<string, int>();
            cardType["S"] = 4; //Spades
            cardType["H"] = 3; //Hearts
            cardType["D"] = 2; //Diamonds
            cardType["C"] = 1; //Clubs

            Dictionary<string, int> cardPower = new Dictionary<string, int>();
            cardPower["1"] = 1;
            cardPower["2"] = 2;
            cardPower["3"] = 3;
            cardPower["4"] = 4;
            cardPower["5"] = 5;
            cardPower["6"] = 6;
            cardPower["7"] = 7;
            cardPower["8"] = 8;
            cardPower["9"] = 9;
            cardPower["10"] = 10;
            cardPower["J"] = 11;
            cardPower["Q"] = 12;
            cardPower["K"] = 13;
            cardPower["A"] = 14;

            Dictionary<string, int> playerFinalResult = new Dictionary<string, int>();

            foreach (var player in playersAndHands)
            {
                //Console.WriteLine($"{player.Key} -> {string.Join(" ", player.Value)}");

                string[] playersCardsStr = player.Value.Split(',', ' ').Where(c => c != "").Distinct().ToArray();
                int result = 0;
                for (int i = 0; i < playersCardsStr.Length; i++)
                {
                    string power = playersCardsStr[i].Substring(0, playersCardsStr[i].Length - 1);
                    string type = playersCardsStr[i].Substring(playersCardsStr[i].Length - 1);

                    result += cardPower[power] * cardType[type];

                }
                playerFinalResult.Add(player.Key, result);
            }

            foreach (var result in playerFinalResult)
            {
                Console.WriteLine($"{result.Key}: {result.Value}");
            }
        }
    }
}
