using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DocentlikPuanHesaplama.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    İmage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EgitimEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UluslarArasiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgitimEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FenEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MakaleAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FenEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FenEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilolojiEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UluslarArasiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilolojiEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilolojiEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HukukEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UluslarArasiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HukukEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HukukEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IlahiyatEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UluslarArasiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IlahiyatEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IlahiyatEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MimarlikEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MakaleAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentCsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MimarlikEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MimarlikEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MuhendisEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MakaleAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuhendisEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuhendisEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaglikEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UluslarArasiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiDmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaglikEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaglikEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SosyalEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UluslarArasiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiDmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SosyalEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SporEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UluslarArasiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UluslarArasiCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlusalBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinEsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinFsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinGsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SporEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SporEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZiraatEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MakaleAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCmakale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MakaleCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyayin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YayinDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapCsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDkitap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KitapDsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatentByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarAatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarBatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AtiflarCatif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBseviye = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DanismanlikBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaAproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaBproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaCproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArastirmaDproje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAyazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiAsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiByazar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToplantiBsirasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimAders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBdoktora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EgitimBders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorev2yil = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZiraatEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZiraatEntities_AspNetUsers_MyUserId",
                        column: x => x.MyUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EgitimEntities_MyUserId",
                table: "EgitimEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FenEntities_MyUserId",
                table: "FenEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FilolojiEntities_MyUserId",
                table: "FilolojiEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HukukEntities_MyUserId",
                table: "HukukEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IlahiyatEntities_MyUserId",
                table: "IlahiyatEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MimarlikEntities_MyUserId",
                table: "MimarlikEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MuhendisEntities_MyUserId",
                table: "MuhendisEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaglikEntities_MyUserId",
                table: "SaglikEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SosyalEntities_MyUserId",
                table: "SosyalEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SporEntities_MyUserId",
                table: "SporEntities",
                column: "MyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ZiraatEntities_MyUserId",
                table: "ZiraatEntities",
                column: "MyUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EgitimEntities");

            migrationBuilder.DropTable(
                name: "FenEntities");

            migrationBuilder.DropTable(
                name: "FilolojiEntities");

            migrationBuilder.DropTable(
                name: "HukukEntities");

            migrationBuilder.DropTable(
                name: "IlahiyatEntities");

            migrationBuilder.DropTable(
                name: "MimarlikEntities");

            migrationBuilder.DropTable(
                name: "MuhendisEntities");

            migrationBuilder.DropTable(
                name: "SaglikEntities");

            migrationBuilder.DropTable(
                name: "SosyalEntities");

            migrationBuilder.DropTable(
                name: "SporEntities");

            migrationBuilder.DropTable(
                name: "ZiraatEntities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
