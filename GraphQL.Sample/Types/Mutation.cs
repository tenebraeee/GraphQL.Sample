using GraphQL.Sample.DB;
using GraphQL.Sample.DB.Entities;
using Mapster;

namespace GraphQL.Sample.Types
{
    public class Mutation
    {
        [UseMutationConvention]
        public async Task<Building> Building([Service] SqlContext context, BuildingModel model)
        {
            var building = model.Adapt<Building>();

            await context.AddAsync(building);
            await context.SaveChangesAsync();

            return building;
        }
    }

    public class BuildingModel
    {
        public string Address { get; set; }
    }
}
