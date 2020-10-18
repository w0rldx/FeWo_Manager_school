using System.Collections.Generic;
using FeWo_Verwaltung_Core.Database;

namespace FeWo_Verwaltung_Core
{
    public class Vermierter : User
    {
        private List<MietWohnung> _MietWohnungsList = new List<MietWohnung>();

        public Vermierter(string vorname, string nachname, string email) : base(vorname, nachname, email)
        {
        }

        public void AddMietwohnung(MietWohnung m)
        {
            
        }
    }
}