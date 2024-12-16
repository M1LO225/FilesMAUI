using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesMAUI.Modelos
{
    [Table ("estudianteUDLA")]
    public class EstudianteUdla
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength (100)]
        public string Nombre { get; set; }
        [MaxLength (100)]
        public string Carrera { get; set; }

    }
}
