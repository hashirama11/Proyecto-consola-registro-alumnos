//Dependencias
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;


//Referencias
using delete;
using insert;
using update;

namespace menusecundario
{
    public class Menusecundario
    {
        bool init = false;
        int i;
        public void menuDatosU()
        {
            try
            {
                while (!init)
                {
                    Console.WriteLine("Seleccione la accion a realizar");
                    Console.WriteLine($"(1) Ingresar planilla completa de alumno \n (2) Ingresar datos especificos de un alumno");
                    i = Convert.ToInt32(Console.ReadLine());

                    switch (i)
                    {
                        case 1:
                        break;
                        case 2:
                        break;
                    }
                }

            }catch(Exception e){Console.WriteLine(e.Message);}
            
            
            
        }
    }
}