namespace Trabajo2.Aplicacion.Entidades;

public class Inscripcion
{   
    public int _inscripcionId { get; set; }
    public int EstudianteId { get; set; }
    public int CursoId { get; set; }
    public Estudiante? Estudiante { get; set; }
    public Curso? Curso { get; set; }
    public DateTime fechaInscripcion { get; set; }
}
