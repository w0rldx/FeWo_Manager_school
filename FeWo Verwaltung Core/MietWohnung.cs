using System;
using System.Collections.Generic;

namespace FeWo_Verwaltung_Core
{
    public class MietWohnung
    {
        private List<Vermietet> _Mietliste = new List<Vermietet>();
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string Ort { get; }
        public string Strasse { get; }
        public int Plz { get; }
        public int Hausnummer { get; }
        public Vermierter Vermierter { get; }
        
        public MietWohnung(string name, string beschreibung, string ort, string strasse, int plz, int hausnummer, Vermierter vermierter)
        {
            Name = name;
            Beschreibung = beschreibung;
            Ort = ort;
            Strasse = strasse;
            Plz = plz;
            Hausnummer = hausnummer;
            Vermierter = vermierter;
        }

        public bool AddNewMietzeitraum(Vermietet v)
        {
            foreach (Vermietet vermietet in _Mietliste)
            {
                if (vermietet.Abreise != v.Abreise || vermietet.Ankunft != v.Ankunft)
                {
                    _Mietliste.Add(v);
                    return true;
                }
            }
            
            return false;
        }
        
        
    }
}