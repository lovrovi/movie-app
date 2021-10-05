using Microsoft.EntityFrameworkCore;
using movieAPI.Models;
using MovieAPI.Models.Enums;
using System;

namespace movieAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Clint Eastwood" },
                new Actor { Id = 2, Name = "Samuel L. Jackson" },
                new Actor { Id = 3, Name = "Brad Pitt" },
                new Actor { Id = 4, Name = "Leonardo Di Caprio" },
                new Actor { Id = 5, Name = "Sandra Bullock" },
                new Actor { Id = 6, Name = "Robert De Niro" }
            );

            builder.Entity<Media>().HasData(
                new Media { Id = 1, Title = "Film 1", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2000, 1, 31).Date, AvgRating = 2, MediaType = MediaType.Movie },
                new Media { Id = 2, Title = "Film 2", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1995, 5, 5).Date, AvgRating = 4.5, MediaType = MediaType.Movie },
                new Media { Id = 3, Title = "Film 3", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2010, 3, 12).Date, AvgRating = 3.5, MediaType = MediaType.Movie },
                new Media { Id = 4, Title = "Film 4", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2020, 12, 10).Date, AvgRating = 3.5, MediaType = MediaType.Movie },
                new Media { Id = 5, Title = "Film 5", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2008, 7, 7).Date, AvgRating = 4.5, MediaType = MediaType.Movie },
                new Media { Id = 6, Title = "Film 6", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2001, 7, 19).Date, AvgRating = 1.5, MediaType = MediaType.Movie },
                new Media { Id = 7, Title = "Film 7", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1994, 8, 14).Date, AvgRating = 2, MediaType = MediaType.Movie },
                new Media { Id = 8, Title = "Film 8", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1990, 9, 15).Date, AvgRating = 4.5, MediaType = MediaType.Movie },
                new Media { Id = 9, Title = "Film 9", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1978, 10, 1).Date, AvgRating = 2.5, MediaType = MediaType.Movie },
                new Media { Id = 10, Title = "Film 10", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2010, 11, 24).Date, AvgRating = 2.5, MediaType = MediaType.Movie },
                new Media { Id = 11, Title = "Film 11", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2021, 4, 23).Date, AvgRating = 4, MediaType = MediaType.Movie },
                new Media { Id = 12, Title = "Film 12", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2020, 7, 30).Date, AvgRating = 3, MediaType = MediaType.Movie },
                new Media { Id = 13, Title = "Show 1", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2000, 1, 31).Date, AvgRating = 2, MediaType = MediaType.Show },
                new Media { Id = 14, Title = "Show 2", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(1995, 5, 5).Date, AvgRating = 4.5, MediaType = MediaType.Show },
                new Media { Id = 15, Title = "Show 3", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2010, 3, 12).Date, AvgRating = 3.5, MediaType = MediaType.Show },
                new Media { Id = 16, Title = "Show 4", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2020, 12, 10).Date, AvgRating = 3.5, MediaType = MediaType.Show },
                new Media { Id = 17, Title = "Show 5", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2008, 7, 7).Date, AvgRating = 4.5, MediaType = MediaType.Show },
                new Media { Id = 18, Title = "Show 6", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2001, 7, 19).Date, AvgRating = 1.5, MediaType = MediaType.Show },
                new Media { Id = 19, Title = "Show 7", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(1994, 8, 14).Date, AvgRating = 2, MediaType = MediaType.Show },
                new Media { Id = 20, Title = "Show 8", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(1990, 9, 15).Date, AvgRating = 4.5, MediaType = MediaType.Show },
                new Media { Id = 21, Title = "Show 9", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(1978, 10, 1).Date, AvgRating = 2.5, MediaType = MediaType.Show },
                new Media { Id = 22, Title = "Show 10", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2010, 11, 24).Date, AvgRating = 2.5, MediaType = MediaType.Show },
                new Media { Id = 23, Title = "Show 11", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2021, 4, 23).Date, AvgRating = 4, MediaType = MediaType.Show },
                new Media { Id = 24, Title = "Show 12", Description = "A comedy show", Image = "show.png", ReleaseDate = new DateTime(2020, 7, 30).Date, AvgRating = 3, MediaType = MediaType.Show }
            );

            builder.Entity<Rating>().HasData(
                new Rating { Id = 1, Score = 3, MediaId = 1 },
                new Rating { Id = 2, Score = 1, MediaId = 1 },
                new Rating { Id = 3, Score = 4, MediaId = 2 },
                new Rating { Id = 4, Score = 5, MediaId = 2 },
                new Rating { Id = 5, Score = 5, MediaId = 3 },
                new Rating { Id = 6, Score = 2, MediaId = 3 },
                new Rating { Id = 7, Score = 3, MediaId = 4 },
                new Rating { Id = 8, Score = 4, MediaId = 4 },
                new Rating { Id = 9, Score = 4, MediaId = 5 },
                new Rating { Id = 10, Score = 5, MediaId = 5 },
                new Rating { Id = 11, Score = 1, MediaId = 6 },
                new Rating { Id = 12, Score = 2, MediaId = 6 },
                new Rating { Id = 13, Score = 3, MediaId = 7 },
                new Rating { Id = 14, Score = 1, MediaId = 7 },
                new Rating { Id = 15, Score = 4, MediaId = 8 },
                new Rating { Id = 16, Score = 5, MediaId = 8 },
                new Rating { Id = 17, Score = 3, MediaId = 9 },
                new Rating { Id = 18, Score = 2, MediaId = 9 },
                new Rating { Id = 19, Score = 1, MediaId = 10 },
                new Rating { Id = 20, Score = 4, MediaId = 10 },
                new Rating { Id = 21, Score = 3, MediaId = 11 },
                new Rating { Id = 22, Score = 5, MediaId = 11 },
                new Rating { Id = 23, Score = 5, MediaId = 12 },
                new Rating { Id = 24, Score = 1, MediaId = 12 },
                new Rating { Id = 25, Score = 3, MediaId = 13 },
                new Rating { Id = 26, Score = 1, MediaId = 13 },
                new Rating { Id = 27, Score = 4, MediaId = 14 },
                new Rating { Id = 28, Score = 5, MediaId = 14 },
                new Rating { Id = 29, Score = 5, MediaId = 15 },
                new Rating { Id = 30, Score = 2, MediaId = 15 },
                new Rating { Id = 31, Score = 3, MediaId = 16 },
                new Rating { Id = 32, Score = 4, MediaId = 16 },
                new Rating { Id = 33, Score = 4, MediaId = 17 },
                new Rating { Id = 34, Score = 5, MediaId = 17 },
                new Rating { Id = 35, Score = 1, MediaId = 18 },
                new Rating { Id = 36, Score = 2, MediaId = 18 },
                new Rating { Id = 37, Score = 3, MediaId = 19 },
                new Rating { Id = 38, Score = 1, MediaId = 19 },
                new Rating { Id = 39, Score = 4, MediaId = 20 },
                new Rating { Id = 40, Score = 5, MediaId = 20 },
                new Rating { Id = 41, Score = 3, MediaId = 21 },
                new Rating { Id = 42, Score = 2, MediaId = 21 },
                new Rating { Id = 43, Score = 1, MediaId = 22 },
                new Rating { Id = 44, Score = 4, MediaId = 22 },
                new Rating { Id = 45, Score = 3, MediaId = 23 },
                new Rating { Id = 46, Score = 5, MediaId = 23 },
                new Rating { Id = 47, Score = 5, MediaId = 24 },
                new Rating { Id = 48, Score = 1, MediaId = 24 }
            );

            builder.Entity<ActorMedia>()
            .HasKey(x => new { x.ActorId, x.MediaId });

            builder.Entity<ActorMedia>()
                .HasOne(am => am.Actor)
                .WithMany(a => a.ActorMedia)
                .HasForeignKey(am => am.ActorId);

            builder.Entity<ActorMedia>()
                .HasOne(am => am.Media)
                .WithMany(m => m.ActorMedia)
                .HasForeignKey(am => am.MediaId);

            builder.Entity<ActorMedia>().HasData(
                new ActorMedia { ActorId = 1, MediaId = 1},
                new ActorMedia { ActorId = 2, MediaId = 1 },
                new ActorMedia { ActorId = 1, MediaId = 2 },
                new ActorMedia { ActorId = 3, MediaId = 2 },
                new ActorMedia { ActorId = 2, MediaId = 3 },
                new ActorMedia { ActorId = 3, MediaId = 3 },
                new ActorMedia { ActorId = 3, MediaId = 4 },
                new ActorMedia { ActorId = 4, MediaId = 4 },
                new ActorMedia { ActorId = 5, MediaId = 5 },
                new ActorMedia { ActorId = 6, MediaId = 5 },
                new ActorMedia { ActorId = 6, MediaId = 6 },
                new ActorMedia { ActorId = 1, MediaId = 6 },
                new ActorMedia { ActorId = 2, MediaId = 7 },
                new ActorMedia { ActorId = 6, MediaId = 7 },
                new ActorMedia { ActorId = 3, MediaId = 8 },
                new ActorMedia { ActorId = 4, MediaId = 8 },
                new ActorMedia { ActorId = 1, MediaId = 9 },
                new ActorMedia { ActorId = 5, MediaId = 9 },
                new ActorMedia { ActorId = 4, MediaId = 10 },
                new ActorMedia { ActorId = 3, MediaId = 10 },
                new ActorMedia { ActorId = 5, MediaId = 11 },
                new ActorMedia { ActorId = 3, MediaId = 11 },
                new ActorMedia { ActorId = 4, MediaId = 12 },
                new ActorMedia { ActorId = 6, MediaId = 12 },
                new ActorMedia { ActorId = 1, MediaId = 13 },
                new ActorMedia { ActorId = 2, MediaId = 13 },
                new ActorMedia { ActorId = 1, MediaId = 14 },
                new ActorMedia { ActorId = 3, MediaId = 14 },
                new ActorMedia { ActorId = 2, MediaId = 15 },
                new ActorMedia { ActorId = 3, MediaId = 15 },
                new ActorMedia { ActorId = 3, MediaId = 16 },
                new ActorMedia { ActorId = 4, MediaId = 16 },
                new ActorMedia { ActorId = 5, MediaId = 17 },
                new ActorMedia { ActorId = 6, MediaId = 17 },
                new ActorMedia { ActorId = 6, MediaId = 18 },
                new ActorMedia { ActorId = 1, MediaId = 18 },
                new ActorMedia { ActorId = 2, MediaId = 19 },
                new ActorMedia { ActorId = 6, MediaId = 19 },
                new ActorMedia { ActorId = 3, MediaId = 20 },
                new ActorMedia { ActorId = 4, MediaId = 20 },
                new ActorMedia { ActorId = 1, MediaId = 21 },
                new ActorMedia { ActorId = 5, MediaId = 21 },
                new ActorMedia { ActorId = 4, MediaId = 22 },
                new ActorMedia { ActorId = 3, MediaId = 22 },
                new ActorMedia { ActorId = 5, MediaId = 23 },
                new ActorMedia { ActorId = 3, MediaId = 23 },
                new ActorMedia { ActorId = 4, MediaId = 24 },
                new ActorMedia { ActorId = 6, MediaId = 24 }
            );
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMedia> ActorsMedias { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}