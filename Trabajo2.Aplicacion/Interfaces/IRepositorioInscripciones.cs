using Trabajo2.Aplicacion.Entidades;
namespace Trabajo2.Aplicacion.Interfaces;

public interface IRepositorioInscripcion
{
    void ModificarInscripcion(Inscripcion inscripcion);
    void EliminarInscripcion(int id);
    void AgregarInscripcion(Inscripcion inscripcion);
    Inscripcion? GetInscripcion(int id);
    List<Inscripcion> GetInscripciones();
    List<Auxiliar> GetEstudiantesFinalizo();
    List<Auxiliar> GetEstudiantesNoFinalizo();
}
