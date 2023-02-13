using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Carddeck
{
    public class Deck
    {
        public List<Card> cards { get; private set; } = new List<Card>();

        public Deck() 
        {
            Value values = new Value();
            CardType types = new CardType();

            foreach (string value in values.Values) 
            {
                foreach (string type in types.Types)
                {
                    cards.Add(new Card(value, type));
                }
            }

            cards.Add(new Card("Joker", "1"));
            cards.Add(new Card("Joker", "2"));
        }

        public void ShowCards()
        {
            foreach (Card card in cards) 
            {
                if (card.CardValue == "Joker")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{card.CardValue} {card.CardType}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{card.CardValue} of {card.CardType}");
                }
               
            }
        }

        public void ShuffleCards()
        {
            Random rnd = new Random();
            List<int> shuffleNumbers = new List<int>();

            for (int i = 1; i <= 54; i++) //13*4 + 2 jokers
            {
                bool added = false;
                int num = rnd.Next(1, 54); //13*4 + 2 jokers -> rnd.Next geeft een getal tussen 1,5
                while (!added)
                {
                    if (!shuffleNumbers.Contains(num))
                    {
                        shuffleNumbers.Add(num);
                        added = true;
                    }
                    else
                    {
                        num = rnd.Next(0, 54); //13*4 + 2 jokers
                    }
                }
            }

            foreach (int number in shuffleNumbers)
            {
                //Console.WriteLine(cards[number]._cardType);

                if (cards[number].CardValue == "Joker")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{cards[number].CardValue} {cards[number].CardType}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{cards[number].CardValue} of {cards[number].CardType}");
                }
            }
        }

        public void ShowValues()
        {
            Value values2 = new Value();
            foreach (string value in values2.Values)
            {
                Console.WriteLine(value);
            }
        }

        public void ShowTypes()
        {
            CardType types2 = new CardType();
            foreach (string types in types2.Types)
            {
                Console.WriteLine(types);
            }
        }



    }
}
