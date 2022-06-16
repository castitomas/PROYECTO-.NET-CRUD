using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Repositorios;

public class RepositorioEstudiante: IRepositorioEstudiante
{
    public void AgregarEstudiante(Estudiante estudiante) 
    {
        using (var db = new Trabajo2Context())
        {
            var estudianteAgregar = new Estudiante() { Nombre = estudiante.Nombre, Apellido = estudiante.Apellido, DNI = estudiante.DNI, Email = estudiante.Email};
            db.Estudiantes.Add(estudianteAgregar);
            db.SaveChanges();
        }
    }

    public void ModificarEstudiante(Estudiante estudiante)
    {
        using (var db = new Trabajo2Context())
        {
            var estModificar = db.Estudiantes.Where(
                e => e.DNI == estudiante.DNI).SingleOrDefault();
            if (estModificar != null)
            {
                estModificar.Nombre = estudiante.Nombre;
                estModificar.Apellido = estudiante.Apellido;
                estModificar.Email = estudiante.Email;
            }
            db.SaveChanges();
        }
    }

    public void EliminarEstudiante(int id)
    {
        using (var db = new Trabajo2Context())
        {
            var estBorrar = db.Estudiantes.Where(e => e._estudianteId == id).SingleOrDefault();
            if (estBorrar != null)
            {
                db.Estudiantes.Remove(estBorrar);
            }
            db.SaveChanges();
        }
    }

    public Estudiante? GetEstudiante(int id)
    {
        using (var db = new Trabajo2Context())
        {
            var estEncontrar = db.Estudiantes.Where(e => e._estudianteId == id).SingleOrDefault();
            if (estEncontrar != null)
            {
                return estEncontrar;
            }
            return null;
        }
    }

    public List<Estudiante> GetEstudiantes()
    {
        var listaEstudiantes = new List<Estudiante>();
        using (var db = new Trabajo2Context())
        {
            foreach(Estudiante e in db.Estudiantes)
            {
                listaEstudiantes.Add(e);
            }
        }
        return listaEstudiantes;
    }
}