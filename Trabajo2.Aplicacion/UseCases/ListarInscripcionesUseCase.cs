using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ListarInscripcionesUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ListarInscripcionesUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public List<Inscripcion> Ejecutar()
    {
        return _rInscripcion.GetInscripciones();
    }
}