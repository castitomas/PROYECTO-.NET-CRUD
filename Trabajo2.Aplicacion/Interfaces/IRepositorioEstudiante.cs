using Trabajo2.Aplicacion.Entidades;
namespace Trabajo2.Aplicacion.Interfaces;

public interface IRepositorioEstudiante
{
    void ModificarEstudiante(Estudiante estudiante);
    void EliminarEstudiante(int id);
    void AgregarEstudiante(Estudiante estudiante);
    Estudiante? GetEstudiante(int id);
    List<Estudiante> GetEstudiantes();
    List<Curso> GetCursosDeEstudiante(int id);
}