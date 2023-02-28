using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carddeck
{
    public class CardType
    {
        public List<string> Types { get; set; } = new List<string>()
        {
            "Hearts", "Diamonds", "Spades", "Clubs"
        };
    }
}
