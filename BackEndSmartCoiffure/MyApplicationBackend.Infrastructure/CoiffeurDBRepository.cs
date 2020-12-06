using MyApplicationBackend.Domain;
using MyApplicationBackend.Domain.Interface;
using System;
using System.Collections.Generic;

namespace MyApplicationBackend.Infrastructure
{
    public class CoiffeurDBRepository : InterfaceCoiffeurRepository
    {
        private readonly List<Coiffeur> Coiffeurs = new List<Coiffeur>()
        {
            new Coiffeur("Coiffeur 1", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Sfax"),

            new Coiffeur("Coiffeur 2", new DateTime(1965,05,16),"route xxx km xx","20 200 200","Homme","Sfax"),
            new Coiffeur("Coiffeur 3", new DateTime(1969,05,14),"route xxx km xx","90 900 900","Homme","Sousse"),
            new Coiffeur("Coiffeur 4", new DateTime(1969,05,14),"rue xxx Zone xx","90 900 900","Homme","Tunis"),
            new Coiffeur("Coiffeur 5", new DateTime(1965,05,16),"route xxx km xx","40 440 200","Homme","Sfax"),
            new Coiffeur("Coiffeur 6", new DateTime(1965,05,16),"route xxx km xx","50 365 200","Homme","Tunis"),
            new Coiffeur("Coiffeur 7", new DateTime(1965,05,16),"route xxx km xx","40 440 466","Homme","Sfax"),
            new Coiffeur("Coiffeur 8", new DateTime(1965,05,16),"route xxx km xx","54 440 200","Homme","Sousse"),
            new Coiffeur("Coiffeur 9", new DateTime(1965,05,16),"route xxx km xx","50 152 200","Homme","Sousse"),

            new Coiffeur("Coiffeur 2", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Sfax"),
            new Coiffeur("Coiffeur 3", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Sousse"),
            new Coiffeur("Coiffeur 4", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Tunis"),
            new Coiffeur("Coiffeur 5", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Tunis"),
            new Coiffeur("Coiffeur 6", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Tunis"),

        };

        private readonly List<Coiffeur> CoiffeursHomme = new List<Coiffeur>()
        {
            new Coiffeur("Coiffeur 2", new DateTime(1965,05,16),"route xxx km xx","20 200 200","Homme","Sfax"),
            new Coiffeur("Coiffeur 3", new DateTime(1969,05,14),"route xxx km xx","90 900 900","Homme","Sousse"),
            new Coiffeur("Coiffeur 4", new DateTime(1969,05,14),"rue xxx Zone xx","90 900 900","Homme","Tunis"),
            new Coiffeur("Coiffeur 5", new DateTime(1965,05,16),"route xxx km xx","40 440 200","Homme","Sfax"),
            new Coiffeur("Coiffeur 6", new DateTime(1965,05,16),"route xxx km xx","50 365 200","Homme","Tunis"),
            new Coiffeur("Coiffeur 7", new DateTime(1965,05,16),"route xxx km xx","40 440 466","Homme","Sfax"),
            new Coiffeur("Coiffeur 8", new DateTime(1965,05,16),"route xxx km xx","54 440 200","Homme","Sousse"),
            new Coiffeur("Coiffeur 9", new DateTime(1965,05,16),"route xxx km xx","50 152 200","Homme","Sousse"),
        };

        private readonly List<Coiffeur> CoiffeursFemme = new List<Coiffeur>()
        {
            new Coiffeur("Coiffeur 1", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Sfax"),
            new Coiffeur("Coiffeur 2", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Sfax"),
            new Coiffeur("Coiffeur 3", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Sousse"),
            new Coiffeur("Coiffeur 4", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Tunis"),
            new Coiffeur("Coiffeur 5", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Tunis"),
            new Coiffeur("Coiffeur 6", new DateTime(1996,05,13),"route xxx km xx","50 500 500","Femme","Tunis"),
        };

        List<Coiffeur> InterfaceCoiffeurRepository.GetCoiffeursList()
        {
            Console.WriteLine("**************** Read From all Coiffeur *****************");
            return Coiffeurs;
        }

        List<Coiffeur> InterfaceCoiffeurRepository.GetCoiffeursListFemme()
        {
            Console.WriteLine("**************** Read From  CoiffeursListFemme  *****************");
            return CoiffeursFemme;
        }

        List<Coiffeur> InterfaceCoiffeurRepository.GetCoiffeursListHomme()
        {
            Console.WriteLine("**************** Read From CoiffeursListHomme*****************");
            return CoiffeursHomme;
        }

    }
}
