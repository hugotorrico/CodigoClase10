using CodigoClase10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase10.Abstractas
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public string Puesto { get; set; }
        public double SueldoNeto { get; set; }
        public abstract double SueldoBase { get; }

        public string MessageError { get; set; }
      
        //abstract: Obliga que se implemente
        public abstract void CalcularSueldo();

        public abstract string ObtenerTipoEmpleado();
        
        //virtual: Te da la opción a que puedas sobreescribir
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, ID Empleado: {IdEmpleado}, " +
                $"Puesto: {Puesto}, SueldoNeto: {SueldoNeto},: {MessageError}");
        }



    }
}
