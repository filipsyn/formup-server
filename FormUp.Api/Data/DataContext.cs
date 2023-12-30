using FormUp.Api.Common.Persistence;
using FormUp.Api.Data.Configuration;
using FormUp.Api.Features.v1.Exercises;
using FormUp.Api.Features.v1.Gyms;
using FormUp.Api.Features.v1.Translations;
using FormUp.Api.Features.v1.Users;
using FormUp.Api.Features.v1.Workouts;

using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<GymEntity> Gyms => Set<GymEntity>();
    public DbSet<GeolocationEntity> Geolocations => Set<GeolocationEntity>();
    public DbSet<TranslationEntity> Translations => Set<TranslationEntity>();
    public DbSet<ExerciseEntity> Exercises => Set<ExerciseEntity>();
    public DbSet<ActivityEntity> Activities => Set<ActivityEntity>();
    public DbSet<WorkoutEntity> Workouts => Set<WorkoutEntity>();
    public DbSet<UserEntity> Users => Set<UserEntity>();
    public DbSet<WeightLogEntity> Weights => Set<WeightLogEntity>();
    public DbSet<HeightLogEntity> Heights => Set<HeightLogEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ExercisesEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TranslationsEntityConfiguration());
    }
}