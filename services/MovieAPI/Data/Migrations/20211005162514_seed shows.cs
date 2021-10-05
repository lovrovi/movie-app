using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieAPI.Data.Migrations
{
    public partial class seedshows : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "AvgRating", "Description", "Image", "MediaType", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 13, 2.0, "A comedy show", "image.jpg", 2, new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 1" },
                    { 14, 4.5, "A comedy show", "image.jpg", 2, new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 2" },
                    { 15, 3.5, "A comedy show", "image.jpg", 2, new DateTime(2010, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 3" },
                    { 16, 3.5, "A comedy show", "image.jpg", 2, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 4" },
                    { 17, 4.5, "A comedy show", "image.jpg", 2, new DateTime(2008, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 5" },
                    { 18, 1.5, "A comedy show", "image.jpg", 2, new DateTime(2001, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 6" },
                    { 19, 2.0, "A comedy show", "image.jpg", 2, new DateTime(1994, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 7" },
                    { 20, 4.5, "A comedy show", "image.jpg", 2, new DateTime(1990, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 8" },
                    { 21, 2.5, "A comedy show", "image.jpg", 2, new DateTime(1978, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 9" },
                    { 22, 2.5, "A comedy show", "image.jpg", 2, new DateTime(2010, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 10" },
                    { 23, 4.0, "A comedy show", "image.jpg", 2, new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 11" },
                    { 24, 3.0, "A comedy show", "image.jpg", 2, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Show 12" }
                });

            migrationBuilder.InsertData(
                table: "ActorsMedias",
                columns: new[] { "ActorId", "MediaId" },
                values: new object[,]
                {
                    { 1, 13 },
                    { 1, 18 },
                    { 6, 18 },
                    { 4, 22 },
                    { 3, 22 },
                    { 6, 17 },
                    { 5, 17 },
                    { 4, 20 },
                    { 5, 21 },
                    { 4, 16 },
                    { 3, 16 },
                    { 5, 23 },
                    { 3, 23 },
                    { 3, 15 },
                    { 2, 15 },
                    { 1, 21 },
                    { 3, 20 },
                    { 3, 14 },
                    { 1, 14 },
                    { 4, 24 },
                    { 6, 24 },
                    { 2, 13 },
                    { 6, 19 },
                    { 2, 19 }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Score" },
                values: new object[,]
                {
                    { 43, 22, 1 },
                    { 42, 21, 2 },
                    { 44, 22, 4 },
                    { 45, 23, 3 },
                    { 46, 23, 5 },
                    { 41, 21, 3 },
                    { 40, 20, 5 },
                    { 36, 18, 2 },
                    { 38, 19, 1 },
                    { 37, 19, 3 },
                    { 47, 24, 5 },
                    { 35, 18, 1 },
                    { 34, 17, 5 },
                    { 33, 17, 4 },
                    { 32, 16, 4 },
                    { 31, 16, 3 },
                    { 30, 15, 2 },
                    { 29, 15, 5 },
                    { 28, 14, 5 },
                    { 27, 14, 4 },
                    { 26, 13, 1 },
                    { 25, 13, 3 },
                    { 39, 20, 4 },
                    { 48, 24, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 20 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 5, 23 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 6, 18 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "ActorsMedias",
                keyColumns: new[] { "ActorId", "MediaId" },
                keyValues: new object[] { 6, 24 });

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Medias",
                keyColumn: "Id",
                keyValue: 24);
        }
    }
}
