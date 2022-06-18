using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ListarEstudiantesDeCursoUseCase
{
    private readonly IRepositorioCurso _rCursoEstudiante;

    public ListarEstudiantesDeCursoUseCase(IRepositorioCurso rCursoEstudiante)
    {
        _rCursoEstudiante = rCursoEstudiante;
    }

    public List<Estudiante> Ejecutar(int id)
    {
        return _rCursoEstudiante.GetEstudiantesDeCurso(id);
    }
}