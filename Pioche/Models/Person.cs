using System;

namespace Pioche.Models
{
    //générateur d'id unique


    public class Person
    {
        private static int NextId = 0;
        private static int GetNextId()
        {
            return Interlocked.Increment(ref NextId);
        }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public int ID { get; }


        public Person(string surname, string firstname)
        {
            Surname = surname;
            Firstname = firstname;
            ID = GetNextId();
        }

        // méthode d'affichage
        public virtual string GetFullName()
        {
            return $"{Firstname} {Surname}";
        }

    }
}