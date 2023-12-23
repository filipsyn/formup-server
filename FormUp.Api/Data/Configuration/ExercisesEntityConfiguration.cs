using FormUp.Api.Features.v1.Exercises;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormUp.Api.Data.Configuration;

public sealed class ExercisesEntityConfiguration : IEntityTypeConfiguration<ExerciseEntity>
{
    public void Configure(EntityTypeBuilder<ExerciseEntity> builder)
    {
        builder.HasData(
            new ExerciseEntity { Name = "Pull ups" },
            new ExerciseEntity { Name = "Push ups" },
            new ExerciseEntity { Name = "Body-weight squats" },
            new ExerciseEntity { Name = "Dips" }
        );
    }
}