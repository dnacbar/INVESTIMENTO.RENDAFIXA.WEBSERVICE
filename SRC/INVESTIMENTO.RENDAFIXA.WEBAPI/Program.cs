using DN.LOG.LIBRARY.MIDDLEWARE;
using INVESTIMENTO.RENDAFIXA.WEBAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
ServicoInjecaoDeDependencia.AddServiceCollection(builder);

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
else
{
    app.UseBadRequestExceptionMiddleware()
       .UseBadGatewayExceptionMiddleware()
       .UseNotFoundExceptionMiddleware()
       .UseDataBaseExceptionMiddleware()
       .UseFatalExceptionMiddleware();
}

//app.UseAuthorization();

app.MapControllers();

app.Run();
