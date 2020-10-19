using System;
using System.Collections.Generic;

namespace FeWo_Verwaltung_Core
{
    public class Mieter : User
    {
        private List<MietWohnung> _GemieteteObjekte = new List<MietWohnung>(); 
        public Mieter(string vorname, string nachname, string email) : base(vorname, nachname, email)
        {
        }

        public void MieteMietWohnung(MietWohnung m, DateTime ankunft, DateTime abreise)
        {
            m.AddNewMietzeitraum(new Vermietet(ankunft, abreise, this));
        }
    }
}