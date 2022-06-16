using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class EliminarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public EliminarCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public void Ejecutar(int id)
    {
        _rCurso.EliminarCurso(id);
    }
}