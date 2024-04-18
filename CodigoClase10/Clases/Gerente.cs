using CodigoClase10.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10.Clases
{
    internal class Gerente : EmpleadoBase
    {
        public override double SueldoBase => 8000;

        public override void CalcularSueldo()
        {
            throw new NotImplementedException();
        }

        public override string ObtenerTipoEmpleado()
        {
            throw new NotImplementedException();
        }
    }
}
