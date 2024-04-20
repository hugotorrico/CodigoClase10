using CodigoClase10.Clases;
using CodigoClase10.Excepeciones;
using CodigoClase10.Interfaces;


//Declaración Variables
List<IEmpleado> empleados = null;


try
{

    //Instancias
    empleados = new List<IEmpleado>
        {
            new Gerente { Nombre = "Juan Pérez", IdEmpleado = 1, Puesto = "Gerente" },
            new Desarrollador { Nombre = "María López", IdEmpleado = 2, Puesto = "Desarrollador" },
            new GerenteRRHH{Nombre="Reyna Victoria", IdEmpleado=3,Puesto="Gerente de RRHH"},
            new ConsultorExterno{ Nombre="Hugo Torrico",IdEmpleado=4, Puesto="Consultor Externo"}
        };

    foreach (var empleado in empleados)
    {

        if (empleado is ISueldoBonificable empleadoBonificable)
        {
            empleadoBonificable.CalcularBonificacion();
        }
        if (empleado is IDescuentoImpuesto empleadoDescontado)
        {
            empleadoDescontado.CalcularDescuento();
        }
        empleado.CalcularSueldo();
        empleado.MostrarDetalles();

        Console.WriteLine();
    }
   

}
catch (CalcularBonificacionExcepcion ex)
{
    Console.WriteLine(ex.Mensaje);
}
catch (CalcularSueldoExcepcion ex)
{
    Console.WriteLine(ex.Mensaje);
}
catch (Exception ex)
{   
    Console.WriteLine("Error Comunicarse con el Administrador");

}

finally
{
    empleados = null;    
    Console.Read();
}

