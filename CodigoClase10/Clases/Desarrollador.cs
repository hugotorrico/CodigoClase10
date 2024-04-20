using CodigoClase10.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10.Clases
{
    public class Desarrollador : EmpleadoBase
    {
        public override double SueldoBase => 3000;

        public override void CalcularSueldo()
        {
            try
            {
                SueldoNeto = SueldoBase;
            }
            catch (Exception)
            {
                throw new Exception("Disculpe, Error en Calcular Sueldo");

                
            }
           
        }

        public override string ObtenerTipoEmpleado()
        {
            return "Desarrollador";
        }
    }
}
