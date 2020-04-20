using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15_1.Models
{
    public class Deck
    {
        public CardContent[] cards { get; set; }
        public string deck_id { get; set; }
    }

    public class CardContent
    {
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set; }

    }
}

