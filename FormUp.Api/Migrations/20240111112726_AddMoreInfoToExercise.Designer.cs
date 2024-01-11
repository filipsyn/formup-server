﻿// <auto-generated />
using System;
using FormUp.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FormUp.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240111112726_AddMoreInfoToExercise")]
    partial class AddMoreInfoToExercise
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90eae3ff-9ea6-4fa9-aeec-dcf7022a5cc9"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3630),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3630),
                            Name = "exercises.pull-ups"
                        },
                        new
                        {
                            Id = new Guid("78e85903-1db1-4d60-804c-c6607cc71ade"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3630),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640),
                            Name = "exercises.push-ups"
                        },
                        new
                        {
                            Id = new Guid("77b333d4-6c32-4cf1-aa07-22f927a3d0d1"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640),
                            Name = "exercises.bw-squats"
                        },
                        new
                        {
                            Id = new Guid("4937552e-83fd-4d2d-95fd-25a56305d24c"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3640),
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

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gyms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("96d34bb6-b2a4-4af6-9f66-ab0b1561bbda"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870),
                            Latitude = 49.178859520009325,
                            Longitude = 16.59588166754828,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870),
                            Name = "Posilovna Velký Průvan"
                        },
                        new
                        {
                            Id = new Guid("ed26e15e-acfd-4412-bac3-8d41ef697632"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870),
                            Latitude = 49.179083949535297,
                            Longitude = 16.596503940037902,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3870),
                            Name = "Posilovna Malý Průvan"
                        },
                        new
                        {
                            Id = new Guid("eb3e7dbe-c884-4597-9724-1c3ad5d123d3"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880),
                            Latitude = 49.177089060496634,
                            Longitude = 16.606190093594201,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880),
                            Name = "AZ Fitness"
                        },
                        new
                        {
                            Id = new Guid("b083e8b5-e651-4031-af44-a07c2a3c1386"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880),
                            Latitude = 49.181262112264804,
                            Longitude = 16.60282245697524,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880),
                            Name = "NewPark Gym"
                        },
                        new
                        {
                            Id = new Guid("5bbdfd2a-697d-42a3-aa5d-76feadacc38f"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880),
                            Latitude = 49.180330210607991,
                            Longitude = 16.606384581697789,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3880),
                            Name = "Energy Fitness Club"
                        },
                        new
                        {
                            Id = new Guid("9e2741de-6168-4e61-9b23-63d96afcbc3d"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890),
                            Latitude = 49.215051402565855,
                            Longitude = 16.609402145470618,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890),
                            Name = "Hulk Gym"
                        },
                        new
                        {
                            Id = new Guid("cc67c780-0bdd-4b7f-86f6-068fc72da085"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890),
                            Latitude = 49.212976899683049,
                            Longitude = 16.609015907373617,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890),
                            Name = "Fitness Boby"
                        },
                        new
                        {
                            Id = new Guid("48812fd6-a76f-4315-9b21-fc07956b3d02"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890),
                            Latitude = 49.218555432690493,
                            Longitude = 16.624250854578833,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3890),
                            Name = "Blackfield Gym"
                        },
                        new
                        {
                            Id = new Guid("26621dd4-e217-4261-b9bb-6c3b5a281cb1"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900),
                            Latitude = 49.190492694739753,
                            Longitude = 16.617386769256324,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900),
                            Name = "Form Factory Fitness Club Vlněna"
                        },
                        new
                        {
                            Id = new Guid("673d44f3-d314-4e97-916b-5494a833f9e1"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900),
                            Latitude = 49.208489226784764,
                            Longitude = 16.605422062883459,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3900),
                            Name = "Form Factory Fitness Club Lužánky"
                        });
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
                            Id = new Guid("49b1a5c6-d6dc-469f-9cd8-bab4afc9990d"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770),
                            Key = "exercises.pull-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770),
                            Value = "Shyby"
                        },
                        new
                        {
                            Id = new Guid("0407ba5c-70b7-41a1-a157-9dd6ae7c188a"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770),
                            Key = "exercises.pull-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770),
                            Value = "Pull ups"
                        },
                        new
                        {
                            Id = new Guid("a73a0573-3339-4b93-b41d-863959bbfd17"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3770),
                            Key = "exercises.dips",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780),
                            Value = "Dipy"
                        },
                        new
                        {
                            Id = new Guid("a889f3d2-ce9a-4e60-8bf7-e1a821dbc0f3"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780),
                            Key = "exercises.dips",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780),
                            Value = "Dips"
                        },
                        new
                        {
                            Id = new Guid("b29d716d-3e91-4afe-8bef-afa871e54440"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780),
                            Key = "exercises.bw-squats",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3780),
                            Value = "Dřepy s vlastní vahou"
                        },
                        new
                        {
                            Id = new Guid("4bea092f-d94f-4907-bda5-93863376f89b"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790),
                            Key = "exercises.bw-squats",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790),
                            Value = "Body-weight squats"
                        },
                        new
                        {
                            Id = new Guid("ecadd1a5-496a-4ce9-ae48-720381df7718"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790),
                            Key = "exercises.push-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790),
                            Value = "Kliky"
                        },
                        new
                        {
                            Id = new Guid("fe74adc9-a66f-4dd1-b0d5-dac004f74093"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790),
                            Key = "exercises.push-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 27, 25, 878, DateTimeKind.Utc).AddTicks(3790),
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

                    b.HasIndex("Uid")
                        .IsUnique();

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

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VerifiedAtGymId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
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
