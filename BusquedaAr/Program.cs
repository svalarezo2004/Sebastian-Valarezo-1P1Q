using System;
using System.IO;

namespace BusquedaAr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.writeline("hello world!");

            StreamReader lectura;
            string cadena, empleado;
            bool encontrado = false;
            string[] campos = new string[4];
            char[] separador = { '-' };
            Console.ReadKey(true);

            try
            {
                lectura = File.OpenText("sueldos.txt");

                Console.WriteLine("Escriba el nombre a buscar: ");
                empleado = Console.ReadLine();
                cadena = lectura.ReadLine();

                while (cadena != null && encontrado == false)
                {
                    campos = cadena.Split(separador);
                    if (campos[0].Trim().Equals(empleado))
                    {
                        Console.WriteLine("El empleado es: " + campos[0].Trim());
                    }
                }
            }
            catch(FileNotFoundException fe)
            {
                Console.WriteLine("ERROR " + fe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR " + ex.Message);
            }



        }
    }
}
