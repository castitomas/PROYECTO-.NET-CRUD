using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class ModificarCursoUseCase
{
    private readonly IRepositorioCurso _rCurso;

    public ModificarCursoUseCase(IRepositorioCurso rCurso)
    {
        _rCurso = rCurso;
    }

    public void Ejecutar(Curso curso)
    {
        _rCurso.ModificarCurso(curso);
    }
}