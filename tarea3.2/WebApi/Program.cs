var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

//app.UseHttpsRedirection(); // Esta línea la he declarado como comentario para deshabilitar la redirección a HTTPS

// Agrega un endpoint que devuelva todos los formatos de fecha
app.MapGet("/", () => {
    var fechaService = new Servicio.Conversiones.FechaService();
    return new {
        FechaFormatoCorto = fechaService.ObtenerFechaFormatoCorto(),
        FechaFormatoLargo = fechaService.ObtenerFechaFormatoLargo(),
        FechaFormatoISO = fechaService.ObtenerFechaFormatoISO()
    };
}).WithName("GetAllFormats");


app.Run();