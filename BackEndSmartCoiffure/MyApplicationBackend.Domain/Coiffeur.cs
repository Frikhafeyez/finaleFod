using System;

namespace MyApplicationBackend.Domain
{
    public class Coiffeur
    {
        public string NameCoiffeur { get; set; }
        public DateTime BirthdateCoiffeur { get; set; }
        public string AdresseCoiffeur { get; set; }
        public string TelephoneCoiffeur { get; set; }
        public string CoiffeurPour { get; set; }
        public string CoiffeurRegion { get; set; }

        public Coiffeur(string nameCoiffeur, DateTime birthdateCoiffeur, string adresseCoiffeur, 
            string telephoneCoiffeur, string coiffeurPour, string coiffeurRegion)
        {
            NameCoiffeur = nameCoiffeur;
            BirthdateCoiffeur = birthdateCoiffeur;
            AdresseCoiffeur = adresseCoiffeur;
            TelephoneCoiffeur = telephoneCoiffeur;
            CoiffeurPour = coiffeurPour;
            CoiffeurRegion = coiffeurRegion;
        }

        public int CalculAge() 
        {
            return DateTime.Now.Year - BirthdateCoiffeur.Year;
        }
        
    }
}