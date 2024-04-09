using GraphQL.Sample.DB;
using GraphQL.Sample.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Sample.Services.Rooms
{
    public class RoomService : IRoomService
    {
        private readonly DbContext _context;


        public RoomService(
                SqlContext context
            )
        {
            _context = context;
        }


        public IQueryable<Room> GetAll()
        {
            return _context.Set<Room>();
        }
    }
}
