using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MovieAPI.Data.Migrations
{
    public partial class CreateMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_MovieId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "ActorsMovies");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Ratings",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings",
                newName: "IX_Ratings_MediaId");

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AvgRating = table.Column<double>(type: "double precision", nullable: false),
                    MediaType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorsMedias",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "integer", nullable: false),
                    MediaId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMedias", x => new { x.ActorId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_ActorsMedias_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMedias_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "AvgRating", "Description", "Image", "MediaType", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 2.0, "An action movie", "image.jpg", 1, new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 1" },
                    { 2, 4.5, "An action movie", "image.jpg", 1, new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 2" },
                    { 3, 3.5, "An action movie", "image.jpg", 1, new DateTime(2010, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 3" },
                    { 4, 3.5, "An action movie", "image.jpg", 1, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 4" },
                    { 5, 4.5, "An action movie", "image.jpg", 1, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 5" },
                    { 6, 1.5, "An action movie", "image.jpg", 1, new DateTime(2001, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 6" },
                    { 7, 2.0, "An action movie", "image.jpg", 1, new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 7" },
                    { 8, 4.5, "An action movie", "image.jpg", 1, new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 8" },
                    { 9, 2.5, "An action movie", "image.jpg", 1, new DateTime(1978, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 9" },
                    { 10, 2.5, "An action movie", "image.jpg", 1, new DateTime(2010, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 10" },
                    { 11, 4.0, "An action movie", "image.jpg", 1, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 11" },
                    { 12, 3.0, "An action movie", "image.jpg", 1, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 12" }
                });

            migrationBuilder.InsertData(
                table: "ActorsMedias",
                columns: new[] { "ActorId", "MediaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 11 },
                    { 5, 11 },
                    { 3, 10 },
                    { 4, 10 },
                    { 5, 9 },
                    { 1, 9 },
                    { 4, 8 },
                    { 3, 8 },
                    { 6, 7 },
                    { 2, 7 },
                    { 1, 6 },
                    { 6, 6 },
                    { 6, 5 },
                    { 5, 5 },
                    { 4, 4 },
                    { 3, 4 },
                    { 3, 3 },
                    { 2, 3 },
                    { 3, 2 },
                    { 1, 2 },
                    { 2, 1 },
                    { 4, 12 },
                    { 6, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMedias_MediaId",
                table: "ActorsMedias",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Medias_MediaId",
                table: "Ratings",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Medias_MediaId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "ActorsMedias");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Ratings",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                newName: "IX_Ratings_MovieId");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AvgRating = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorsMovies",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AvgRating", "Description", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 2.0, "An action movie", "image.jpg", new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 1" },
                    { 2, 4.5, "An action movie", "image.jpg", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 2" },
                    { 3, 3.5, "An action movie", "image.jpg", new DateTime(2010, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 3" },
                    { 4, 3.5, "An action movie", "image.jpg", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 4" },
                    { 5, 4.5, "An action movie", "image.jpg", new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 5" },
                    { 6, 1.5, "An action movie", "image.jpg", new DateTime(2001, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 6" },
                    { 7, 2.0, "An action movie", "image.jpg", new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 7" },
                    { 8, 4.5, "An action movie", "image.jpg", new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 8" },
                    { 9, 2.5, "An action movie", "image.jpg", new DateTime(1978, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 9" },
                    { 10, 2.5, "An action movie", "image.jpg", new DateTime(2010, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 10" },
                    { 11, 4.0, "An action movie", "image.jpg", new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 11" },
                    { 12, 3.0, "An action movie", "image.jpg", new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 12" }
                });

            migrationBuilder.InsertData(
                table: "ActorsMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 11 },
                    { 5, 11 },
                    { 3, 10 },
                    { 4, 10 },
                    { 5, 9 },
                    { 1, 9 },
                    { 4, 8 },
                    { 3, 8 },
                    { 6, 7 },
                    { 2, 7 },
                    { 1, 6 },
                    { 6, 6 },
                    { 6, 5 },
                    { 5, 5 },
                    { 4, 4 },
                    { 3, 4 },
                    { 3, 3 },
                    { 2, 3 },
                    { 3, 2 },
                    { 1, 2 },
                    { 2, 1 },
                    { 4, 12 },
                    { 6, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_MovieId",
                table: "ActorsMovies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_MovieId",
                table: "Ratings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
