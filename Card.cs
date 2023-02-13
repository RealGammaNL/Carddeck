using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Carddeck
{
    public class Card
    {
        public string CardValue { get; private set; }
        public string CardType { get; private set; }

        public Card(string cardValue, string cardType)
        {
            CardValue = cardValue;
            CardType = cardType;
        }

    }
}
