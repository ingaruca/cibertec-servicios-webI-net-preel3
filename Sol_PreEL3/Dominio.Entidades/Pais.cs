using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace Dominio.Entidades
{
    public class Pais
    {
        [DisplayName("Código")]
        public string idpais { get; set; }

        [DisplayName("País")]
        public string nombrepais { get; set; }
    }
}
