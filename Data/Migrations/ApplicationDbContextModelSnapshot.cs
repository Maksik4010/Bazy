﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication16.Data;

namespace WebApplication16.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApplication16.Models.czlonkowie_grup", b =>
                {
                    b.Property<int>("id_czlonkowie_grup")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("data_dolaczenia");

                    b.Property<int>("id_grupy_dyskusyjne");

                    b.Property<int>("id_uzytkownicy");

                    b.HasKey("id_czlonkowie_grup");

                    b.HasIndex("id_grupy_dyskusyjne");

                    b.ToTable("czlonkowie_Grups");
                });

            modelBuilder.Entity("WebApplication16.Models.fanpage", b =>
                {
                    b.Property<int>("id_fanpage")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("data_zalozenia");

                    b.Property<int>("id_uzytkownicy");

                    b.Property<string>("kategoria");

                    b.Property<int>("liczba_polubien");

                    b.Property<string>("nazwa");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("id_fanpage");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("fanpages");
                });

            modelBuilder.Entity("WebApplication16.Models.filmy", b =>
                {
                    b.Property<int>("id_filmy")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_uzytkownicy");

                    b.Property<string>("link_bezposredni");

                    b.Property<string>("nazwa");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("id_filmy");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("filmies");
                });

            modelBuilder.Entity("WebApplication16.Models.grupy_dyskusyjne", b =>
                {
                    b.Property<int>("id_grupy_dyskusyjne")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("data_zalozenia");

                    b.Property<int>("id_uzytkownicy");

                    b.Property<string>("nazwa")
                        .IsRequired();

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("id_grupy_dyskusyjne");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("grupy_Dyskusyjnes");
                });

            modelBuilder.Entity("WebApplication16.Models.komentarze", b =>
                {
                    b.Property<int>("id_komentarze")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("data_utworzenia");

                    b.Property<int>("id_posty");

                    b.Property<int>("id_uzytkownicy");

                    b.Property<int>("liczba_dislike");

                    b.Property<int>("liczba_like");

                    b.Property<int?>("postyid");

                    b.Property<string>("tresc");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("id_komentarze");

                    b.HasIndex("postyid");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("komentarze");
                });

            modelBuilder.Entity("WebApplication16.Models.pliki", b =>
                {
                    b.Property<int>("id_pliki")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_uzytkownicy");

                    b.Property<string>("link_bezpośredni");

                    b.Property<string>("nazwa");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("id_pliki");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("plikis");
                });

            modelBuilder.Entity("WebApplication16.Models.polubienia_fanpage", b =>
                {
                    b.Property<int>("id_polubienia_fanpage")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_fanpage");

                    b.Property<int>("id_uzytkownicy");

                    b.HasKey("id_polubienia_fanpage");

                    b.HasIndex("id_fanpage");

                    b.ToTable("polubienia_Fanpages");
                });

            modelBuilder.Entity("WebApplication16.Models.posty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("data_utworzenia");

                    b.Property<int>("id_uzytkownika");

                    b.Property<int>("liczba_dislike");

                    b.Property<int>("liczba_like");

                    b.Property<int>("status_komentarzy");

                    b.Property<string>("tresc")
                        .IsRequired();

                    b.Property<int>("typ");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("id");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("posties");
                });

            modelBuilder.Entity("WebApplication16.Models.reakcja_na_posty", b =>
                {
                    b.Property<int>("id_reakcje_na_posty")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_uzytkownicy");

                    b.Property<int>("id_wydarzenia");

                    b.Property<int>("typ");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("id_reakcje_na_posty");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("reakcja_Na_Posties");
                });

            modelBuilder.Entity("WebApplication16.Models.uzytkownicy", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("data_zalozenia");

                    b.Property<string>("haslo")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("imie")
                        .IsRequired();

                    b.Property<int>("ip_ostatniego_logowania");

                    b.Property<string>("kraj")
                        .IsRequired();

                    b.Property<string>("ksywka")
                        .IsRequired();

                    b.Property<int>("liczba_znajomych");

                    b.Property<string>("login")
                        .IsRequired();

                    b.Property<string>("nazwisko")
                        .IsRequired();

                    b.Property<int>("ostatnie_logowanie");

                    b.HasKey("id");

                    b.ToTable("uzytkownicies");
                });

            modelBuilder.Entity("WebApplication16.Models.wiadomosci", b =>
                {
                    b.Property<int>("Id_wiadomosci")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_konwersacji");

                    b.Property<int>("czy_usunieta");

                    b.Property<int>("data_utworzenia");

                    b.Property<int>("id_uzytkownicy");

                    b.Property<string>("tresc");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("Id_wiadomosci");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("wiadomoscis");
                });

            modelBuilder.Entity("WebApplication16.Models.zainteresowania", b =>
                {
                    b.Property<int>("Id_zainteresowania")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_uzytkownicy");

                    b.Property<string>("kategoria");

                    b.Property<int>("liczba_zainteresowanych");

                    b.Property<string>("nazwa");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("Id_zainteresowania");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("zainteresowanias");
                });

            modelBuilder.Entity("WebApplication16.Models.zaproszenia_do_grup", b =>
                {
                    b.Property<int>("Id_zaproszenia_do_grup")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("id_grupy_dyskusyjne");

                    b.Property<int>("id_uzytkownicy");

                    b.HasKey("Id_zaproszenia_do_grup");

                    b.HasIndex("id_grupy_dyskusyjne");

                    b.ToTable("zaproszenia_Do_Grups");
                });

            modelBuilder.Entity("WebApplication16.Models.zaproszenia_do_znajomych", b =>
                {
                    b.Property<int>("Id_zapraszającego")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("data_zaproszenia");

                    b.Property<int>("id_uzytkownicy");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("Id_zapraszającego");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("zaproszenia_Do_Znajomyches");
                });

            modelBuilder.Entity("WebApplication16.Models.zdjecia", b =>
                {
                    b.Property<int>("Id_zjecia")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_użytkownicy");

                    b.Property<string>("link_bezposredni");

                    b.Property<string>("nazwa");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("Id_zjecia");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("zdjecias");
                });

            modelBuilder.Entity("WebApplication16.Models.znajomi", b =>
                {
                    b.Property<int>("Id_znajomi")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_uzytkownicy");

                    b.Property<int>("Id_znajomwgo");

                    b.Property<int>("poczatek_znajomosci");

                    b.Property<int?>("uzytkownicyid");

                    b.HasKey("Id_znajomi");

                    b.HasIndex("uzytkownicyid");

                    b.ToTable("znajomis");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication16.Models.czlonkowie_grup", b =>
                {
                    b.HasOne("WebApplication16.Models.grupy_dyskusyjne", "grupy_Dyskusyjne")
                        .WithMany("czlonkowie_Grups")
                        .HasForeignKey("id_grupy_dyskusyjne")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication16.Models.fanpage", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("fanpages")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.filmy", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("filmies")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.grupy_dyskusyjne", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("grupy_Dyskusyjnes")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.komentarze", b =>
                {
                    b.HasOne("WebApplication16.Models.posty", "posty")
                        .WithMany("komentarzes")
                        .HasForeignKey("postyid");

                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("komentarzes")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.pliki", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("plikis")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.polubienia_fanpage", b =>
                {
                    b.HasOne("WebApplication16.Models.fanpage", "fanpage")
                        .WithMany("polubienia_Fanpages")
                        .HasForeignKey("id_fanpage")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication16.Models.posty", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("posties")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.reakcja_na_posty", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("reakcja_Na_Posties")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.wiadomosci", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("wiadomoscis")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.zainteresowania", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("zainteresowanias")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.zaproszenia_do_grup", b =>
                {
                    b.HasOne("WebApplication16.Models.grupy_dyskusyjne", "grupy_dyskusyjne")
                        .WithMany("zaproszenia_Do_Grups")
                        .HasForeignKey("id_grupy_dyskusyjne")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication16.Models.zaproszenia_do_znajomych", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("zaproszenia_Do_Znajomyches")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.zdjecia", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("Zdjecias")
                        .HasForeignKey("uzytkownicyid");
                });

            modelBuilder.Entity("WebApplication16.Models.znajomi", b =>
                {
                    b.HasOne("WebApplication16.Models.uzytkownicy", "uzytkownicy")
                        .WithMany("Znajomis")
                        .HasForeignKey("uzytkownicyid");
                });
#pragma warning restore 612, 618
        }
    }
}
