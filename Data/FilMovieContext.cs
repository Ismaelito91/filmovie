using Microsoft.EntityFrameworkCore;
using FilMovie.Models;

namespace FilMovie.Data
{
    public class FilMovieContext : DbContext
    {
        public FilMovieContext(DbContextOptions<FilMovieContext> options) : base(options) { }

        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<ListeFilms> ListeFilms { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Avis> Avis { get; set; }
        public DbSet<Historique> Historiques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ListeFilms>()
                .HasOne(lf => lf.Utilisateur)
                .WithMany(u => u.ListeFilms)
                .HasForeignKey(lf => lf.UtilisateurID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ListeFilms>()
                .HasOne(lf => lf.Film)
                .WithMany(f => f.ListeFilms)
                .HasForeignKey(lf => lf.FilmID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notes>()
                .HasOne(n => n.Utilisateur)
                .WithMany(u => u.Notes)
                .HasForeignKey(n => n.UtilisateurID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Notes>()
                .HasOne(n => n.Film)
                .WithMany(f => f.Notes)
                .HasForeignKey(n => n.FilmID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Avis>()
                .HasOne(a => a.Utilisateur)
                .WithMany(u => u.Avis)
                .HasForeignKey(a => a.UtilisateurID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Avis>()
                .HasOne(a => a.Film)
                .WithMany(f => f.Avis)
                .HasForeignKey(a => a.FilmID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Historique>()
                .HasOne(h => h.Utilisateur)
                .WithMany(u => u.Historiques)
                .HasForeignKey(h => h.UtilisateurID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}