using CodigoClase10.Clases;
using CodigoClase10.Interfaces;



List<IEmpleado> empleados = new List<IEmpleado>
        {
            new Gerente { Nombre = "Juan Pérez", IdEmpleado = 1, Puesto = "Gerente" },
            new Desarrollador { Nombre = "María López", IdEmpleado = 2, Puesto = "Desarrollador" }            
        };

foreach (var empleado in empleados)
{

    if (empleado is ISueldoBonificable empleadoBonificable)
    {
        empleadoBonificable.CalcularBonificacion();
    }
    empleado.CalcularSueldo();
    empleado.MostrarDetalles();

    Console.WriteLine();
}
Console.Read();