using FormUp.Api.Features.v1.Translations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormUp.Api.Data.Configuration;

public class TranslationsEntityConfiguration : IEntityTypeConfiguration<TranslationEntity>
{
    public void Configure(EntityTypeBuilder<TranslationEntity> builder)
    {
        builder.HasData(
            // Squat
            new TranslationEntity { Key = "exercises.squat.name", Locale = "en", Value = "Squat" },
            new TranslationEntity { Key = "exercises.squat.name", Locale = "cs", Value = "Dřep" },
            new TranslationEntity { Key = "exercises.squat.normalized-name", Locale = "en", Value = "SQUAT" },
            new TranslationEntity { Key = "exercises.squat.normalized-name", Locale = "cs", Value = "DREP" },
            new TranslationEntity
            {
                Key = "exercises.squat.description",
                Locale = "en",
                Value =
                    "A fundamental lower body exercise targeting the legs, hamstrings, and glutes. Stand with feet shoulder-width apart, lower your body by bending your knees, and return to the starting position."
            },
            new TranslationEntity
            {
                Key = "exercises.squat.description",
                Locale = "cs",
                Value =
                    "Dřep posiluje dolní část těla, především nohy, hamstrings a hýždě. Vykonává se stáním s váhou na ramenou a poklesem do pravého úhlu v kolenou."
            },

            // Dead-lift
            new TranslationEntity { Key = "exercises.dead-lift.name", Locale = "en", Value = "Dead-lift" },
            new TranslationEntity { Key = "exercises.dead-lift.name", Locale = "cs", Value = "Mrtvý tah" },
            new TranslationEntity { Key = "exercises.dead-lift.normalized-name", Locale = "en", Value = "DEADLIFT" },
            new TranslationEntity { Key = "exercises.dead-lift.normalized-name", Locale = "cs", Value = "MRTVYTAH" },
            new TranslationEntity
            {
                Key = "exercises.dead-lift.description",
                Locale = "en",
                Value =
                    "A compound exercise for overall strength, focusing on the back, glutes, hamstrings, and lower back. Start with the weight on the ground, hinge at the hips, lift the weight by straightening your hips and knees."
            },
            new TranslationEntity
            {
                Key = "exercises.dead-lift.description",
                Locale = "cs",
                Value =
                    "Mrtvý tah je cvik na posílení zad, hýždí a hamstringů, provedený ohnutím v pase a zdvihem váhy z podlahy s udržením rovné páteře."
            },

            // Shoulder press
            new TranslationEntity { Key = "exercises.shoulder-press.name", Locale = "en", Value = "Shoulder press" },
            new TranslationEntity { Key = "exercises.shoulder-press.name", Locale = "cs", Value = "Tlak na ramena" },
            new TranslationEntity
            {
                Key = "exercises.shoulder-press.normalized-name", Locale = "en", Value = "SHOULDERPRESS"
            },
            new TranslationEntity
            {
                Key = "exercises.shoulder-press.normalized-name", Locale = "cs", Value = "TLAKNARAMENA"
            },
            new TranslationEntity
            {
                Key = "exercises.shoulder-press.description",
                Locale = "en",
                Value =
                    "An upper body exercise concentrating on shoulder muscles. Whether sitting or standing, press weights or other resistance overhead, emphasizing controlled movements."
            },
            new TranslationEntity
            {
                Key = "exercises.shoulder-press.description",
                Locale = "cs",
                Value =
                    "Tlaky na ramena zaměřují se na posílení ramenních svalů a vykonávají se tlačením činek nad hlavu."
            },

            // Pull up
            new TranslationEntity { Key = "exercises.pull-up.name", Locale = "en", Value = "Pull up" },
            new TranslationEntity { Key = "exercises.pull-up.name", Locale = "cs", Value = "Shyb" },
            new TranslationEntity { Key = "exercises.pull-up.normalized-name", Locale = "en", Value = "PULLUP" },
            new TranslationEntity { Key = "exercises.pull-up.normalized-name", Locale = "cs", Value = "SHYB" },
            new TranslationEntity
            {
                Key = "exercises.pull-up.description",
                Locale = "en",
                Value =
                    "An effective upper body exercise primarily targeting the back and biceps. Hang from a bar with palms facing away, pull your body up until your chin passes the bar, and lower back down."
            },
            new TranslationEntity
            {
                Key = "exercises.pull-up.description",
                Locale = "cs",
                Value = "Shyb je izolovaný cvik pro tricepsy, provádí se zvedáním váhy pomocí prodloužení paže."
            },

            // Dip
            new TranslationEntity { Key = "exercises.dip.name", Locale = "en", Value = "Dip" },
            new TranslationEntity { Key = "exercises.dip.name", Locale = "cs", Value = "Klik na bradlech" },
            new TranslationEntity { Key = "exercises.dip.normalized-name", Locale = "en", Value = "DIP" },
            new TranslationEntity { Key = "exercises.dip.normalized-name", Locale = "cs", Value = "KLIKNABRADLECH" },
            new TranslationEntity
            {
                Key = "exercises.dip.description",
                Locale = "en",
                Value =
                    "An isolation exercise for the triceps and chest. Support yourself on parallel bars, lower your body by bending your elbows, and push back up."
            },
            new TranslationEntity
            {
                Key = "exercises.dip.description",
                Locale = "cs",
                Value = "Kliky na bradlech posilují horní část těla, zejména hrudník, tricepsy a deltové svaly."
            },

            // Bench press
            new TranslationEntity { Key = "exercises.bench-press.name", Locale = "en", Value = "Bench press" },
            new TranslationEntity { Key = "exercises.bench-press.name", Locale = "cs", Value = "Bench press" },
            new TranslationEntity
            {
                Key = "exercises.bench-press.normalized-name", Locale = "en", Value = "BENCHPRESS"
            },
            new TranslationEntity
            {
                Key = "exercises.bench-press.normalized-name", Locale = "cs", Value = "BENCHPRESS"
            },
            new TranslationEntity
            {
                Key = "exercises.bench-press.description",
                Locale = "en",
                Value =
                    "A classic chest exercise focusing on the pectoral muscles. Lie on a bench, lower and lift a barbell or dumbbells to and from your chest."
            },
            new TranslationEntity
            {
                Key = "exercises.bench-press.description",
                Locale = "cs",
                Value = "Bench-press je klasický cvik pro posílení hrudníku, tricepse a delt. "
            },

            // Lunge
            new TranslationEntity { Key = "exercises.lunge.name", Locale = "en", Value = "Lunge" },
            new TranslationEntity { Key = "exercises.lunge.name", Locale = "cs", Value = "Výpad" },
            new TranslationEntity { Key = "exercises.lunge.normalized-name", Locale = "en", Value = "LUNGE" },
            new TranslationEntity { Key = "exercises.lunge.normalized-name", Locale = "cs", Value = "VYPAD" },
            new TranslationEntity
            {
                Key = "exercises.lunge.description",
                Locale = "en",
                Value =
                    "A lower body exercise targeting the legs and glutes. Take a step forward with one leg, lower your body until both knees form right angles, then return to the starting position."
            },
            new TranslationEntity
            {
                Key = "exercises.lunge.description",
                Locale = "cs",
                Value = "Výpad je cvik na dolní část těla, střídavým krokem dopředu a poklesem kolena k zemi."
            },

            // Push up
            new TranslationEntity { Key = "exercises.push-up.name", Locale = "en", Value = "Push up" },
            new TranslationEntity { Key = "exercises.push-up.name", Locale = "cs", Value = "Klik" },
            new TranslationEntity { Key = "exercises.push-up.normalized-name", Locale = "en", Value = "PUSHUP" },
            new TranslationEntity { Key = "exercises.push-up.normalized-name", Locale = "cs", Value = "KLIK" },
            new TranslationEntity
            {
                Key = "exercises.push-up.description",
                Locale = "en",
                Value =
                    "A versatile exercise engaging the chest, shoulders, and triceps. Start in a plank position, lower your body to the ground, and push back up."
            },
            new TranslationEntity
            {
                Key = "exercises.push-up.description",
                Locale = "cs",
                Value =
                    "Kliky jsou cvik na posílení horní části těla, zvláště hrudníku, tricepsů a deltových svalů. Provádí se opakováním zvedání a spouštění těla, kdy se opíráte o ruce na zemi a tlačíte se nahoru a dolů."
            },

            // Bicep curl
            new TranslationEntity { Key = "exercises.curl.name", Locale = "en", Value = "Bicep curl" },
            new TranslationEntity { Key = "exercises.curl.name", Locale = "cs", Value = "Bicepsový zdvih" },
            new TranslationEntity { Key = "exercises.curl.normalized-name", Locale = "en", Value = "BICEPCURL" },
            new TranslationEntity { Key = "exercises.curl.normalized-name", Locale = "cs", Value = "BICEPSOVYZDVIH" },
            new TranslationEntity
            {
                Key = "exercises.curl.description",
                Locale = "en",
                Value =
                    "An isolation exercise for the biceps. Stand with weights in hand, palms facing forward, and curl the weights towards your shoulders by bending at the elbows."
            },
            new TranslationEntity
            {
                Key = "exercises.curl.description",
                Locale = "cs",
                Value =
                    "Bicepsový zdvih cílí na posílení bicepsů a vykonává se zdvihem váhy směrem k ramenům při ohnutí v loktech."
            }
        );
    }
}