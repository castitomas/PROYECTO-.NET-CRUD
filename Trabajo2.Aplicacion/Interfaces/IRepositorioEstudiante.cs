using Trabajo2.Aplicacion.Entidades;
namespace Trabajo2.Aplicacion.Interfaces;

public interface IRepositorioEstudiante
{
    void ModificarEstudiante(Estudiante estudiante);
    void EliminarEstudiante(int id);
    void AgregarEstudiante(Estudiante estudiante);
    Estudiante? GetEstudiante(int DNI);
    List<Estudiante> GetEstudiantes();
    // List<Estudiante> GetEstudiantesFinalizo();
    // List<Estudiante> GetEstudiantesNoFinalizo();
    // List<Curso> GetCursosEstudiante(int DNI);
}