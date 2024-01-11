using FormUp.Api.Features.v1.Exercises;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormUp.Api.Data.Configuration;

public sealed class ExercisesEntityConfiguration : IEntityTypeConfiguration<ExerciseEntity>
{
    public void Configure(EntityTypeBuilder<ExerciseEntity> builder)
    {
        builder.HasData(
            new ExerciseEntity
            {
                Name = "exercises.squat.name",
                NormalizedName = "exercises.squat.normalized-name",
                Description = "exercises.squat.description",
                ImageURL = "https://legionathletics.com/wp-content/uploads/2019/05/arnold-squat.jpg"
            },
            new ExerciseEntity
            {
                Name = "exercises.dead-lift.name",
                NormalizedName = "exercises.dead-lift.normalized-name",
                Description = "exercises.dead-lift.description",
                ImageURL = "https://miro.medium.com/v2/resize:fit:1024/0*UkQCo1eLsXjoXn4v.jpg"
            },
            new ExerciseEntity
            {
                Name = "exercises.shoulder-press.name",
                NormalizedName = "exercises.shoulder-press.normalized-name",
                Description = "exercises.shoulder-press.description",
                ImageURL =
                    "https://legionathletics.com/wp-content/uploads/2023/10/Dumbbell-Shoulder-Press-before-after.png"
            },
            new ExerciseEntity
            {
                Name = "exercises.pull-up.name",
                NormalizedName = "exercises.pull-up.normalized-name",
                Description = "exercises.pull-up.description",
                ImageURL =
                    "https://hips.hearstapps.com/hmg-prod/images/mh0418-fit-pul-01-1558551798.jpg?crop=0.749xw:1.00xh;0.251xw,0&resize=1200:*"
            },
            new ExerciseEntity
            {
                Name = "exercises.dip.name",
                NormalizedName = "exercises.dip.normalized-name",
                Description = "exercises.dip.description",
                ImageURL =
                    "https://www.muscleandfitness.com/wp-content/uploads/2018/07/1109-dip.jpg?w=800&quality=86&strip=all"
            },
            new ExerciseEntity
            {
                Name = "exercises.bench-press.name",
                NormalizedName = "exercises.bench-press.normalized-name",
                Description = "exercises.bench-press.description",
                ImageURL = "https://caliberstrong.com/wp-content/uploads/2020/04/how-to-bench-press.jpg"
            },
            new ExerciseEntity
            {
                Name = "exercises.lunge.name",
                NormalizedName = "exercises.lunge.normalized-name",
                Description = "exercises.lunge.description",
                ImageURL = "https://hortonbarbell.com/wp-content/uploads/2022/05/Dumbbell-Lunge.png"
            },
            new ExerciseEntity
            {
                Name = "exercises.push-up.name",
                NormalizedName = "exercises.push-up.normalized-name",
                Description = "exercises.push-up.description",
                ImageURL = "https://www.fitnesseducation.edu.au/wp-content/uploads/2017/03/Pushups.jpg"
            },
            new ExerciseEntity
            {
                Name = "exercises.curl.name",
                NormalizedName = "exercises.curl.normalized-name",
                Description = "exercises.curl.description",
                ImageURL = "https://hortonbarbell.com/wp-content/uploads/2023/01/How-To-Do-Tempo-Bicep-Curls.png"
            }
        );
    }
}