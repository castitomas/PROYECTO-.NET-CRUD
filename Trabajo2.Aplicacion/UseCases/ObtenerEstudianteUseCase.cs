using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ObtenerEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ObtenerEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public Estudiante? Ejecutar(int DNI)
    {
        return _rEstudiante.GetEstudiante(DNI);
    }
}