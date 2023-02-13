using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carddeck
{
    public class Value
    {
        public List<string> Values { get; private set; } = new List<string>();

        public Value() 
        {
            // Initialising values.
            for (int i = 1; i <= 10; i++)
            {
                Values.Add($"{i}");
            }
            Values.Add("Jack");
            Values.Add("King");
            Values.Add("Queen");


        }
    }
}
