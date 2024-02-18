﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsClub.API.Data;

#nullable disable

namespace SportsClub.API.Migrations
{
    [DbContext(typeof(SportsClubDbContext))]
    [Migration("20240218151752_test29")]
    partial class test29
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportsClub.API.Entities.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnrolledStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("SportsClub.API.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkOutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lessons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentCapacity = 21,
                            Instructor = "Marcel",
                            LocationId = 3,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 20, 19, 30, 0, 0, DateTimeKind.Local),
                            WorkOutId = 4
                        },
                        new
                        {
                            Id = 2,
                            CurrentCapacity = 4,
                            Instructor = "Coen",
                            LocationId = 5,
                            MaxCapacity = 15,
                            StartDateTime = new DateTime(2024, 2, 19, 18, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 5
                        },
                        new
                        {
                            Id = 3,
                            CurrentCapacity = 5,
                            Instructor = "Freek",
                            LocationId = 2,
                            MaxCapacity = 16,
                            StartDateTime = new DateTime(2024, 2, 18, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkOutId = 6
                        },
                        new
                        {
                            Id = 4,
                            CurrentCapacity = 21,
                            Instructor = "Miriam",
                            LocationId = 12,
                            MaxCapacity = 5,
                            StartDateTime = new DateTime(2024, 2, 20, 15, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 8
                        },
                        new
                        {
                            Id = 5,
                            CurrentCapacity = 0,
                            Instructor = "Miriam",
                            LocationId = 12,
                            MaxCapacity = 0,
                            StartDateTime = new DateTime(2024, 2, 22, 15, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 8
                        },
                        new
                        {
                            Id = 6,
                            CurrentCapacity = 6,
                            Instructor = "Marcel",
                            LocationId = 8,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 24, 10, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 9
                        },
                        new
                        {
                            Id = 7,
                            CurrentCapacity = 22,
                            Instructor = "Laura",
                            LocationId = 10,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 23, 19, 30, 0, 0, DateTimeKind.Local),
                            WorkOutId = 12
                        },
                        new
                        {
                            Id = 8,
                            CurrentCapacity = 22,
                            Instructor = "Emilio",
                            LocationId = 7,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 18, 11, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 10
                        },
                        new
                        {
                            Id = 9,
                            CurrentCapacity = 12,
                            Instructor = "Judith",
                            LocationId = 9,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 18, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkOutId = 11
                        },
                        new
                        {
                            Id = 10,
                            CurrentCapacity = 13,
                            Instructor = "Eva",
                            LocationId = 10,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 18, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkOutId = 12
                        },
                        new
                        {
                            Id = 11,
                            CurrentCapacity = 16,
                            Instructor = "Suzanne",
                            LocationId = 11,
                            MaxCapacity = 17,
                            StartDateTime = new DateTime(2024, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkOutId = 13
                        },
                        new
                        {
                            Id = 12,
                            CurrentCapacity = 17,
                            Instructor = "zelf trainen",
                            LocationId = 1,
                            MaxCapacity = 17,
                            StartDateTime = new DateTime(2024, 2, 18, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            WorkOutId = 3
                        },
                        new
                        {
                            Id = 13,
                            CurrentCapacity = 21,
                            Instructor = "Robert",
                            LocationId = 5,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 18, 19, 30, 0, 0, DateTimeKind.Unspecified),
                            WorkOutId = 2
                        },
                        new
                        {
                            Id = 14,
                            CurrentCapacity = 5,
                            Instructor = "",
                            LocationId = 4,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 19, 17, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 7
                        },
                        new
                        {
                            Id = 15,
                            CurrentCapacity = 6,
                            Instructor = "",
                            LocationId = 4,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 20, 17, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 7
                        },
                        new
                        {
                            Id = 16,
                            CurrentCapacity = 5,
                            Instructor = "",
                            LocationId = 4,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 21, 14, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 7
                        },
                        new
                        {
                            Id = 17,
                            CurrentCapacity = 4,
                            Instructor = "",
                            LocationId = 4,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 22, 14, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 7
                        },
                        new
                        {
                            Id = 18,
                            CurrentCapacity = 5,
                            Instructor = "",
                            LocationId = 4,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 23, 14, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 7
                        },
                        new
                        {
                            Id = 19,
                            CurrentCapacity = 3,
                            Instructor = "",
                            LocationId = 4,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 24, 10, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 7
                        },
                        new
                        {
                            Id = 20,
                            CurrentCapacity = 5,
                            Instructor = "",
                            LocationId = 4,
                            MaxCapacity = 22,
                            StartDateTime = new DateTime(2024, 2, 18, 10, 0, 0, 0, DateTimeKind.Local),
                            WorkOutId = 7
                        });
                });

            modelBuilder.Entity("SportsClub.API.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsOutside")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Nieuwe Inslag 99",
                            Capacity = 150,
                            IsOutside = false,
                            Name = "BRESS Sportcentrum"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Brouwmeesterstraat 10 Breda",
                            Capacity = 25,
                            IsOutside = false,
                            Name = "ApenkooiGym"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Spinveld 66 A1 Breda",
                            Capacity = 60,
                            IsOutside = false,
                            Name = "Boulderhal Bruut"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Wilderen 2, 4817 VG Breda",
                            Capacity = 20,
                            IsOutside = true,
                            Name = "Wilderen 2 Breda"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Nieuwe Inslag 99, 4817 GN Breda",
                            Capacity = 30,
                            IsOutside = true,
                            Name = "BRESS Sportcentrum, Dance Studio 1"
                        },
                        new
                        {
                            Id = 6,
                            Address = "Nieuwe Inslag 99, 4817 GN Breda",
                            Capacity = 20,
                            IsOutside = true,
                            Name = "BRESS Sportcentrum, Dance Studio 2"
                        },
                        new
                        {
                            Id = 8,
                            Address = "Pastoor Pottersplein 12, 4815 BC Breda",
                            Capacity = 25,
                            IsOutside = true,
                            Name = "Belcrumhuis"
                        },
                        new
                        {
                            Id = 7,
                            Address = "Nieuwe Inslag 99, 4817 GN Breda",
                            Capacity = 25,
                            IsOutside = false,
                            Name = "BRESS Sportcentrum, Fitness"
                        },
                        new
                        {
                            Id = 9,
                            Address = "Terheijdenseweg 508 Breda",
                            Capacity = 16,
                            IsOutside = true,
                            Name = "TVBN Tennisvereniging Breda Noord"
                        },
                        new
                        {
                            Id = 10,
                            Address = "Dr. Schaepmanlaan 4 Breda",
                            Capacity = 16,
                            IsOutside = false,
                            Name = "Atletiekvereniging SPRINT"
                        },
                        new
                        {
                            Id = 11,
                            Address = "Teteringsedijk 145, 4817 MD Breda",
                            Capacity = 12,
                            IsOutside = false,
                            Name = "Ortega Diving"
                        },
                        new
                        {
                            Id = 12,
                            Address = "Gasthuisvelden 11, 4811 VX Breda",
                            Capacity = 8,
                            IsOutside = true,
                            Name = "Ortega Diving"
                        });
                });

            modelBuilder.Entity("SportsClub.API.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "buiten sporten",
                            Description = "Atletiek is samen met de zwemsport de oudste sport ter wereld en wordt ook wel ‘de moeder der sporten’ genoemd omdat het de menselijke basisbewegingen (lopen, springen en werpen) omvat. Bij atletiek moeten sporters (de atleten) op individueel of in groepen (estafette) presteren en kan zowel op de weg als op de atletiekbaan worden beoefend.",
                            Duration = 75,
                            Image = "https://bress.nl/wp-content/uploads/2022/05/sports-family-training-summer-forest-min-1536x1024.jpg",
                            Title = "Atletiek"
                        },
                        new
                        {
                            Id = 2,
                            Category = "binnen sporten",
                            Description = "Ben jij wel toe aan wat ontspanning maar wil je tegelijkertijd wel je lichaam trainen? Volg dan de Body & Mind les van Robert. Tijdens deze les leer je gecontroleerd te ademhalen en verbeter je je flexibiliteit en statische kracht. Dankzij de meditatie oefeningen verbeter je ook nog eens je concentratie. Alle oefeningen worden uitgevoerd met rustgevende muziek op de achtergrond maar vergis je niet; dit is absoluut geen suffe les!",
                            Duration = 50,
                            Image = "https://bress.nl/wp-content/uploads/2022/10/pexels-mikhail-nilov-6740754-1.jpg",
                            Title = "Body and mind"
                        },
                        new
                        {
                            Id = 3,
                            Category = "binnen sporten",
                            Description = "Badminton is een Olympische sport die wordt gespeeld met een racket en een shuttle. De shuttle wordt over een net heen en weer geslagen met de rackets. Afhankelijk van met hoeveel personen je op de baan staat speel je een enkelspel of een dubbelspel. Bij een enkelspel speel je één tegen één en bij een dubbelspel twee tegen twee.",
                            Duration = 60,
                            Image = "https://bress.nl/wp-content/uploads/2022/05/BRESS_Badminton_30okt_excl_016-min-1536x1025.jpg",
                            Title = "Badminton"
                        },
                        new
                        {
                            Id = 4,
                            Category = "conditie en kracht",
                            Description = "Bootcamp is groepstraining die conditie- en krachtoefeningen combineert en buiten plaatsvindt. Tijdens veel oefeningen wordt er gebruik gemaakt van eigen lichaamsgewicht en obstakels die in de omgeving aanwezig zijn, denk bijvoorbeeld aan bankjes, stoepranden en hekken. Sommige oefeningen doe je in tweetallen of in kleine groepjes, zodat je elkaar kunt gebruiken om bepaalde oefeningen uit te voeren en elkaar aan te moedigen. Samen bereik je meer!",
                            Duration = 75,
                            Image = "https://bress.nl/wp-content/uploads/2022/05/Schermafbeelding-2022-05-23-om-16.47.36-1024x959.png",
                            Price = 2.5m,
                            Title = "Bootcamp"
                        },
                        new
                        {
                            Id = 7,
                            Category = "conditie en kracht",
                            Description = "Boulderen is een spectaculaire vorm van klimmen en komt voort uit het beklimmen van rotsblokken. Anders dan bij klimmen heb je bij boulderen geen touw en klimgordels nodig. Dikke valmatten onder de routes zorgen voor veiligheid. De klimwanden in de boulderhal hebben een maximale hoogte van 4,5 meter en variëren van voorover neigend tot en met fors achterover hellend. Het is een sport voor vrijwel iedereen en kan zowel individueel als in groepsverband beoefend worden. Door de mix van de verschillende wanden en boulders kunnen zowel beginnende klimmers als gevorderden naast en met elkaar boulderen.",
                            Duration = 120,
                            Image = "https://bress.nl/wp-content/uploads/2022/10/boulderen-2.jpeg",
                            Price = 6.5m,
                            Title = "Boulderen"
                        },
                        new
                        {
                            Id = 5,
                            Category = "kracht",
                            Description = "Tijdens de high intensity training BoxFit krijg je te maken met een combinatie van bokstechnieken en oefeningen met eigen lichaamsgewicht, waarbij fun en samenwerking centraal staat.",
                            Duration = 60,
                            Image = "https://bress.nl/wp-content/uploads/2022/10/nieuwjaarsactie-RAW_011-min-768x1159.jpg",
                            Title = "BoxFit"
                        },
                        new
                        {
                            Id = 6,
                            Category = "balsport",
                            Description = "Spikeball/Roundnet, een supersnelle maar zeker spectaculaire sport! Het spel wordt 2-op-2 gespeeld, met een rond net tussen de twee teams. Eén speler begint met het serveren van de bal op het net, waardoor deze opduikt naar zijn tegenstanders. Net als bij volleybal mag elk team de bal maximaal drie keer raken voordat deze weer in het net moet landen.",
                            Duration = 75,
                            Image = "https://bress.nl/wp-content/uploads/2022/10/Spikeball-november-2020-2-1536x1024.jpg",
                            Title = "Spikeball/Roundnet"
                        },
                        new
                        {
                            Id = 8,
                            Category = "outdoor",
                            Description = "SUP staat voor Stand Up Paddling. Je staat op een plank met een peddel en kunt zelf varen, de omgeving vanaf de waterkant bekijken of bijvoorbeeld oefeningen doen op jouw plank. Suppen is heel toegankelijk; iedereen kan het op zijn/haar eigen niveau beoefenen.",
                            Duration = 60,
                            Image = "https://bress.nl/wp-content/uploads/2022/05/supping-2022-04-12-02-01-30-utc-1536x1024.jpg",
                            Title = "SUP"
                        },
                        new
                        {
                            Id = 10,
                            Category = "kracht",
                            Description = "Onze fitness beschikt over de up-to-date cardio- en krachtapparatuur van Matrix Fitness en daarnaast ook over een free weight area waar je alle ruimte hebt om (grond)oefeningen te doen of te trainen met dumbbells, barbells en andere materialen.",
                            Duration = 90,
                            Image = "https://bress.nl/wp-content/uploads/2023/09/BRESS_newgym1208_005-1536x1106.jpg",
                            Title = "Fitness"
                        },
                        new
                        {
                            Id = 11,
                            Category = "balsport",
                            Description = "Beachtennis is een snelgroeiende beachsport die zijn oorsprong vindt in Amerika en Brazilië. Het grote verschil met reguliere tennis is dat er bij beachtennis geen ingewikkelde lijnen zijn; met de buitenlijnen en een net ben je al klaar!",
                            Duration = 90,
                            Image = "https://bress.nl/wp-content/uploads/2022/09/BredaBeachGames-12-1024x684.jpg",
                            Title = "Beachtennis"
                        },
                        new
                        {
                            Id = 12,
                            Category = "groepsles",
                            Description = "Aerial Silk is een unieke sport die zijn oorsprong kent in het circus. Tijdens het beoefenen van deze sport train je heel je lichaam en ontwikkel je evenwicht, kracht en flexibiliteit. Daarnaast krijg je echt een kick als je in de doeken hangt.",
                            Duration = 90,
                            Image = "https://bress.nl/wp-content/uploads/2022/09/IMG_2558-23-1.jpg",
                            Title = "Aerial Silk"
                        },
                        new
                        {
                            Id = 13,
                            Category = "groepsles",
                            Description = "Duiken is één van de snelst groeiende avontuurlijke sporten ter wereld en dat is niet zonder reden. Het ontspannen gevoel en het gevoel van gewichtloosheid (een gevoel dat verder alleen astronauten kunnen meemaken) maakt duiken tot een unieke sport. Duiken doe je altijd met minimaal 2 personen waardoor het ook nog eens een sociale sport is. Wist je trouwens dat het aardoppervlakte\r\nuit 70% water bestaat en dat er onder water meer verschillende soorten planten en dieren leven dan erboven? Er valt dus nog genoeg te ontdekken in de onderwaterwereld!",
                            Duration = 90,
                            Image = "https://bress.nl/wp-content/uploads/2022/05/BRESS_Duiken_016-1024x684.jpg",
                            Title = "Duiken"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
