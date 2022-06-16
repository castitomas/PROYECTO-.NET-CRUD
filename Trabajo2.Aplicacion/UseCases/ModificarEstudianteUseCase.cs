using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ModificarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ModificarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(Estudiante estudiante)
    {
        _rEstudiante.ModificarEstudiante(estudiante);
    }
}