using System;
using System.Collections.Generic;

namespace cardeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.CreateDeck();
            deck.Shuffle();
            // displays order of deck post-shuffle, just to prove it works
            foreach (var item in deck.FullDeck)
            {
                Console.WriteLine($"ID = {item.CardId} name = {item.Name}");
            }
            deck.Deal();
        }
    }
}
