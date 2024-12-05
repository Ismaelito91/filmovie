namespace FilMovie.Models
{
    public class Film
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public string Résumé { get; set; }
        public DateTime DateSortie { get; set; }
        public string Genre { get; set; }
        public string ImageURL { get; set; }

        public ICollection<Notes> Notes { get; set; }
        public ICollection<Avis> Avis { get; set; }
        public ICollection<ListeFilms> ListeFilms { get; set; }
    }
}