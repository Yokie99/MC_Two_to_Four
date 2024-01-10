using MC_Challenge_Two_to_Four.Services.Sum;
using MC_Challenge_Two_to_Four.Services.WokeUp;
using MC_Challenge_Two_to_Four.Services.GreaterOrLessThan;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISumService, SumService>();
builder.Services.AddScoped<IWokeUpService, WokeUpService>();
builder.Services.AddScoped<IGreaterOrLessThanService, GreaterOrLessThanService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
