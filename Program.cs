using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Carddeck
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card();
            //card.ShowValues();

            Deck deck1 = new Deck();

            //Shows them in order
            Console.WriteLine("Here's a perfectly sorted deck: ");
            deck1.ShowCards();

            Console.WriteLine();

            //Shows them in shuffled order
            Console.WriteLine("Here's a randomly shuffled deck: ");
            deck1.ShuffleCards();

            Console.ReadKey();
        }
    }
}
