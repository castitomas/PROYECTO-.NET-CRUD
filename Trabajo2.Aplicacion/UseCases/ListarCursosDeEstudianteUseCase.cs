using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ListarCursosDeEstudianteUseCase
{
    private readonly IRepositorioEstudiante _rEstudiante;

    public ListarCursosDeEstudianteUseCase(IRepositorioEstudiante rEstudiante)
    {
        _rEstudiante = rEstudiante;
    }

    public List<Curso> Ejecutar(int id)
    {
        return _rEstudiante.GetCursosDeEstudiante(id);
    }
}