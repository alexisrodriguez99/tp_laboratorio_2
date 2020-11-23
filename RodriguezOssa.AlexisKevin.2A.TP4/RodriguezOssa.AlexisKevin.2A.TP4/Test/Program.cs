using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo;
using Entidades;
using Excepciones;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock miStock = 2;
            PantalonHombre ph = new PantalonHombre(1, "pantalon(hombre)", "modelo1", 42, 230, true);
            PantalonNiño pñ = new PantalonNiño(2, "pantalon(niño)", "modelo2", 16, 260, false);
            PantalonNiño pñ1 = new PantalonNiño(3, "pantalon(niño)", "modelo3", 14, 260, true);
            Texto texto = new Texto();
            string datoDeProducto;

            try
            {
                miStock += ph;
                Console.WriteLine(ph.ToString());

            }
            catch (CapacidadMaximaExcepcion ex)
            {

                Console.WriteLine(ex.InformarError());
            }
            try
            {
                miStock += pñ;
                Console.WriteLine(pñ.ToString());
            }
            catch (CapacidadMaximaExcepcion ex)
            {

                Console.WriteLine(ex.InformarError());
            }
            try
            {
                miStock += pñ1;
                Console.WriteLine(pñ1.ToString());

            }
            catch (CapacidadMaximaExcepcion ex)
            {

                Console.WriteLine(ex.InformarError());
            }
            //miStock -= 1;
            try
            {
                if (texto.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testeo.txt", ph.ToString()))
                {
                Console.WriteLine("Se imprimio correctamente");
            }
            }
            catch (ArchivoExcepcion ex)
            {

                Console.WriteLine(ex.Message);
            }
            
           
            try
            {
                if (texto.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testeo.txt", out datoDeProducto))
                {
                    Console.WriteLine(datoDeProducto);
                    Console.WriteLine("Se cargo correctamente");
                }
            }
            catch (ArchivoExcepcion ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
