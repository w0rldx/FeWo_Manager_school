namespace FeWo_Verwaltung_Core
{
    public class MietWohnung
    {
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
    }
}