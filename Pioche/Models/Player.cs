using System;
using System.Threading;

namespace Pioche
{
    public class Player : Person 
    {
    //générateur d'id unique
    private static int NextId = 0;
    private static int GetNextId()
        {
            return Interlocked.Increment(ref NextId);
        }
    public int ID { get; }

    public Player(string surname, string firstname) : base(surname, firstname)
        {
            ID = GetNextId();
        }

        // méthode d'affichage
        public override string ToString()
        {
            return $"Player {ID}: {Firstname} {Surname}";
        }   
    
    }
}