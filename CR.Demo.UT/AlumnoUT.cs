using CR.Demo.BL.BusinessLogic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CR.Demo.BL;

namespace CR.Demo.UT
{
    [TestClass]
    public class AlumnoUT
    {
        AlumnoBL objAlumnoBL;
        public AlumnoUT()
        {
            objAlumnoBL = new AlumnoBL();
        }

        [TestMethod]
        public void ListarTodos()
        {
            var response = objAlumnoBL.ListarTodos();
            Assert.AreEqual(response.Count(), 1);
        }

        [TestMethod]
        public void Buscar()
        {
            var response = objAlumnoBL.Buscar(1);
            Assert.AreEqual(response.id, 1);
        }

        [TestMethod]
        public void Registrar()
        {
            var objAlumno = new alumno();
            objAlumno.nombre = "Lionel";
            objAlumno.apellido = "Messi";
            objAlumno.edad = 32;

            var response = objAlumnoBL.Registrar(objAlumno);
            Assert.AreEqual(response, 1);
        }

        [TestMethod]
        public void Actualizar()
        {
            var objAlumno = new alumno();
            objAlumno.id = 1;
            objAlumno.nombre = "Lionel";
            objAlumno.apellido = "Messi";
            objAlumno.edad = 33;

            var response = objAlumnoBL.Actualizar(objAlumno);
            Assert.AreEqual(response, true);
        }

        [TestMethod]
        public void Eliminar()
        {
            var response = objAlumnoBL.Eliminar(1);
            Assert.AreEqual(response, true);
        }
    }
}
