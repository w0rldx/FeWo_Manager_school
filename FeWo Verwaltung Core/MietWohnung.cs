using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FeWo_Verwaltung_Core
{
    public class MietWohnung
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Beschreibung { get; set; }
        [Required]
        public string Ort { get; private set; }
        [Required]
        public string Strasse { get;  private set; }
        [Required]
        public int Plz { get; private set; }
        [Required]
        public int Hausnummer { get; private set; }
        [Required]
        public Vermierter Vermierter { get; private set; }

        public List<Vermietet> Mietliste { get; set; } = new List<Vermietet>();
        
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


        public MietWohnung(string name, string beschreibung, string ort, string strasse, int plz, int hausnummer)
        {
            Name = name;
            Beschreibung = beschreibung;
            Ort = ort;
            Strasse = strasse;
            Plz = plz;
            Hausnummer = hausnummer;
        }

        // Aufgrund des EFCore Frameworks wird diese Methode verwendet bei anderen Anbindungen kann darauf verzichtet werden
        public void SetzeVermieter(Vermierter vermierter)
        {
            Vermierter = vermierter;
        }

        public bool AddNewMietzeitraum(Vermietet v)
        {
            foreach (Vermietet vermietet in Mietliste)
            {
                if (vermietet.Abreise != v.Abreise || vermietet.Ankunft != v.Ankunft)
                {
                    Mietliste.Add(v);
                    return true;
                }
            }
            
            return false;
        }
        
        
    }
}