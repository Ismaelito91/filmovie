namespace FilMovie.Models
{
    public class Historique
    {
        public int ID { get; set; }
        public int UtilisateurID { get; set; }
        public Utilisateur Utilisateur { get; set; }

        public string Action { get; set; } // Exemple : "Ajouté à A Voir", "Noté", "Avis laissé"
        public DateTime DateAction { get; set; } = DateTime.Now;
    }
}