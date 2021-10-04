using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MovieAPI.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Score = table.Column<int>(type: "integer", nullable: false),
                    MovieId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Clint Eastwood" },
                    { 2, "Samuel L. Jackson" },
                    { 3, "Brad Pitt" },
                    { 4, "Leonardo Di Caprio" },
                    { 5, "Sandra Bullock" },
                    { 6, "Robert De Niro" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "Image", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 10, "An action movie", "image.jpg", new DateTime(2010, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 10" },
                    { 9, "An action movie", "image.jpg", new DateTime(1978, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 9" },
                    { 8, "An action movie", "image.jpg", new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 8" },
                    { 7, "An action movie", "image.jpg", new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 7" },
                    { 6, "An action movie", "image.jpg", new DateTime(2001, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 6" },
                    { 3, "An action movie", "image.jpg", new DateTime(2010, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 3" },
                    { 4, "An action movie", "image.jpg", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 4" },
                    { 11, "An action movie", "image.jpg", new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 11" },
                    { 2, "An action movie", "image.jpg", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 2" },
                    { 1, "An action movie", "image.jpg", new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 1" },
                    { 5, "An action movie", "image.jpg", new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 5" },
                    { 12, "An action movie", "image.jpg", new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Film 12" }
                });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 10 },
                    { 4, 8 },
                    { 3, 8 },
                    { 3, 10 },
                    { 6, 7 },
                    { 2, 7 },
                    { 6, 12 },
                    { 1, 6 },
                    { 6, 6 },
                    { 6, 5 },
                    { 1, 9 },
                    { 5, 5 },
                    { 4, 4 },
                    { 3, 4 },
                    { 3, 11 },
                    { 3, 3 },
                    { 2, 3 },
                    { 3, 2 },
                    { 1, 2 },
                    { 4, 12 },
                    { 2, 1 },
                    { 5, 11 },
                    { 5, 9 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "MovieId", "Score" },
                values: new object[,]
                {
                    { 10, 10, 5 },
                    { 11, 11, 1 },
                    { 6, 6, 2 },
                    { 8, 8, 4 },
                    { 7, 7, 4 },
                    { 5, 5, 2 },
                    { 4, 4, 5 },
                    { 3, 3, 4 },
                    { 2, 2, 1 },
                    { 1, 1, 3 },
                    { 9, 9, 4 },
                    { 12, 12, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MovieId",
                table: "ActorMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_MovieId",
                table: "Rating",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
