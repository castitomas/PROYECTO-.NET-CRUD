using Microsoft.EntityFrameworkCore;
using Trabajo2.Aplicacion.Entidades;

namespace Trabajo2.Repositorios;
public class Trabajo2Context : DbContext
{
    #nullable disable
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    #nullable restore  

    public Trabajo2Context()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source= Trabajo2Integrador.sqlite");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>().ToTable("Estudiantes");
        modelBuilder.Entity<Estudiante>()
                        .HasKey(e => e._estudianteId);

        modelBuilder.Entity<Curso>().ToTable("Cursos");
        modelBuilder.Entity<Curso>()
                        .HasKey(c => c._cursoId);
        
        modelBuilder.Entity<Inscripcion>().ToTable("Inscripciones");
        modelBuilder.Entity<Inscripcion>()
                        .HasKey(i => i._inscripcionId);

        modelBuilder.Entity<Inscripcion>()
                        .HasOne<Estudiante>()
                        .WithMany()
                        .HasForeignKey(e => e.EstudianteId); 

        modelBuilder.Entity<Inscripcion>()
                        .HasOne<Curso>()
                        .WithMany()
                        .HasForeignKey(c => c.CursoId);         
    }
}
