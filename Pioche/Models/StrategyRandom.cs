using System;
using System.Collections.Generic;
using System.Linq;


    namespace Pioche.Models
    {
        public class StrategyRandom : IStrategy
        {
            public StrategyRandom() { }
            public Card ChoisirCarte(List<Card> Main, Card topCard)
            {
                if (Main == null || Main.Count == 0)
                {
                    throw new ArgumentException("La main est null ou vide.");
                }
                var CartesJouables = Main.Where(c => c.Color == topCard.Color || c.Value == topCard.Value).ToList();
                if (CartesJouables.Count > 0)
                {
                    Random rand = new Random();
                    int index = rand.Next(CartesJouables.Count);
                    return CartesJouables[index];
                }
                return null; // si null il faut piocher

            }
        }
    }