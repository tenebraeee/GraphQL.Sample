using GraphQL.Sample.DB;
using GraphQL.Sample.Types;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SqlContext>(o => 
        o.UseNpgsql("Server=localhost;Port=5432;Database=GraphQL.Sample;User ID=postgres;Password=1;")
    );

builder.Services.AddGraphQLServer()
                .AddMutationConventions()
                .AddQueryType(d => d.Name("Query"))
                    .AddTypeExtension<BuildingQuery>()
                    .AddTypeExtension<RoomQuery>()
                .AddMutationType<Mutation>();


var app = builder.Build();

app.MapGraphQL();

app.Run();
