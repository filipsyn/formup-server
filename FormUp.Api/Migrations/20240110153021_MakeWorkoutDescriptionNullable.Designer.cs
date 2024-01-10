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
    [Migration("20240110153021_MakeWorkoutDescriptionNullable")]
    partial class MakeWorkoutDescriptionNullable
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
                            Id = new Guid("8debef06-ec79-4b86-8bc0-ed2985f74305"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580),
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580),
                            Name = "exercises.pull-ups"
                        },
                        new
                        {
                            Id = new Guid("3fd892d1-44f0-4328-895b-c06b1608f9ef"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580),
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(580),
                            Name = "exercises.push-ups"
                        },
                        new
                        {
                            Id = new Guid("5cf77793-620a-4a6e-b142-3290eeb2d424"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590),
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590),
                            Name = "exercises.bw-squats"
                        },
                        new
                        {
                            Id = new Guid("30280a70-3209-4254-823f-84c51d5bff40"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590),
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(590),
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
                            Id = new Guid("70f29ff5-2c14-4b7a-8aa0-c937989c8771"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(780),
                            Latitude = 49.178859520009325,
                            Longitude = 16.59588166754828,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(780),
                            Name = "Posilovna Velký Průvan"
                        },
                        new
                        {
                            Id = new Guid("a32cd8ff-7380-4dfc-bb1f-bd23ca859d43"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790),
                            Latitude = 49.179083949535297,
                            Longitude = 16.596503940037902,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790),
                            Name = "Posilovna Malý Průvan"
                        },
                        new
                        {
                            Id = new Guid("29209209-6f29-4249-b139-c99c2784df66"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790),
                            Latitude = 49.177089060496634,
                            Longitude = 16.606190093594201,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(790),
                            Name = "AZ Fitness"
                        },
                        new
                        {
                            Id = new Guid("5039e69b-071d-466f-ab47-4a78add4ae95"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800),
                            Latitude = 49.181262112264804,
                            Longitude = 16.60282245697524,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800),
                            Name = "NewPark Gym"
                        },
                        new
                        {
                            Id = new Guid("392cbf99-8900-4440-8be8-30e4c930f18d"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800),
                            Latitude = 49.180330210607991,
                            Longitude = 16.606384581697789,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800),
                            Name = "Energy Fitness Club"
                        },
                        new
                        {
                            Id = new Guid("18140b58-51fe-414f-8254-73f9dabc8e99"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800),
                            Latitude = 49.215051402565855,
                            Longitude = 16.609402145470618,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(800),
                            Name = "Hulk Gym"
                        },
                        new
                        {
                            Id = new Guid("ef4d09a0-cb12-44f2-9a67-6e3dbe66cc0e"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810),
                            Latitude = 49.212976899683049,
                            Longitude = 16.609015907373617,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810),
                            Name = "Fitness Boby"
                        },
                        new
                        {
                            Id = new Guid("d68fce2f-8614-41a9-bd7e-ba3dc766b704"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810),
                            Latitude = 49.218555432690493,
                            Longitude = 16.624250854578833,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810),
                            Name = "Blackfield Gym"
                        },
                        new
                        {
                            Id = new Guid("6d3324cb-eacf-4012-86b0-0eeecbdd5c35"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810),
                            Latitude = 49.190492694739753,
                            Longitude = 16.617386769256324,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(810),
                            Name = "Form Factory Fitness Club Vlněna"
                        },
                        new
                        {
                            Id = new Guid("11b3af9e-2e4f-4d42-a838-cc71c17f2766"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(820),
                            Latitude = 49.208489226784764,
                            Longitude = 16.605422062883459,
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(820),
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
                            Id = new Guid("715a6e33-487d-441c-adcf-10f047f94ea7"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(700),
                            Key = "exercises.pull-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(700),
                            Value = "Shyby"
                        },
                        new
                        {
                            Id = new Guid("2521b9d7-4a05-43ed-87e5-ed47fceca6b4"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710),
                            Key = "exercises.pull-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710),
                            Value = "Pull ups"
                        },
                        new
                        {
                            Id = new Guid("25509d7c-f5d9-462a-ba1a-d2722b8646ec"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710),
                            Key = "exercises.dips",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710),
                            Value = "Dipy"
                        },
                        new
                        {
                            Id = new Guid("34d30ff9-7a8f-40ec-8e7b-696d138f4586"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710),
                            Key = "exercises.dips",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(710),
                            Value = "Dips"
                        },
                        new
                        {
                            Id = new Guid("b3c44e54-14ac-4977-83dd-e5dfde8bf7d3"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720),
                            Key = "exercises.bw-squats",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720),
                            Value = "Dřepy s vlastní vahou"
                        },
                        new
                        {
                            Id = new Guid("d03deb57-6a79-4cc9-b169-3492589f1367"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720),
                            Key = "exercises.bw-squats",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720),
                            Value = "Body-weight squats"
                        },
                        new
                        {
                            Id = new Guid("02daa530-0d15-4e95-9c07-a58c8f3e8178"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720),
                            Key = "exercises.push-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(720),
                            Value = "Kliky"
                        },
                        new
                        {
                            Id = new Guid("cdee4e4d-bb2c-4be7-bca2-0369d9fa705d"),
                            CreatedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(730),
                            Key = "exercises.push-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 10, 15, 30, 21, 518, DateTimeKind.Utc).AddTicks(730),
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