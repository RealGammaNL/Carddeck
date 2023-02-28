using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Carddeck
{
    public class Deck
    {
        public List<Card> Cards { get; private set; } = new List<Card>();
        // ctrl + rr
        public Deck() 
        {
            Value values = new Value();
            CardType types = new CardType();

            foreach (string type in types.Types) 
            {
                foreach (string value in values.Values)
                {
                    Cards.Add(new Card(value, type));
                }
            }

            Cards.Add(new Card("Joker", "1"));
            Cards.Add(new Card("Joker", "2"));
        }

        public void ShowCards()
        {
            foreach (Card card in Cards) 
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

            for (int i = 1; i <= Cards.Count(); i++) //13*4 + 2 jokers
            {
                bool added = false;
                int num = rnd.Next(1, Cards.Count()); //13*4 + 2 jokers -> rnd.Next geeft een getal tussen 1,5
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

   
                if (Cards[number].CardValue == "Joker")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{Cards[number].CardValue} {Cards[number].CardType}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{Cards[number].CardValue} of {Cards[number].CardType}");
                }
            }
        }

        public void ShuffleCards_2()
        {
            Random rnd = new Random();
            for (int i = 0; i < Cards.Count(); i++)
            {
                int randomInt = rnd.Next(1, 54);
                Card tempCard = Cards[randomInt];
                Cards[randomInt] = Cards[i];
                Cards[i] = tempCard;
            }
        }

        public void ShuffleCards_cas()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(card => rnd.Next()).ToList();
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
