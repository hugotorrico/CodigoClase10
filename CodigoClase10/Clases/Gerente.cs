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
    internal class Gerente : EmpleadoBase,ISueldoBonificable,IDescuentoImpuesto
    {
        public override double SueldoBase => 8000;
        public double Bonificacion { get; set; }
        public double Descuento { get; set; }


        public void CalcularBonificacion()
        {
            Bonificacion = Constante.Bonificacion2;
        }
       
        public override void CalcularSueldo()
        {
            
            SueldoNeto = SueldoBase+Bonificacion-Descuento;
        }

        public override string ObtenerTipoEmpleado()
        {
            return "Gerente";
        }


        public override void MostrarDetalles()
        {
            //Base: Hace referencia al padre
            base.MostrarDetalles();
            Console.WriteLine($"Bonificacion: {Bonificacion}");
            //Console.WriteLine($"Nombre: {Nombre}, ID Empleado: {IdEmpleado}, Puesto: {Puesto}, SueldoNeto: {SueldoNeto}, Bonificación: {Bonificacion}");
        }

        public void DescontarSueldo()
        {
            Descuento = SueldoBase * Constante.Descuento2;
        }
    }
}
