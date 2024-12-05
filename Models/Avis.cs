namespace FilMovie.Models
{
    public class Avis
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public int FilmID { get; set; }
        public Film Film { get; set; }

        public string Contenu { get; set; }
        public DateTime DateCréation { get; set; } = DateTime.Now;
    }
}


