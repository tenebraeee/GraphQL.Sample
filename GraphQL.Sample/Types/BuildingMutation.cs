using GraphQL.Sample.DB.Entities;
using GraphQL.Sample.DB;
using Mapster;

namespace GraphQL.Sample.Types
{
    [ExtendObjectType("Mutation")]
    public class BuildingMutation
    {
        public async Task<Building> BuildingAsync([Service] SqlContext context, BuildingModel model)
        {
            var building = model.Adapt<Building>();
            await context.AddAsync(building);
            await context.SaveChangesAsync();

            return building;
        }

        public class BuildingModel
        {
            public int Address { get; set; }
        }
    }
}
