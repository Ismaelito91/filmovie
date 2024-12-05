namespace FilMovie.Models
{
    public class ListeFilms
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public int FilmID { get; set; }
        public Film Film { get; set; }

        public string TypeListe { get; set; } // 'DejaVu' ou 'AVoir'
        public DateTime DateAjout { get; set; } = DateTime.Now;
    }
}