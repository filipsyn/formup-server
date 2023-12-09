using FormUp.Api.Common.Persistence;
using FormUp.Api.Features.v1.Gyms;
using Microsoft.EntityFrameworkCore;

namespace FormUp.Api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<GymEntity> Gyms => Set<GymEntity>();
    public DbSet<GeolocationEntity> Geolocations => Set<GeolocationEntity>();
}