using GraphQL.Sample.DB.Entities;

namespace GraphQL.Sample.Services.Buildings
{
    public interface IBuildingService
    {
        IQueryable<Building> GetAll();
    }
}