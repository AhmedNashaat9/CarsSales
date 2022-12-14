
using CarSales.Application.DebendencyInjection;
using Hangfire;

var builder = WebApplication.CreateBuilder(args);
DI.OurServices(builder.Services);
builder.Services.AddHangfire(x => x.UseSqlServerStorage("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarSalesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
builder.Services.AddHangfireServer();

builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy("corspolicy", build=>{
    build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("corspolicy");

app.UseHttpsRedirection();
app.UseHangfireDashboard("/DashBoard");

app.MapControllers();


app.Run();

