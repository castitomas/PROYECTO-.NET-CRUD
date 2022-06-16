using Trabajo2.Aplicacion.Interfaces;
namespace Trabajo2.Aplicacion.UseCases;

public class EliminarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;

    public EliminarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }

    public void Ejecutar(int id)
    {
        _rInscripcion.EliminarInscripcion(id);
    }
}