using CodigoClase10.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10.Clases
{
    public class ConsultorExterno : EmpleadoBase
    {
        public override double SueldoBase => 5000;

        public override void CalcularSueldo()
        {
            SueldoNeto = SueldoBase;
        }

        public override string ObtenerTipoEmpleado()
        {
            return "Consultor Externo";
        }
    }
}
