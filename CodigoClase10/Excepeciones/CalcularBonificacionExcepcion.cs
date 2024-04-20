using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10.Excepeciones
{
    public class CalcularBonificacionExcepcion : Exception
    {
        public string Mensaje { get; set; }
        public CalcularBonificacionExcepcion()
        {
            Mensaje = "Error al Calcular Bonificacion";
        }
    }
}
