using Microsoft.EntityFrameworkCore;
using Project_01.Data;
using Project_01.Dto;
using Project_01.Endpoints;
using Project_01.Entities;
using Project_01.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDBContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ApplyMigration();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//app.MapPost("article",async(CreateArticleRequest request,AppDBContext context) => {
//    var Article = new Article() { Title=request.Title,Description=request.Description};
//   await context.Articles.AddAsync(Article);
//   await context.SaveChangesAsync();
//    return Results.Ok(Article);
//});
app.MyArticleEndpoints();
app.Run();
