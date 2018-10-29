using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_DeckOfCards.Classes
{
    class Deck<T>
    {
        T[] cards = new T[12];
        int count = 0;

        public void Add(T card)
        {
            if(count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length + 1);
            }
            cards[count++] = card;
        }

        public void RemoveCard(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length - 1);
            }
            cards[count--] = card;
        }

        public void DisplaySuit(T card)
        {

        }
    }
}
