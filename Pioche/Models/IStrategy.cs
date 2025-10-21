using System; 

namespace Pioche.Models
{
    public interface IStrategy
    {
        Card ChoisirCarte(List<Card> Main, Card topCard);
    }



}