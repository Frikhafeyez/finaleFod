using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplicationBackend.Domain.Interface
{
    public interface InterfaceCoiffeurRepository
    {
        List<Coiffeur> GetCoiffeursList();
        List<Coiffeur> GetCoiffeursListFemme();
        List<Coiffeur> GetCoiffeursListHomme();
    }
}
