using System;
using System.Collections.Generic;
using System.Linq;


namespace Pioche.Models
{
    public class Player : Person
    {
        public List<Card> main = new List<Card>();

        public IStrategy? Strategy { get; set; }
        public Player(string surname, string firstname, int ID) : base(surname, firstname)
        {Strategy = new StrategyRandom();}

        // méthode d'affichage
        public override string ToString()
        {
            return $"Player {ID}: {Firstname} {Surname}";
        }
        public void DrawCard(Card card)
        {
            main.Add(card);
        }
        public void PlayCard(Card card)
        {
            main.Remove(card);
        }
        public bool HasPlayableCard(Card Card)
        {
            foreach (Card card in main)
            {
                if (card.Color == Card.Color || card.Value == Card.Value)
                {
                    return true;
                }
            }
            return false;
        }
        public void JouerTour(Card TopCard, Pile PillePioche)
        {
            if (Strategy == null)
            {
                throw new InvalidOperationException("Le jour n'as pas de stratégie");
            }
            card? =  CarteChoisie = Strategy.ChoisirCarte(main, TopCard);
            if (CarteChoisie != null)
            {
                PlayCard(CarteChoisie);
                Debug.WriteLine($"{this} joue le {CarteChoisie}");
            }
            if(CarteChoisie == null)
            {
                Card piocheCard = PillePioche.DrawCard();
                DrawCard(piocheCard);
                Debug.WriteLine($"{this} pioche un {piocheCard}");
            }
        }

        public int CalculateScore()
        {
            int score = 0;
            foreach (Card card in main)
            {
                if ((int)card.Value == 1)
                {
                    score += 11;
                    continue;
                }
                if ((int)card.Value == 11 || (int)card.Value == 12 || (int)card.Value == 13)
                {
                    score += 2;
                    continue;
                }
                else
                {
                    score += (int)card.Value;
                    continue;
                }
            }
            return score;
        }

    
    }
}