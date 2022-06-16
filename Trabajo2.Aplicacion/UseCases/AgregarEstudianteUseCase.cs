using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class AgregarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public AgregarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(Estudiante estudiante)
    {
        _rEstudiante.AgregarEstudiante(estudiante);
    }
}