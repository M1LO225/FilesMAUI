using FilesMAUI.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesMAUI.Interfaces
{
    public interface IEstudianteUdlaRepository
    {
        IEnumerable<EstudianteUdla> DevueleListadoEstudiantes();
        EstudianteUdla DevuelveEstudianteUdla(int id);
        bool CrearEstudianteUdla(EstudianteUdla estudiante);
        bool ActualizarEstudianteUdla(EstudianteUdla estudiante);
        bool EliminarEstudianteUdla(int id);

    }
}
