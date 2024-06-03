//Dependencias
using System;
using delete;
using insert;
using update;
using menusecundario;


namespace menuU
{
    public class menuUsuario
    {
        bool init = false;
        int i;
        insertDato a = new insertDato();
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
                        a.insertDatoidentificacion();
                        break;
                        case 2:
                        deleteDato b = new deleteDato();
                        break;
                        case 3:
                        updateDato c  = new updateDato();
                        break;
                        case 4:
                        continue;
                        case 5:
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
