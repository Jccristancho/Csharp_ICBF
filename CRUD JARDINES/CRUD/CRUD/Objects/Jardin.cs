using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Modelo { 

        public class Jardin
        {
            public int Identificador_Jardin { get; set; }

            [Required(ErrorMessage = "El nombre del jardín es obligatorio.")]
            public string Nombre_jardin { get; set; }

            [Required(ErrorMessage = "La dirección del jardín es obligatoria.")]
            public string Direccion_j { get; set; }

            [Required(ErrorMessage = "El estado del jardín es obligatorio.")]
            public string Estado { get; set; }
        }
    }
