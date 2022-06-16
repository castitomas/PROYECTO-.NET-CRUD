using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ObtenerCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public ObtenerCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public Curso? Ejecutar(int id)
    {
        return _rCurso.GetCurso(id);
    }
}