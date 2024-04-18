using CodigoClase10.Abstractas;
using CodigoClase10.Estaticas;
using CodigoClase10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10.Clases
{
    class GerenteRRHH : EmpleadoBase,ISueldoBonificable,IDescuentoImpuesto
    {
        public override double SueldoBase => 6000;
        public double Bonificacion { get; set; }
        public double Descuento { get; set; }

        public void CalcularBonificacion()
        {
            Bonificacion = Constante.Bonificacion1;
        }

        public override void CalcularSueldo()
        {
            SueldoNeto = SueldoBase + Bonificacion -Descuento;
        }

        public void DescontarSueldo()
        {
            Descuento = SueldoBase * Constante.Descuento1;


        }

        public override string ObtenerTipoEmpleado()
        {
            return "Gerente RRHH";
        }
    }
}
