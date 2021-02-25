﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20210225175331_view")]
    partial class view
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DoctorWho.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "A1"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "A2"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "A3"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "A4"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "A5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "C1",
                            WhoPlayed = "CA1"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "C2",
                            WhoPlayed = "CA2"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "C3",
                            WhoPlayed = "CA3"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "C4",
                            WhoPlayed = "CA4"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "C5",
                            WhoPlayed = "CA5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodesView", b =>
                {
                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("EpisodesViews");
                });

            modelBuilder.Entity("DoctorWho.Db.fnCompanionsClass", b =>
                {
                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("CompanionsNames");
                });

            modelBuilder.Entity("DoctorWho.Db.fnEnemiesClass", b =>
                {
                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("EnemiesNames");
                });

            modelBuilder.Entity("DoctorWho.Db.spSummariseEpisodesCompanions", b =>
                {
                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<string>("CompanionName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("CompanionsEpisodeSummary");
                });

            modelBuilder.Entity("DoctorWho.Db.spSummariseEpisodesEnemies", b =>
                {
                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("EnemiesEpisodeSummary");
                });

            modelBuilder.Entity("DoctorWho.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "D1",
                            DoctorNumber = 20,
                            FirstEpisodeDate = new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(2016, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "D2",
                            DoctorNumber = 21,
                            FirstEpisodeDate = new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(2016, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "D3",
                            DoctorNumber = 22,
                            FirstEpisodeDate = new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(2016, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "D4",
                            DoctorNumber = 23,
                            FirstEpisodeDate = new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(2016, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "D5",
                            DoctorNumber = 24,
                            FirstEpisodeDate = new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "L1",
                            EnemyName = "C1"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "L2",
                            EnemyName = "C2"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "L3",
                            EnemyName = "C3"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "L4",
                            EnemyName = "C4"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "L5",
                            EnemyName = "C5"
                        });
                });

            modelBuilder.Entity("DoctorWho.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "action",
                            Notes = "meeh",
                            SeriesNumber = 1,
                            Title = "first eps"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 1,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "action",
                            Notes = "meeh",
                            SeriesNumber = 1,
                            Title = "second eps"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 1,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "action",
                            Notes = "meeh",
                            SeriesNumber = 1,
                            Title = "first eps"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 2,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 6,
                            EpisodeType = "action",
                            Notes = "meeh",
                            SeriesNumber = 1,
                            Title = "first eps"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 1,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "action",
                            Notes = "meeh",
                            SeriesNumber = 1,
                            Title = "first eps"
                        });
                });

            modelBuilder.Entity("DoctorWho.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 1,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 3,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 3,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 1,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 5,
                            EpisodeId = 4
                        });
                });

            modelBuilder.Entity("DoctorWho.Episode", b =>
                {
                    b.HasOne("DoctorWho.Author", "author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Doctor", "doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("DoctorWho.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Companion", "Companion")
                        .WithMany("EpisodeCompanion")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Episode", "Episode")
                        .WithMany("EpisodeCompanion")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Enemy", "Enemy")
                        .WithMany("EpisodeEnemy")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Episode", "Episode")
                        .WithMany("EpisodeEnemy")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Companion", b =>
                {
                    b.Navigation("EpisodeCompanion");
                });

            modelBuilder.Entity("DoctorWho.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemy");
                });

            modelBuilder.Entity("DoctorWho.Episode", b =>
                {
                    b.Navigation("EpisodeCompanion");

                    b.Navigation("EpisodeEnemy");
                });
#pragma warning restore 612, 618
        }
    }
}
