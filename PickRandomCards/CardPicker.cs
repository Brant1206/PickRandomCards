using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCaards)
        {
            string[] pickedCards = new string[numberOfCaards];
            for (int i = 0; i < numberOfCaards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuid();
            }
            return pickedCards;
        }

        private static string RandomSuid()
        {
            //取得1~4隨機數
            int value = random.Next(1, 5);
            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
