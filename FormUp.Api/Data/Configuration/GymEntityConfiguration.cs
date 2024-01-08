using FormUp.Api.Features.v1.Gyms;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormUp.Api.Data.Configuration;

public class GymEntityConfiguration : IEntityTypeConfiguration<GymEntity>
{
    public void Configure(EntityTypeBuilder<GymEntity> builder)
    {
        builder.HasData(
            new GymEntity
            {
                Name = "Posilovna Velký Průvan", Latitude = 49.178859520009325, Longitude = 16.59588166754828
            },
            new GymEntity
            {
                Name = "Posilovna Malý Průvan", Latitude = 49.1790839495353, Longitude = 16.596503940037902
            },
            new GymEntity { Name = "AZ Fitness", Latitude = 49.177089060496634, Longitude = 16.6061900935942 },
            new GymEntity { Name = "NewPark Gym", Latitude = 49.181262112264804, Longitude = 16.60282245697524 },
            new GymEntity { Name = "Energy Fitness Club", Latitude = 49.18033021060799, Longitude = 16.60638458169779 },
            new GymEntity { Name = "Hulk Gym", Latitude = 49.215051402565855, Longitude = 16.609402145470618 },
            new GymEntity { Name = "Fitness Boby", Latitude = 49.21297689968305, Longitude = 16.609015907373617 },
            new GymEntity { Name = "Blackfield Gym", Latitude = 49.21855543269049, Longitude = 16.624250854578833 },
            new GymEntity
            {
                Name = "Form Factory Fitness Club Vlněna",
                Latitude = 49.19049269473975,
                Longitude = 16.617386769256324
            },
            new GymEntity
            {
                Name = "Form Factory Fitness Club Lužánky",
                Latitude = 49.208489226784764,
                Longitude = 16.60542206288346
            }
        );
    }
}