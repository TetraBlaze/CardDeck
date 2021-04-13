using System;
using System.Collections.Generic;
using System.Text;

namespace cardeck
{
    public class Card
    {
        private int _cardId;
        public int CardId => _cardId;
        public string Suit => ((_cardId - 1) / 13) switch { 0 => "Hearts", 1 => "Clubs", 2 => "Diamonds", _ => "Spades" };
        public int Value => ((_cardId - 1) % 13) + 1;
        public string Name //generated based on card ID
        {
            get
            {
                var name = Value switch { 1 => "Ace", 11 => "Jack", 12 => "Queen", 13 => "King", _ => Value.ToString() };
                return $"{name} of {Suit}";
            }
        }

        public Card(int cardId)
        {
            if (cardId < 1 || cardId > 52)
                throw new ArgumentOutOfRangeException(nameof(cardId), "Expecting 1 - 52");
            _cardId = cardId;
        }
    }
}
