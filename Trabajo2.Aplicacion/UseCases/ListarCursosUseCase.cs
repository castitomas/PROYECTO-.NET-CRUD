using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ListarCursosUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public ListarCursosUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public List<Curso> Ejecutar()
    {
        return _rCurso.GetCursos();
    }
}