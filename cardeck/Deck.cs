using System;
using System.Collections.Generic;
using System.Text;


namespace cardeck
{
    public class Deck
    {

        public IList<Card> FullDeck { get; private set; } = new List<Card>(52);
       
        /// <summary>
        /// Creates a full list of unique cards
        /// </summary>
        public void CreateDeck()
        {
            for (int i = 1; i <= 52; i++)
            {
                FullDeck.Add(new Card(i));
            }
        }

        /// <summary>
        /// Moves cards into a temporary variable, then moves them back in a random order
        /// </summary>
        public void Shuffle()
        {
            var cards = FullDeck;
            FullDeck = new List<Card>(52);
            var random = new Random();
            while (cards.Count != 0)
            {
                var cardIndex = random.Next(cards.Count);
                FullDeck.Add(cards[cardIndex]);
                cards.RemoveAt(cardIndex);
            }
        }
        /// <summary>
        /// Displays and removes the card at index 0
        /// </summary>
        /// <returns></returns>
        public Card Deal() 
        {
            // this is a really stupid way of doing this, but I have to make IsEmpty a method apparently
            bool empty = IsEmpty();
            if (empty == true)
            {
                Console.WriteLine("No more cards left!");
                return null;
            }

            Card dealtCard = FullDeck[0];
            Console.WriteLine(dealtCard);
            FullDeck.RemoveAt(0);
            return dealtCard;
        }
        /// <summary>
        /// Checks if the deck is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() //idk what i'm meant to do with this
        {
            return FullDeck.Count == 0; 
        }
    }
}
