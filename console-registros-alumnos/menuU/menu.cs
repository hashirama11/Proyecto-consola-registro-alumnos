//Dependencias
using System;
using delete;
using insert;
using update;


namespace menuU
{
    public class menuUsuario
    {
        bool init = false;
        int i;
        public menuUsuario()
        {
            try
            {
                while (!init)
                {
                    Console.WriteLine($"Seleccione una opcion del Menu");
                    Console.WriteLine("(1) Ingresar un nuevo ALUMNO\n(2) Eliminar Alumno existente\n(3) Actualizar lo datos de un Alumno\n(4) Mostrar Registros\n(5)Terminar Programa");
                    i = Convert.ToInt32(Console.ReadLine());
                    switch(i)
                    {
                        case 1:
                        insertDato a = new insertDato();
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
                        init = !init;
                        break;
                    }
                }

            }catch(Exception e){Console.WriteLine(e.Message);}  

        }
    }
}
