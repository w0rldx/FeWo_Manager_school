using System.ComponentModel.DataAnnotations;

namespace FeWo_Verwaltung_Core
{
    public abstract class User
    {
        protected string _Password;
        
        
        //Haupt-Variablen wird benötigt
        [Required] 
        public string Vorname { get; set; }
        [Required] 
        public string Nachname { get; set; }
        [Required] 
        public string Email { get; set; }
        
        //Optional
        public string Ort { get; set; }
        public int Plz { get; set; }
        public string Strasse { get; set; }
        public int Hausnummer { get; set; }
        
        
        public string Password
        {
            get => CryptoProvider.DecryptPin(_Password);
            set => _Password = CryptoProvider.EncryptPin(value);
        }

        protected User(string vorname, string nachname, string email)
        {
            Vorname = vorname;
            Nachname = nachname;
            Email = email;
        }
    }
}