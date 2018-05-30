using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Cliente
    {
        [DisplayName("Cod. Cliente")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se debe ingresar un código")]
        public string idcliente { get; set; }

        [DisplayName("Nombre")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se debe ingresar un nombre")]
        public string nombreCia { get; set; }

        [DisplayName("Dirección")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se debe ingresar una dirección")]
        public string direccion { get; set; }

        [DisplayName("País")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se debe seleccionar un país")]
        public string idpais { get; set; }

        [DisplayName("Teléfono")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Se debe ingresar un teléfono")]
        public string telefono { get; set; }

    }
}
