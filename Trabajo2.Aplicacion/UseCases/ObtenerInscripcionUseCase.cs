using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ObtenerInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ObtenerInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public Inscripcion? Ejecutar(int id)
    {
        return _rInscripcion.GetInscripcion(id);
    }
}