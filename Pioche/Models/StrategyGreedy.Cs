using System;
using System.Collections.Generic;
using System.Linq;

namespace Pioche.Models
{
    public class StrategyGreedy : IStrategy
    {
        private static readonly Random rand = new Random();

        public Card ChoisirCarte(List<Card> Main, Card topCard)
        {
            if (Main == null || Main.Count == 0)
                throw new ArgumentException("La main est null ou vide.");

            int CoeurCount = Main.Count(c => c.Color == CardColor.Coeur);
            int CarreauCount = Main.Count(c => c.Color == CardColor.Carreau);
            int PiqueCount = Main.Count(c => c.Color == CardColor.Pique);
            int TrefleCount = Main.Count(c => c.Color == CardColor.Trèfle);

            var CartesJouables = Main.Where(c => c.Color == topCard.Color || c.Value == topCard.Value || (int)c.Value == 11).ToList();

            if (CartesJouables.Count == 0)
                return null; // piocher si aucune carte jouable

            // Priorité : jouer un 2 si topCard est un 2
            if ((int)topCard.Value == 2)
            {
                var CartesDeux = CartesJouables.Where(c => (int)c.Value == 2).ToList();
                if (CartesDeux.Count == 1)
                    return CartesDeux[0];
                else if (CartesDeux.Count > 1)
                {
                    // choisir le 2 de la couleur la plus présente
                    return CartesDeux.OrderByDescending(c => 
                        c.Color == CardColor.Coeur ? CoeurCount :
                        c.Color == CardColor.Carreau ? CarreauCount :
                        c.Color == CardColor.Pique ? PiqueCount :
                        c.Color == CardColor.Trèfle ? TrefleCount : 0
                    ).First();
                }
            }

            // Sinon : choisir la carte avec la valeur la plus élevée
            Card meilleureCarte = CartesJouables.OrderByDescending(c => (int)c.Value).First();
            var meilleureCarteJouable = CartesJouables.Where(c => c.Value == meilleureCarte.Value).ToList();

            if (meilleureCarteJouable.Count == 1)
                return meilleureCarteJouable[0];

            // Si plusieurs cartes ont même valeur : choisir celle de la couleur la plus présente
            return meilleureCarteJouable.OrderByDescending(c =>
                c.Color == CardColor.Coeur? CoeurCount :
                c.Color == CardColor.Carreau? CarreauCount :
                c.Color == CardColor.Pique? PiqueCount :
                c.Color == CardColor.Trèfle? TrefleCount : 
            ).First();
        }
    }
}
