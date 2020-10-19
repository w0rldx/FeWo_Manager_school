using System;

namespace FeWo_Verwaltung_Core
{
    public class Vermietet
    {
        public DateTime Ankunft { get; }
        public DateTime Abreise { get; }

        public User Mieter { get; }

        public Vermietet(DateTime ankunft, DateTime abreise, User mieter)
        {
            Ankunft = ankunft;
            Abreise = abreise;
            Mieter = mieter;
        }
    }
}