using Microsoft.EntityFrameworkCore;
using movieAPI.Models;
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

            builder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Film 1", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2000, 1, 31).Date, AvgRating = 2 },
                new Movie { Id = 2, Title = "Film 2", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1995, 5, 5).Date, AvgRating = 4.5 },
                new Movie { Id = 3, Title = "Film 3", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2010, 3, 12).Date, AvgRating = 3.5 },
                new Movie { Id = 4, Title = "Film 4", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2020, 12, 10).Date, AvgRating = 3.5 },
                new Movie { Id = 5, Title = "Film 5", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2008, 7, 7).Date, AvgRating = 4.5 },
                new Movie { Id = 6, Title = "Film 6", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2001, 7, 19).Date, AvgRating = 1.5 },
                new Movie { Id = 7, Title = "Film 7", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1994, 8, 14).Date, AvgRating = 2 },
                new Movie { Id = 8, Title = "Film 8", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1990, 9, 15).Date, AvgRating = 4.5 },
                new Movie { Id = 9, Title = "Film 9", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(1978, 10, 1).Date, AvgRating = 2.5 },
                new Movie { Id = 10, Title = "Film 10", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2010, 11, 24).Date, AvgRating = 2.5 },
                new Movie { Id = 11, Title = "Film 11", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2021, 4, 23).Date, AvgRating = 4 },
                new Movie { Id = 12, Title = "Film 12", Description = "An action movie", Image = "image.jpg", ReleaseDate = new DateTime(2020, 7, 30).Date, AvgRating = 3 }
            );

            builder.Entity<Rating>().HasData(
                new Rating { Id = 1, Score = 3, MovieId = 1 },
                new Rating { Id = 2, Score = 1, MovieId = 1 },
                new Rating { Id = 3, Score = 4, MovieId = 2 },
                new Rating { Id = 4, Score = 5, MovieId = 2 },
                new Rating { Id = 5, Score = 5, MovieId = 3 },
                new Rating { Id = 6, Score = 2, MovieId = 3 },
                new Rating { Id = 7, Score = 3, MovieId = 4 },
                new Rating { Id = 8, Score = 4, MovieId = 4 },
                new Rating { Id = 9, Score = 4, MovieId = 5 },
                new Rating { Id = 10, Score = 5, MovieId = 5 },
                new Rating { Id = 11, Score = 1, MovieId = 6 },
                new Rating { Id = 12, Score = 2, MovieId = 6 },
                new Rating { Id = 13, Score = 3, MovieId = 7 },
                new Rating { Id = 14, Score = 1, MovieId = 7 },
                new Rating { Id = 15, Score = 4, MovieId = 8 },
                new Rating { Id = 16, Score = 5, MovieId = 8 },
                new Rating { Id = 17, Score = 3, MovieId = 9 },
                new Rating { Id = 18, Score = 2, MovieId = 9 },
                new Rating { Id = 19, Score = 1, MovieId = 10 },
                new Rating { Id = 20, Score = 4, MovieId = 10 },
                new Rating { Id = 21, Score = 3, MovieId = 11 },
                new Rating { Id = 22, Score = 5, MovieId = 11 },
                new Rating { Id = 23, Score = 5, MovieId = 12 },
                new Rating { Id = 24, Score = 1, MovieId = 12 }
            );

            builder.Entity<ActorMovie>()
            .HasKey(x => new { x.ActorId, x.MovieId });

            builder.Entity<ActorMovie>()
                .HasOne(am => am.Actor)
                .WithMany(a => a.ActorMovie)
                .HasForeignKey(am => am.ActorId);

            builder.Entity<ActorMovie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.ActorMovie)
                .HasForeignKey(am => am.MovieId);

            builder.Entity<ActorMovie>().HasData(
                new ActorMovie { ActorId = 1, MovieId = 1},
                new ActorMovie { ActorId = 2, MovieId = 1 },
                new ActorMovie { ActorId = 1, MovieId = 2 },
                new ActorMovie { ActorId = 3, MovieId = 2 },
                new ActorMovie { ActorId = 2, MovieId = 3 },
                new ActorMovie { ActorId = 3, MovieId = 3 },
                new ActorMovie { ActorId = 3, MovieId = 4 },
                new ActorMovie { ActorId = 4, MovieId = 4 },
                new ActorMovie { ActorId = 5, MovieId = 5 },
                new ActorMovie { ActorId = 6, MovieId = 5 },
                new ActorMovie { ActorId = 6, MovieId = 6 },
                new ActorMovie { ActorId = 1, MovieId = 6 },
                new ActorMovie { ActorId = 2, MovieId = 7 },
                new ActorMovie { ActorId = 6, MovieId = 7 },
                new ActorMovie { ActorId = 3, MovieId = 8 },
                new ActorMovie { ActorId = 4, MovieId = 8 },
                new ActorMovie { ActorId = 1, MovieId = 9 },
                new ActorMovie { ActorId = 5, MovieId = 9 },
                new ActorMovie { ActorId = 4, MovieId = 10 },
                new ActorMovie { ActorId = 3, MovieId = 10 },
                new ActorMovie { ActorId = 5, MovieId = 11 },
                new ActorMovie { ActorId = 3, MovieId = 11 },
                new ActorMovie { ActorId = 4, MovieId = 12 },
                new ActorMovie { ActorId = 6, MovieId = 12 }
            );
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<ActorMovie> ActorsMovies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}