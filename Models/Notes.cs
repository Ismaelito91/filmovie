namespace FilMovie.Models
{
    public class Notes
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public int FilmID { get; set; }
        public Film Film { get; set; }

        public decimal Note { get; set; } // Entre 0 et 10
        public DateTime DateAjout { get; set; } = DateTime.Now;
    }
}