using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using Clases_Abstractas;
using Exepciones;
namespace TestUnitario
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Testeo de la excepcion DniIncalidoException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void verificarDni()
        {
          
            Alumno a1 = new Alumno(1, "Alexis", "Rodriguez", "123456789", Clases_Abstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.AlDia);
            
        }
        /// <summary>
        /// Testeo de la excepcion NacionalidadInvalidaException
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void validarNacionalidad()
        {
            Alumno a2 = new Alumno(2, "Kevin", "Ossa", "27548986", Clases_Abstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD, Alumno.EEstadoCuenta.Becado);
        }
        /// <summary>
        /// Testeo de la lista de una universidad no sea null
        /// </summary>
        [TestMethod]
        public void validarListaProfesores()
        {
            Universidad universidad = new Universidad();
            Assert.IsNotNull(universidad.Instructores);
        }
    }
}
