using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ListarEstudiantesSinFinalizarUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ListarEstudiantesSinFinalizarUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public List<Auxiliar> Ejecutar()
    {
        return _rInscripcion.GetEstudiantesNoFinalizo();
    }
}