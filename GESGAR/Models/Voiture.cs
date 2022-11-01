namespace GESGAR.Models
{
    public class Voiture
    {
        public int Id { get; set; }

        public string? Marque { get; set; }

        public string? Modele { get; set; }

        public int? Kilometrage { get; set; }

        public string? Carburant { get; set; }

        public string? Couleur { get; set; }

        public DateOnly? Annee;

        public string? Etat;

        public string? Immatriculation { get; set; }


    }
}
