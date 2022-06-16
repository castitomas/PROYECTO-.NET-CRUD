using Trabajo2.Aplicacion.Entidades;
namespace Trabajo2.Aplicacion.Interfaces;

public interface IRepositorioCurso
{
    void AgregarCurso(Curso curso);
    void ModificarCurso(Curso curso);
    void EliminarCurso(int id);
    Curso? GetCurso(int id);
    List<Curso> GetCursos();
    // List<Estudiante> GetEstudiantesCurso(string titulo);
}
