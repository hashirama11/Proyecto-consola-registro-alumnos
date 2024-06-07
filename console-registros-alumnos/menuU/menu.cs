//Dependencias
using System;
using delete;
using insert;
using update;
using select;
using menusecundario;
using funciones;

namespace menuU
{
    public class menuUsuario
    {
        bool init = false;
        int i;
        insertDato a = new insertDato();

        funcionesProyecto conteo = new funcionesProyecto();
        public menuUsuario()
        {
            try
            {
                while (!init)
                {
                    Console.WriteLine($"Seleccione una opcion del Menu");
                    Console.WriteLine("(1) Ingresar un nuevo ALUMNO\n(2) Eliminar Alumno existente\n(3) Actualizar lo datos de un Alumno\n(4) Mostrar Registros\n(5)Ingresar notas de los alumnos registrados\n(6)Terminar Programa");
                    i = Convert.ToInt32(Console.ReadLine());
                    switch(i)
                    {
                        case 1:
                        conteo.conteoRegistros();
                        a.insertDatoidentificacion();
                        break;
                        case 2:
                        conteo.conteoRegistros();
                        deleteDato b = new deleteDato();
                        break;
                        case 3:
                        conteo.conteoRegistros();
                        updateDato c  = new updateDato();
                        break;
                        case 4:
                        conteo.muestraIden();
                        break;
                        case 5:
                        conteo.conteoRegistros();
                        a.insertDatomaterias();
                        break;
                        case 6:
                        init = !init;
                        break;
                    }
                }

            }catch(Exception e){Console.WriteLine(e.Message);}  

        }
    }
}
