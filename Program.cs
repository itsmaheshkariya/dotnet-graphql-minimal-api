using Mahesh.Types;
using Mahesh.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<UserDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"))
);
builder.Services
.AddGraphQLServer()
.AddQueryType<QueryType>()
.AddMutationType<MutationType>();

var app = builder.Build();

app.MapGraphQL();


app.Run();

