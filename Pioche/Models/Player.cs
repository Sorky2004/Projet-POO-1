using System;
using System.Threading;

namespace Pioche.Models
{
    public class Player : Person
    {
        List<Card> main = new List<Card>();
        public Player(string surname, string firstname, int ID) : base(surname, firstname)
        {        }

        // méthode d'affichage
        public override string ToString()
        {
            return $"Player {ID}: {Firstname} {Surname}";
        }
        public void DrawCard(Card card)
        {
            main.Add(card);
        }
        public void PlayCard(Card TopCard)
        {
            main.Remove(TopCard);
        }
        public bool HasPlayableCard(Card TopCard)
        {
            foreach (Card card in main)
            {
                if (card.Color == TopCard.Color || card.Value == TopCard.Value)
                {
                    return true;
                }
            }
            return false;
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