using GraphQL.Sample.DB;
using GraphQL.Sample.DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Sample.Services.Buildings
{
    public class BuildingService : IBuildingService
    {
        private readonly DbContext _context;


        public BuildingService(
                SqlContext context
            )
        {
            _context = context;
        }


        public IQueryable<Building> GetAll()
        {
            return _context.Set<Building>();
        }
    }
}
