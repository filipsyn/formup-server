using FormUp.Api.Features.v1.Exercises;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormUp.Api.Data.Configuration;

public sealed class ExercisesEntityConfiguration : IEntityTypeConfiguration<ExerciseEntity>
{
    public void Configure(EntityTypeBuilder<ExerciseEntity> builder)
    {
        builder.HasData(
            new ExerciseEntity { Name = "exercises.pull-ups" },
            new ExerciseEntity { Name = "exercises.push-ups" },
            new ExerciseEntity { Name = "exercises.bw-squats" },
            new ExerciseEntity { Name = "exercises.dips" }
        );
    }
}