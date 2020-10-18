namespace FeWo_Verwaltung_Core.Database
{
    public class SearchingParmeterUser
    {
        public string Vorname { get; }
        public string Nachname { get; }
        public string Email { get; }
        
        //Optional
        public string Ort { get; } 
        public int Plz { get; }
        public string Strasse { get; }
        public int Hausnummer { get; }

        public SearchingParmeterUser(string vorname = null, string nachname = null, string email = null, string ort = null, int plz = default, string strasse = null, int hausnummer = default)
        {
            Vorname = vorname;
            Nachname = nachname;
            Email = email;
            Ort = ort;
            Plz = plz;
            Strasse = strasse;
            Hausnummer = hausnummer;
        }
    }
}