using System;

namespace FeWo_Verwaltung_Core
{
    public class Vermietet
    {

        public int Id { get; set; }
        public DateTime Ankunft { get; private set; }
        public DateTime Abreise { get; private set; }

        public User Mieter { get; private set; }

        public Vermietet(DateTime ankunft, DateTime abreise)
        {
            Ankunft = ankunft;
            Abreise = abreise;
        }
        
        // Aufgrund des EFCore Frameworks wird diese Methode verwendet bei anderen Anbindungen kann darauf verzichtet werden
        public void SetMieter(User mieter)
        {
            Mieter = mieter;
        }
    }
}