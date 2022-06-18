using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ListarEstudiantesFinalizoUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public ListarEstudiantesFinalizoUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public List<Auxiliar> Ejecutar()
    {
        return _rInscripcion.GetEstudiantesFinalizo();
    }
}