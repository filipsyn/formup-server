using FormUp.Api.Features.v1.Translations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormUp.Api.Data.Configuration;

public class TranslationsEntityConfiguration : IEntityTypeConfiguration<TranslationEntity>
{
    public void Configure(EntityTypeBuilder<TranslationEntity> builder)
    {
        builder.HasData(
            new TranslationEntity { Key = "exercises.pull-ups", Locale = "cs", Value = "Shyby" },
            new TranslationEntity { Key = "exercises.pull-ups", Locale = "en", Value = "Pull ups" },
            new TranslationEntity { Key = "exercises.dips", Locale = "cs", Value = "Dipy" },
            new TranslationEntity { Key = "exercises.dips", Locale = "en", Value = "Dips" },
            new TranslationEntity { Key = "exercises.bw-squats", Locale = "cs", Value = "Dřepy s vlastní vahou" },
            new TranslationEntity { Key = "exercises.bw-squats", Locale = "en", Value = "Body-weight squats" },
            new TranslationEntity { Key = "exercises.push-ups", Locale = "cs", Value = "Kliky" },
            new TranslationEntity { Key = "exercises.push-ups", Locale = "en", Value = "Push ups" }
        );
    }
}