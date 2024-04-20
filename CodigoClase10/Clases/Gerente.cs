using CodigoClase10.Abstractas;
using CodigoClase10.Estaticas;
using CodigoClase10.Excepeciones;
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
            try
            {
                Bonificacion = Constante.Bonificacion2;
            }
            catch (Exception)
            {
                throw new CalcularBonificacionExcepcion();
            }
           
        }
       
        public override void CalcularSueldo()
        {
            try
            {
                int numero = 12;
                int divisor = 0;
                int resultado = numero / divisor;
                SueldoNeto = SueldoBase + Bonificacion - Descuento;
            }
            catch (Exception)
            {
                throw new CalcularSueldoExcepcion();

            }
            
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

        public void CalcularDescuento()
        {
            Descuento = SueldoBase * Constante.Descuento2;
        }
    }
}
