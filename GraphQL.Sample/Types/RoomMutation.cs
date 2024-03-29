using GraphQL.Sample.DB;
using GraphQL.Sample.DB.Entities;
using Mapster;

namespace GraphQL.Sample.Types
{
    [ExtendObjectType("Mutation")]
    public class RoomMutation
    {
        public async Task<Room> RoomAsync([Service] SqlContext context, RoomModel model)
        {
            var room = model.Adapt<Room>();
            await context.AddAsync(room);
            await context.SaveChangesAsync();

            return room;
        }
    }

    public class RoomModel
    {
        public int Floor { get; set; }
        public Guid BuildingId { get; set; }
    }
}
