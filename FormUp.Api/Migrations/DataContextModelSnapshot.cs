﻿// <auto-generated />
using System;
using FormUp.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormUp.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FormUp.Api.Common.Persistence.GeolocationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Geolocations");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Exercises.ExerciseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("42a85eb0-0d5d-4964-8acc-c219ed10f1f1"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2200),
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2240),
                            Name = "exercises.pull-ups"
                        },
                        new
                        {
                            Id = new Guid("091b2c47-8b6d-4e7c-9d9c-9b065c67c366"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250),
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250),
                            Name = "exercises.push-ups"
                        },
                        new
                        {
                            Id = new Guid("cc2541fc-065b-4b93-a9c6-52856ccec36f"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250),
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2250),
                            Name = "exercises.bw-squats"
                        },
                        new
                        {
                            Id = new Guid("e43186c5-41fb-4a38-be75-09a59962ae03"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2260),
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2260),
                            Name = "exercises.dips"
                        });
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Gyms.GymEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Gyms");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Translations.TranslationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Locale")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Locale", "Key");

                    b.ToTable("Translations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("accca864-fcfb-48c3-8965-0179d753dc39"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370),
                            Key = "exercises.pull-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370),
                            Value = "Shyby"
                        },
                        new
                        {
                            Id = new Guid("c73df065-456f-4b3c-8f5f-4d4de07d7db4"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370),
                            Key = "exercises.pull-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2370),
                            Value = "Pull ups"
                        },
                        new
                        {
                            Id = new Guid("02e4246d-27cb-4917-870a-39bdd5f8f406"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2380),
                            Key = "exercises.dips",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2380),
                            Value = "Dipy"
                        },
                        new
                        {
                            Id = new Guid("f9d45118-a307-4121-b1f9-541165282bbd"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2380),
                            Key = "exercises.dips",
                            Locale = "en",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390),
                            Value = "Dips"
                        },
                        new
                        {
                            Id = new Guid("9dfefab2-fd81-4e3d-acc0-00be08aa4c5c"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390),
                            Key = "exercises.bw-squats",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390),
                            Value = "Dřepy s vlastní vahou"
                        },
                        new
                        {
                            Id = new Guid("b40ecadb-8ef7-43cb-8e3f-2e9232e92888"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390),
                            Key = "exercises.bw-squats",
                            Locale = "en",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2390),
                            Value = "Body-weight squats"
                        },
                        new
                        {
                            Id = new Guid("2b07c0a4-cea0-433e-bae5-47480e61565e"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2400),
                            Key = "exercises.push-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2400),
                            Value = "Kliky"
                        },
                        new
                        {
                            Id = new Guid("666bd883-b2a0-412e-abac-af7d585a8492"),
                            CreatedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2400),
                            Key = "exercises.push-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2023, 12, 30, 16, 20, 47, 183, DateTimeKind.Local).AddTicks(2410),
                            Value = "Push ups"
                        });
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Users.HeightLogEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("Uid");

                    b.ToTable("Heights");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Users.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Uid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Users.WeightLogEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("Uid");

                    b.ToTable("Weights");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Workouts.ActivityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepetitionsCount")
                        .HasColumnType("int");

                    b.Property<int>("SetsCount")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.Property<Guid?>("WorkoutEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkoutId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkoutEntityId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Workouts.WorkoutEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("At")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Gyms.GymEntity", b =>
                {
                    b.HasOne("FormUp.Api.Common.Persistence.GeolocationEntity", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Workouts.ActivityEntity", b =>
                {
                    b.HasOne("FormUp.Api.Features.v1.Exercises.ExerciseEntity", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FormUp.Api.Features.v1.Workouts.WorkoutEntity", null)
                        .WithMany("Activities")
                        .HasForeignKey("WorkoutEntityId");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("FormUp.Api.Features.v1.Workouts.WorkoutEntity", b =>
                {
                    b.Navigation("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
