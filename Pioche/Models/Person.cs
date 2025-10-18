using System;

namespace Pioche
{
    public class Person
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }


        public Person(string surname, string firstname)
        {
            Surname = surname;
            Firstname = firstname;
        }

        // méthode d'affichage
        public virtual string ToString()
        {
            return $"{Firstname} {Surname}";
        }

    }
}