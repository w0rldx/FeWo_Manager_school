using System.Collections.Generic;
using System.Data.Common;
using FeWo_Verwaltung_Core.Database;
using FeWo_Verwaltung_Core.Database.DatenQuellen;

namespace FeWo_Verwaltung_Core
{
    public class Vermierter : User
    {
        private List<MietWohnung> _MietWohnungsList = new List<MietWohnung>();

        public Vermierter(string vorname, string nachname, string email) : base(vorname, nachname, email)
        {
        }

        //TODO:Aktuell nicht unabänig von Datenquelle 19.10.2020 Author: W0rlD
        public void AddMietwohnung(MietWohnung m)
        {
            using (var ef = new EfDataSource())
            {
                ef.AddMietWohnungToDataSource(m);
            }
        }
    }
}