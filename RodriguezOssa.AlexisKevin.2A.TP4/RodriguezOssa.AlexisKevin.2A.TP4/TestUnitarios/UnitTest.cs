using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Archivo;
using Entidades;
using Excepciones;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Testeo que se instancie un objeto de tipo PantalonHombre. Implemento la clase 16(Test Unitarios)
        /// </summary>
        [TestMethod]
        public void TesteoDeUnaPantalon()
        {
            PantalonHombre p = new PantalonHombre(10, "pantalon(hombre)", "chupin", 40,325 ,true);
            Assert.IsNotNull(p);
        }
        /// <summary>
        /// Testeo que se genere una excepcion a la hora de leer un archivo en una ruta invalida. Implemento la clase 16(Test Unitarios)
        /// </summary>
        [TestMethod]
        public void TesteoLeerMalTxt()
        {
            Texto texto = new Texto();
            string dato;
            string archivo = "NoExiste.txt";
            try
            {
                texto.Leer(archivo, out dato);
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ArchivoExcepcion));
               
            }
        }
    }
}
