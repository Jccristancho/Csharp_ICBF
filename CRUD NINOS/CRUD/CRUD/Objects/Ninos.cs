using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Objects
{
    public class Ninos
    {
        public int Registro { get; set; }
        public string Nombre_n { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Tipo_sangre { get; set; }
        public string Ciudad_nacimiento { get; set; }
        public int Identificacion_acudiente { get; set; }
        public int Telefono { get; set; }
        public string Direccion_n { get; set; }
        public string EPS { get; set; }
        public int Identificador_Jardin { get; set; }
    }
}
