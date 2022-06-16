using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class EliminarEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public EliminarEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public void Ejecutar(int id)
    {
        _rEstudiante.EliminarEstudiante(id);
    }
}