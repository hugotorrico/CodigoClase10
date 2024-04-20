using CodigoClase10.Abstractas;
using CodigoClase10.Excepeciones;
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
            try
            {
                SueldoNeto = SueldoBase;
            }
            catch (Exception)
            {
                throw new CalcularSueldoExcepcion();
            }
          
        }

        public override string ObtenerTipoEmpleado()
        {
            return "Consultor Externo";
        }
    }
}
