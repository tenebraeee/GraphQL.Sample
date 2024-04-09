using GraphQL.Sample.DB;
using GraphQL.Sample.Services.Buildings;
using GraphQL.Sample.Services.Rooms;
using GraphQL.Sample.Types;
using HotChocolate.AspNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SqlContext>(o => 
        o.UseNpgsql("Server=localhost;Port=5432;Database=GraphQL.Sample;User ID=postgres;Password=1;")
    );

builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IBuildingService, BuildingService>();

builder.Services.AddGraphQLServer()
                .AddSorting()
                .AddProjections()
                .AddFiltering()
                .AddMutationConventions()
                .RegisterService<IBuildingService>()
                .AddQueryType(d => d.Name("Query"))
                    .AddTypeExtension<BuildingQuery>()
                    .AddTypeExtension<RoomQuery>()
                    .AddTypeExtension<EquipmentQuery>()
                .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL().WithOptions(new GraphQLServerOptions
{
    EnableBatching = true, // по умолчанию false
});

app.Run();
