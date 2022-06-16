using Trabajo2.Aplicacion.Entidades;
using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Repositorios;

public class RepositorioCurso: IRepositorioCurso
{
    public void AgregarCurso(Curso curso)
    {
        using (var db = new Trabajo2Context())
        {
            var cursoAgregar = new Curso() { Titulo = curso.Titulo, Descripcion = curso.Descripcion, FechaDeInicio = curso.FechaDeInicio, FechaDeFinalizacion = curso.FechaDeFinalizacion};
            db.Cursos.Add(cursoAgregar);
            db.SaveChanges();
        }
    }

    public void ModificarCurso(Curso curso)
    {
        using (var db = new Trabajo2Context())
        {
            var cursoModificar = db.Cursos.Where(c => c._cursoId == curso._cursoId).SingleOrDefault();
            if (cursoModificar != null)
            {
                cursoModificar.Titulo = curso.Titulo;
                cursoModificar.Descripcion = curso.Descripcion;
                cursoModificar.FechaDeInicio = curso.FechaDeInicio;
                cursoModificar.FechaDeFinalizacion = curso.FechaDeFinalizacion;
            }
            db.SaveChanges();
        }
    }

    public void EliminarCurso(int id)
    {
        using (var db = new Trabajo2Context())
        {
            var cursoBorrar = db.Cursos.Where(c => c._cursoId == id).SingleOrDefault();
            if (cursoBorrar != null)
            {
                db.Cursos.Remove(cursoBorrar);
            }
            db.SaveChanges();
        }
    }

    public Curso? GetCurso(int id)
    {
        using (var db = new Trabajo2Context())
        {
            var cursoEncontrar = db.Cursos.Where(c => c._cursoId == id).SingleOrDefault();
            if (cursoEncontrar != null)
            {
                return cursoEncontrar;
            }
            return null;
        }
    }

    public List<Curso> GetCursos()
    {
        var listaCursos = new List<Curso>();
        using (var db = new Trabajo2Context())
        {
            foreach(Curso c in db.Cursos)
            {
                listaCursos.Add(c);
            }
        }
        return listaCursos;
    }
}
