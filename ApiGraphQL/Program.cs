using ApiGraphQL.Schema;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>(); ;


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors();



app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});


app.Run();

