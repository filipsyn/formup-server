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
    [Migration("20240111114209_AddNormalizedNameToExercise")]
    partial class AddNormalizedNameToExercise
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

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c736c63d-5e6f-4307-9b90-656d5d64b3c3"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8400),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8400),
                            Name = "exercises.pull-ups",
                            NormalizedName = ""
                        },
                        new
                        {
                            Id = new Guid("e07c5410-88a9-4318-806d-c2aee77817a3"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410),
                            Name = "exercises.push-ups",
                            NormalizedName = ""
                        },
                        new
                        {
                            Id = new Guid("7ea7ecc2-6944-438e-b57a-f1ad55023d6c"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410),
                            Name = "exercises.bw-squats",
                            NormalizedName = ""
                        },
                        new
                        {
                            Id = new Guid("b8d9d6ff-bb61-4628-b3a3-a29d4971fc92"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410),
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8410),
                            Name = "exercises.dips",
                            NormalizedName = ""
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
                            Id = new Guid("2f3b7bc1-82b5-4783-a283-2f2a9f69374b"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680),
                            Latitude = 49.178859520009325,
                            Longitude = 16.59588166754828,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680),
                            Name = "Posilovna Velký Průvan"
                        },
                        new
                        {
                            Id = new Guid("0976c9ee-20e7-44ff-b1dd-74112046c7e2"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680),
                            Latitude = 49.179083949535297,
                            Longitude = 16.596503940037902,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8680),
                            Name = "Posilovna Malý Průvan"
                        },
                        new
                        {
                            Id = new Guid("a505f0c1-d8a9-4682-8f31-01ac2303575b"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690),
                            Latitude = 49.177089060496634,
                            Longitude = 16.606190093594201,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690),
                            Name = "AZ Fitness"
                        },
                        new
                        {
                            Id = new Guid("51424e15-5d63-47a3-b10b-a861cef60301"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690),
                            Latitude = 49.181262112264804,
                            Longitude = 16.60282245697524,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690),
                            Name = "NewPark Gym"
                        },
                        new
                        {
                            Id = new Guid("ca57925c-e92a-4e29-8aa9-bc2aea4a0f4d"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690),
                            Latitude = 49.180330210607991,
                            Longitude = 16.606384581697789,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8690),
                            Name = "Energy Fitness Club"
                        },
                        new
                        {
                            Id = new Guid("66fe4507-f845-4a3a-8051-bd6640a228df"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700),
                            Latitude = 49.215051402565855,
                            Longitude = 16.609402145470618,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700),
                            Name = "Hulk Gym"
                        },
                        new
                        {
                            Id = new Guid("39dbdf04-2863-4262-8827-717ef0ff97c2"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700),
                            Latitude = 49.212976899683049,
                            Longitude = 16.609015907373617,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700),
                            Name = "Fitness Boby"
                        },
                        new
                        {
                            Id = new Guid("91227f27-25f3-4b91-adcd-2cb949993f36"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700),
                            Latitude = 49.218555432690493,
                            Longitude = 16.624250854578833,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8700),
                            Name = "Blackfield Gym"
                        },
                        new
                        {
                            Id = new Guid("fe7b87b2-51bf-43cf-a5ac-06c7d31e7c03"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710),
                            Latitude = 49.190492694739753,
                            Longitude = 16.617386769256324,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710),
                            Name = "Form Factory Fitness Club Vlněna"
                        },
                        new
                        {
                            Id = new Guid("11bb796a-9761-457f-83b5-70d06987d3e0"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710),
                            Latitude = 49.208489226784764,
                            Longitude = 16.605422062883459,
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8710),
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
                            Id = new Guid("611dc512-d7c4-4491-a623-613c4c38efeb"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8580),
                            Key = "exercises.pull-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8580),
                            Value = "Shyby"
                        },
                        new
                        {
                            Id = new Guid("6987fafb-9595-4a39-b2a2-ac771b71689c"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590),
                            Key = "exercises.pull-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590),
                            Value = "Pull ups"
                        },
                        new
                        {
                            Id = new Guid("3f4f3373-2982-4fa5-81fa-13445a727fe0"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590),
                            Key = "exercises.dips",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590),
                            Value = "Dipy"
                        },
                        new
                        {
                            Id = new Guid("2507a663-82c7-4a0d-9d87-df7043b164a5"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590),
                            Key = "exercises.dips",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8590),
                            Value = "Dips"
                        },
                        new
                        {
                            Id = new Guid("ffba584d-7934-4e86-b6da-5bb17a4d9b59"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600),
                            Key = "exercises.bw-squats",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600),
                            Value = "Dřepy s vlastní vahou"
                        },
                        new
                        {
                            Id = new Guid("28bf2b28-b46c-489e-bb8d-15c5b99924b1"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600),
                            Key = "exercises.bw-squats",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600),
                            Value = "Body-weight squats"
                        },
                        new
                        {
                            Id = new Guid("919a188c-e23a-4ae1-94bf-8d818c29b0f6"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600),
                            Key = "exercises.push-ups",
                            Locale = "cs",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8600),
                            Value = "Kliky"
                        },
                        new
                        {
                            Id = new Guid("a3842947-c873-443c-a659-9563a1045b96"),
                            CreatedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8610),
                            Key = "exercises.push-ups",
                            Locale = "en",
                            ModifiedAt = new DateTime(2024, 1, 11, 11, 42, 8, 916, DateTimeKind.Utc).AddTicks(8610),
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
