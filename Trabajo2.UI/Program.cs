using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Trabajo2.UI.Data;

using Trabajo2.Repositorios;
using Trabajo2.Aplicacion.UseCases;
using Trabajo2.Aplicacion.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//faltan use cases todavia, las listas
builder.Services.AddTransient<AgregarEstudianteUseCase>();
builder.Services.AddTransient<AgregarCursoUseCase>();
builder.Services.AddTransient<AgregarInscripcionUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();
builder.Services.AddTransient<EliminarCursoUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<EliminarInscripcionUseCase>();
builder.Services.AddTransient<ObtenerEstudianteUseCase>();
builder.Services.AddTransient<ObtenerCursoUseCase>();
builder.Services.AddTransient<ObtenerInscripcionUseCase>();
builder.Services.AddTransient<ListarEstudiantesUseCase>();
builder.Services.AddTransient<ListarCursosUseCase>();
builder.Services.AddTransient<ListarInscripcionesUseCase>();
builder.Services.AddTransient<ListarCursosDeEstudianteUseCase>();
builder.Services.AddTransient<ListarEstudiantesDeCursoUseCase>();
builder.Services.AddTransient<ListarEstudiantesFinalizoUseCase>();
builder.Services.AddTransient<ListarEstudiantesSinFinalizarUseCase>();
builder.Services.AddScoped<IRepositorioEstudiante, RepositorioEstudiante>();
builder.Services.AddScoped<IRepositorioCurso, RepositorioCurso>();
builder.Services.AddScoped<IRepositorioInscripcion, RepositorioInscripcion>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
