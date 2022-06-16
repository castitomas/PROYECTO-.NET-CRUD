using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class AgregarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public AgregarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(Inscripcion inscripcion)
    {
        _rInscripcion.AgregarInscripcion(inscripcion);
    }
}