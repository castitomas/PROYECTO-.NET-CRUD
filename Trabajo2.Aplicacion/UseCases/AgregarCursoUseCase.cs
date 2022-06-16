using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class AgregarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public AgregarCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public void Ejecutar(Curso curso)
    {
        _rCurso.AgregarCurso(curso);
    }
}