using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_DeckOfCards.Classes
{
    class Cards
    {

        public Suits Suits { get; set; }
        public string FaceCards { get; set; }
        public int SuitNumber { get; set; }

    }

    enum Suits
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    
}
