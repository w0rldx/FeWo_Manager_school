namespace FeWo_Verwaltung_Core.Database
{
    public class SearchingParmeterMietwohnung
    {
        public string Name { get; }
        public string Beschreibung { get; }
        public string Ort { get; }

        public SearchingParmeterMietwohnung(string name, string beschreibung, string ort)
        {
            Name = name;
            Beschreibung = beschreibung;
            Ort = ort;
        }
    }
}