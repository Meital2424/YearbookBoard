using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Repositorys;
using YearbookBoard.Core.Services;
using YearbookBoard.Data;
using YearbookBoard.Data.Repository;
using YearbookBoard.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //builder.Services.AddSingleton<DataContext>();
        builder.Services.AddDbContext<DataContext>();
        builder.Services.AddScoped<IEventRepository, EventRepository>();
        builder.Services.AddScoped<ITelephoneBoardRepository, TelephoneBoardRepository>();
        builder.Services.AddScoped<IUpdatesRepository, UpdatesRepository>();
        builder.Services.AddScoped<IEventService, EventService>();
        builder.Services.AddScoped<ITelephoneBoardServices, TelephoneBoardService>();
        builder.Services.AddScoped<IUpdatesServices, UpdatesService>();

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
    }
}