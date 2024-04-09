using GraphQL.Sample.DB.Entities;
using GraphQL.Sample.Services.Buildings;

namespace GraphQL.Sample.Types
{
    [ExtendObjectType("Query")]
    public class BuildingQuery
    {
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Building> GetBuildings(IBuildingService service)
        {
            return service.GetAll();
        }
    }
}
