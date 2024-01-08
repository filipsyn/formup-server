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

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

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
                            Id = new Guid("c6b0fc4b-4bb3-4558-b836-1fb4cffe7f8a"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560),
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560),
                            Name = "exercises.pull-ups"
                        },
                        new
                        {
                            Id = new Guid("43d9f9a4-bf79-4846-a663-d341f0bf6c42"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560),
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1560),
                            Name = "exercises.push-ups"
                        },
                        new
                        {
                            Id = new Guid("ab678f09-64de-4948-a5cb-4afd89233519"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570),
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570),
                            Name = "exercises.bw-squats"
                        },
                        new
                        {
                            Id = new Guid("88e7ec78-19ba-488a-ae35-cbe8b73c6b95"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570),
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1570),
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
                            Id = new Guid("78756b68-8058-47ce-8d7d-841fa88f7907"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790),
                            Latitude = 49.178859520009325,
                            Longitude = 16.59588166754828,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790),
                            Name = "Posilovna Velký Průvan"
                        },
                        new
                        {
                            Id = new Guid("159d754f-22ac-49ad-8433-a0ca5a9f7eab"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790),
                            Latitude = 49.179083949535297,
                            Longitude = 16.596503940037902,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790),
                            Name = "Posilovna Malý Průvan"
                        },
                        new
                        {
                            Id = new Guid("fc87cb09-5def-4bfe-b6f9-fcff9b435718"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790),
                            Latitude = 49.177089060496634,
                            Longitude = 16.606190093594201,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1790),
                            Name = "AZ Fitness"
                        },
                        new
                        {
                            Id = new Guid("56fc3c5a-c7a8-45d2-b62a-2214c55aff05"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800),
                            Latitude = 49.181262112264804,
                            Longitude = 16.60282245697524,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800),
                            Name = "NewPark Gym"
                        },
                        new
                        {
                            Id = new Guid("9f66e191-0334-4f19-a268-4bf6ded24d3f"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800),
                            Latitude = 49.180330210607991,
                            Longitude = 16.606384581697789,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800),
                            Name = "Energy Fitness Club"
                        },
                        new
                        {
                            Id = new Guid("da729ca4-8a99-4bdb-b3e2-f0cbc0ef884a"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1800),
                            Latitude = 49.215051402565855,
                            Longitude = 16.609402145470618,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810),
                            Name = "Hulk Gym"
                        },
                        new
                        {
                            Id = new Guid("ae27a7ee-cab0-4e34-a216-58bff11c4066"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810),
                            Latitude = 49.212976899683049,
                            Longitude = 16.609015907373617,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810),
                            Name = "Fitness Boby"
                        },
                        new
                        {
                            Id = new Guid("802a6865-673d-4482-aa01-8cde224812a9"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810),
                            Latitude = 49.218555432690493,
                            Longitude = 16.624250854578833,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1810),
                            Name = "Blackfield Gym"
                        },
                        new
                        {
                            Id = new Guid("f0807feb-791b-475c-a1ac-d3ed09a2cae3"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820),
                            Latitude = 49.190492694739753,
                            Longitude = 16.617386769256324,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820),
                            Name = "Form Factory Fitness Club Vlněna"
                        },
                        new
                        {
                            Id = new Guid("20f25d9c-202b-4232-b8b9-e2cc6537c5df"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820),
                            Latitude = 49.208489226784764,
                            Longitude = 16.605422062883459,
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1820),
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
                            Id = new Guid("3f23de4b-7b98-4bd0-99ef-61710836ba98"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700),
                            Key = "exercises.pull-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700),
                            Value = "Shyby"
                        },
                        new
                        {
                            Id = new Guid("a8cd94d5-1d23-42ce-aaa9-c8dc86dd0ae4"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700),
                            Key = "exercises.pull-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700),
                            Value = "Pull ups"
                        },
                        new
                        {
                            Id = new Guid("95a4e116-6601-4cbb-9848-3ac6dff30644"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700),
                            Key = "exercises.dips",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1700),
                            Value = "Dipy"
                        },
                        new
                        {
                            Id = new Guid("f013a1d3-3fca-4a40-b09a-afb17f176a60"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710),
                            Key = "exercises.dips",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710),
                            Value = "Dips"
                        },
                        new
                        {
                            Id = new Guid("b7b237ca-e098-42a6-9b15-dd57eecd8d65"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710),
                            Key = "exercises.bw-squats",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1710),
                            Value = "Dřepy s vlastní vahou"
                        },
                        new
                        {
                            Id = new Guid("875a290e-51fa-4649-9072-82dc5b9795c6"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720),
                            Key = "exercises.bw-squats",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720),
                            Value = "Body-weight squats"
                        },
                        new
                        {
                            Id = new Guid("6a7d0327-0491-433c-8ee5-a5080e037ef9"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720),
                            Key = "exercises.push-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720),
                            Value = "Kliky"
                        },
                        new
                        {
                            Id = new Guid("44c82199-a689-4a6b-bf63-32263fb0c768"),
                            CreatedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720),
                            Key = "exercises.push-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 8, 16, 35, 28, 521, DateTimeKind.Utc).AddTicks(1720),
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
