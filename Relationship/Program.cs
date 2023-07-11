using Microsoft.EntityFrameworkCore;
using Releationship.DbConnection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connetionString = builder.Configuration.GetConnectionString("Defaultsql");
builder.Services.AddDbContext<ReleationDbContext>(options =>
{
    options.UseMySql(connetionString, new MySqlServerVersion(new Version(8, 0, 26)));
    options.EnableSensitiveDataLogging(true);

    // Diðer yapýlandýrmalar
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
