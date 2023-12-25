using FormUp.Api.Common.Config;
using FormUp.Api.Features.v1.Translations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormUp.Api.Data.Configuration;

public class TranslationsEntityConfiguration : IEntityTypeConfiguration<TranslationEntity>
{
    public void Configure(EntityTypeBuilder<TranslationEntity> builder)
    {
        builder.HasData(
            new TranslationEntity { Key = "exercises.pull-ups", Locale = Constants.Translation.Czech, Value = "Shyby" },
            new TranslationEntity
            {
                Key = "exercises.pull-ups", Locale = Constants.Translation.English, Value = "Pull ups"
            },
            new TranslationEntity { Key = "exercises.dips", Locale = Constants.Translation.Czech, Value = "Dipy" },
            new TranslationEntity { Key = "exercises.dips", Locale = Constants.Translation.English, Value = "Dips" },
            new TranslationEntity
            {
                Key = "exercises.bw-squats", Locale = Constants.Translation.Czech, Value = "Dřepy s vlastní vahou"
            },
            new TranslationEntity
            {
                Key = "exercises.bw-squats", Locale = Constants.Translation.English, Value = "Body-weight squats"
            },
            new TranslationEntity { Key = "exercises.push-ups", Locale = Constants.Translation.Czech, Value = "Kliky" },
            new TranslationEntity
            {
                Key = "exercises.push-ups", Locale = Constants.Translation.English, Value = "Push ups"
            }
        );
    }
}