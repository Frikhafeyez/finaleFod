using MyApplicationBackend.Domain;
using MyApplicationBackend.Domain.Interface;
using System;
using System.Collections.Generic;

namespace BackEndSmartCoiffure
{
    public class CoiffureXMLRepository : InterfaceCoiffeurRepository
    {
        private readonly List<Coiffeur> Coiffeurs = new List<Coiffeur>()
        {
            new Coiffeur("Coiffeur 1", new DateTime(1996,05,13),"","","",""),
            new Coiffeur("Coiffeur 2", new DateTime(1965,05,16),"","","",""),
            new Coiffeur("Coiffeur 3", new DateTime(1969,05,14),"","","","")
        };

        public List<Coiffeur> GetCoiffeursList()
        {
            Console.WriteLine("**************** Read From xml *****************");
            return Coiffeurs;
        }

   
        List<Coiffeur> InterfaceCoiffeurRepository.GetCoiffeursListFemme()
        {
            throw new NotImplementedException();
        }

        List<Coiffeur> InterfaceCoiffeurRepository.GetCoiffeursListHomme()
        {
            throw new NotImplementedException();
        }
    }
}