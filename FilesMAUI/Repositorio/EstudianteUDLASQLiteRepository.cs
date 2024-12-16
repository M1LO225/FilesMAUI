using FilesMAUI.Interfaces;
using FilesMAUI.Modelos;
using SQLite;

namespace FilesMAUI.Repositorio
{
    public class EstudianteUDLASQLiteRepository : IEstudianteUdlaRepository
    {
        private static string NombreBD = "EstudianteUDLA.db3";
        private SQLiteConnection _connection;


        public EstudianteUDLASQLiteRepository()
        {
            Init();
        }

        public void Init()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, NombreBD);
            _connection = new SQLiteConnection(dbPath);

            _connection.CreateTable<EstudianteUdla>();

        }


        public bool ActualizarEstudianteUdla(EstudianteUdla estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUdla(EstudianteUdla estudiante)
        {
            try
            {
                int insert = _connection.Insert(estudiante);
                if (insert > 0)
                {
                    return true;
                }
                return false;

            }
            catch 
            { 
                throw;
            }
            



        }

        public IEnumerable<EstudianteUdla> DevueleListadoEstudiantes()
        {
            var listadoEstudiante =  _connection.Table<EstudianteUdla>().ToList();
            return listadoEstudiante;
        }

        public EstudianteUdla DevuelveEstudianteUdla(int id)
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUdla(int id)
        {
            

            try
            {
                int eliminar = _connection.Delete(id);
                if (eliminar > 0)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                throw;
            }
        }
    }
}
