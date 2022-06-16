using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Repositorios;

public class RepositorioInscripcion : IRepositorioInscripcion
{
    public void AgregarInscripcion(Inscripcion inscripcion)
    {
        using (var db = new Trabajo2Context())
        {
            db.Inscripciones.Update(inscripcion);
            db.SaveChanges(); 
        }
    }

    public void ModificarInscripcion(Inscripcion inscripcion)
    {
        using (var db = new Trabajo2Context())
        {
            var inscripcionModificar = db.Inscripciones.Where(
                i => i.Estudiante._estudianteId == inscripcion.Estudiante._estudianteId && i.Curso._cursoId == inscripcion.Curso._cursoId).SingleOrDefault();
            if (inscripcionModificar != null)
            {
                inscripcionModificar.fechaInscripcion = inscripcion.fechaInscripcion;
            }   
            db.SaveChanges();
        }
    }   

    public void EliminarInscripcion(int id)
    {
        using (var db = new Trabajo2Context())
        {
            var inscripcionBorrar = db.Inscripciones.Where(i => i._inscripcionId == id).SingleOrDefault();
            if (inscripcionBorrar != null)
            {
                db.Remove(inscripcionBorrar);
            }
            db.SaveChanges();
        }
    }

    public Inscripcion? GetInscripcion(int id)
    {
        using (var db = new Trabajo2Context())
        {
            var inscripcionEncontrar = db.Inscripciones.Where(i => i._inscripcionId == id).SingleOrDefault();
            if (inscripcionEncontrar != null)
            {
                return inscripcionEncontrar;
            }
            return null;
        }
    }

    public List<Inscripcion> GetInscripciones()
    {
        var listaInscripciones = new List<Inscripcion>();
        using (var db = new Trabajo2Context())
        {
            foreach(Inscripcion i in db.Inscripciones)
            {
                listaInscripciones.Add(i);
            }
        }
        return listaInscripciones;
    }
}
