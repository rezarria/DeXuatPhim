using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeXuatApp.Migrations.MovieDb;

/// <inheritdoc />
public partial class movie : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            "Casts",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                Name = table.Column<string>("TEXT", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Casts", x => x.Id); });

        migrationBuilder.CreateTable(
            "Companies",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                Name = table.Column<string>("TEXT", nullable: false),
                DataId = table.Column<int>("INTEGER", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Companies", x => x.Id); });

        migrationBuilder.CreateTable(
            "Countries",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                Name = table.Column<string>("TEXT", nullable: false),
                Code = table.Column<string>("TEXT", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Countries", x => x.Id); });

        migrationBuilder.CreateTable(
            "Crews",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                DataId = table.Column<string>("TEXT", nullable: false),
                CreditId = table.Column<string>("TEXT", nullable: false),
                Gender = table.Column<int>("INTEGER", nullable: false),
                Name = table.Column<string>("TEXT", nullable: false),
                Department = table.Column<string>("TEXT", nullable: false),
                Job = table.Column<string>("TEXT", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Crews", x => x.Id); });

        migrationBuilder.CreateTable(
            "Directors",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                Name = table.Column<string>("TEXT", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Directors", x => x.Id); });

        migrationBuilder.CreateTable(
            "Genres",
            table => new
            {
                id = table.Column<Guid>("TEXT", nullable: false),
                name = table.Column<string>("TEXT", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Genres", x => x.id); });

        migrationBuilder.CreateTable(
            "Keywords",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                Name = table.Column<string>("TEXT", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Keywords", x => x.Id); });

        migrationBuilder.CreateTable(
            "Languages",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                Name = table.Column<string>("TEXT", nullable: false),
                Code = table.Column<string>("TEXT", nullable: false)
            },
            constraints: table => { table.PrimaryKey("PK_Languages", x => x.Id); });

        migrationBuilder.CreateTable(
            "Movies",
            table => new
            {
                Id = table.Column<Guid>("TEXT", nullable: false),
                DataId = table.Column<long>("INTEGER", nullable: false),
                Homepage = table.Column<string>("TEXT", nullable: false),
                Title = table.Column<string>("TEXT", nullable: false),
                OriginalTile = table.Column<string>("TEXT", nullable: false),
                OriginalLanguage = table.Column<string>("TEXT", nullable: false),
                Tagline = table.Column<string>("TEXT", nullable: false),
                Runtime = table.Column<int>("INTEGER", nullable: false),
                DirectorId = table.Column<Guid>("TEXT", nullable: false),
                VoteCount = table.Column<long>("INTEGER", nullable: false),
                VoteAverage = table.Column<double>("REAL", nullable: false),
                Revenue = table.Column<long>("INTEGER", nullable: false),
                ReleaseDate = table.Column<DateTime>("TEXT", nullable: false),
                Popularity = table.Column<double>("REAL", nullable: false),
                Overview = table.Column<string>("TEXT", nullable: false),
                Budget = table.Column<long>("INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Movies", x => x.Id);
                table.ForeignKey(
                    "FK_Movies_Directors_DirectorId",
                    x => x.DirectorId,
                    "Directors",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "CastMovie",
            table => new
            {
                CastsId = table.Column<Guid>("TEXT", nullable: false),
                MoviesId = table.Column<Guid>("TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CastMovie", x => new { x.CastsId, x.MoviesId });
                table.ForeignKey(
                    "FK_CastMovie_Casts_CastsId",
                    x => x.CastsId,
                    "Casts",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_CastMovie_Movies_MoviesId",
                    x => x.MoviesId,
                    "Movies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "CompanyMovie",
            table => new
            {
                MoviesId = table.Column<Guid>("TEXT", nullable: false),
                ProductionCompaniesId = table.Column<Guid>("TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CompanyMovie", x => new { x.MoviesId, x.ProductionCompaniesId });
                table.ForeignKey(
                    "FK_CompanyMovie_Companies_ProductionCompaniesId",
                    x => x.ProductionCompaniesId,
                    "Companies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_CompanyMovie_Movies_MoviesId",
                    x => x.MoviesId,
                    "Movies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "CountryMovie",
            table => new
            {
                MoviesId = table.Column<Guid>("TEXT", nullable: false),
                ProductionCountriesId = table.Column<Guid>("TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CountryMovie", x => new { x.MoviesId, x.ProductionCountriesId });
                table.ForeignKey(
                    "FK_CountryMovie_Countries_ProductionCountriesId",
                    x => x.ProductionCountriesId,
                    "Countries",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_CountryMovie_Movies_MoviesId",
                    x => x.MoviesId,
                    "Movies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "CrewMovie",
            table => new
            {
                CrewsId = table.Column<Guid>("TEXT", nullable: false),
                MoviesId = table.Column<Guid>("TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_CrewMovie", x => new { x.CrewsId, x.MoviesId });
                table.ForeignKey(
                    "FK_CrewMovie_Crews_CrewsId",
                    x => x.CrewsId,
                    "Crews",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_CrewMovie_Movies_MoviesId",
                    x => x.MoviesId,
                    "Movies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "GenreMovie",
            table => new
            {
                Genresid = table.Column<Guid>("TEXT", nullable: false),
                MoviesId = table.Column<Guid>("TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_GenreMovie", x => new { x.Genresid, x.MoviesId });
                table.ForeignKey(
                    "FK_GenreMovie_Genres_Genresid",
                    x => x.Genresid,
                    "Genres",
                    "id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_GenreMovie_Movies_MoviesId",
                    x => x.MoviesId,
                    "Movies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "KeywordMovie",
            table => new
            {
                KeywordsId = table.Column<Guid>("TEXT", nullable: false),
                MoviesId = table.Column<Guid>("TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_KeywordMovie", x => new { x.KeywordsId, x.MoviesId });
                table.ForeignKey(
                    "FK_KeywordMovie_Keywords_KeywordsId",
                    x => x.KeywordsId,
                    "Keywords",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_KeywordMovie_Movies_MoviesId",
                    x => x.MoviesId,
                    "Movies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            "LanguageMovie",
            table => new
            {
                MoviesId = table.Column<Guid>("TEXT", nullable: false),
                SpokenLanguagesId = table.Column<Guid>("TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_LanguageMovie", x => new { x.MoviesId, x.SpokenLanguagesId });
                table.ForeignKey(
                    "FK_LanguageMovie_Languages_SpokenLanguagesId",
                    x => x.SpokenLanguagesId,
                    "Languages",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    "FK_LanguageMovie_Movies_MoviesId",
                    x => x.MoviesId,
                    "Movies",
                    "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            "IX_CastMovie_MoviesId",
            "CastMovie",
            "MoviesId");

        migrationBuilder.CreateIndex(
            "IX_CompanyMovie_ProductionCompaniesId",
            "CompanyMovie",
            "ProductionCompaniesId");

        migrationBuilder.CreateIndex(
            "IX_CountryMovie_ProductionCountriesId",
            "CountryMovie",
            "ProductionCountriesId");

        migrationBuilder.CreateIndex(
            "IX_CrewMovie_MoviesId",
            "CrewMovie",
            "MoviesId");

        migrationBuilder.CreateIndex(
            "IX_GenreMovie_MoviesId",
            "GenreMovie",
            "MoviesId");

        migrationBuilder.CreateIndex(
            "IX_KeywordMovie_MoviesId",
            "KeywordMovie",
            "MoviesId");

        migrationBuilder.CreateIndex(
            "IX_LanguageMovie_SpokenLanguagesId",
            "LanguageMovie",
            "SpokenLanguagesId");

        migrationBuilder.CreateIndex(
            "IX_Movies_DataId",
            "Movies",
            "DataId",
            unique: true);

        migrationBuilder.CreateIndex(
            "IX_Movies_DirectorId",
            "Movies",
            "DirectorId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            "CastMovie");

        migrationBuilder.DropTable(
            "CompanyMovie");

        migrationBuilder.DropTable(
            "CountryMovie");

        migrationBuilder.DropTable(
            "CrewMovie");

        migrationBuilder.DropTable(
            "GenreMovie");

        migrationBuilder.DropTable(
            "KeywordMovie");

        migrationBuilder.DropTable(
            "LanguageMovie");

        migrationBuilder.DropTable(
            "Casts");

        migrationBuilder.DropTable(
            "Companies");

        migrationBuilder.DropTable(
            "Countries");

        migrationBuilder.DropTable(
            "Crews");

        migrationBuilder.DropTable(
            "Genres");

        migrationBuilder.DropTable(
            "Keywords");

        migrationBuilder.DropTable(
            "Languages");

        migrationBuilder.DropTable(
            "Movies");

        migrationBuilder.DropTable(
            "Directors");
    }
}