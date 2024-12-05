namespace FilMovie.Models
{
    public class Utilisateur
    {
        public int ID { get; set; }
        public string NomUtilisateur { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; } = "Utilisateur"; // Valeur par défaut

        public ICollection<ListeFilms> ListeFilms { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<Avis> Avis { get; set; }
        public ICollection<Historique> Historiques { get; set; }
    }
}