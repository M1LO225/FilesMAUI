using FilesMAUI.Interfaces;
using FilesMAUI.Modelos;
using Newtonsoft.Json;

namespace FilesMAUI.Repositorio
{
    public class EstudianteUdlaPorArchivosRepository : IEstudianteUdlaRepository
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");


        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception) 
            {
                throw;
            }
        }

        public IEnumerable<EstudianteUdla> DevueleListadoEstudiantes()
        {
            throw new NotImplementedException();
        }

        public EstudianteUdla DevuelveEstudianteUdla(int id)
        {
            EstudianteUdla estudiante = new EstudianteUdla();
            if (File.Exists(_fileName)) 
            {
                string json_data = File.ReadAllText(_fileName);
                estudiante = JsonConvert.DeserializeObject<EstudianteUdla>(json_data);
            }
            return estudiante;
        }

        public bool EliminarEstudianteUdla(int id)
        {
            throw new NotImplementedException();
        }
    }
}
