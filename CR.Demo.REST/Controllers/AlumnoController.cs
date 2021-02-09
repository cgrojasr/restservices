using CR.Demo.BL;
using CR.Demo.BL.BusinessLogic;
using CR.Demo.REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CR.Demo.REST.Controllers
{
    public class AlumnoController : ApiController
    {
        private readonly AlumnoBL objAlumnoBL;

        public AlumnoController()
        {
            objAlumnoBL = new AlumnoBL();
        }

        [HttpGet]
        public IHttpActionResult ListarTodos() {
            var result = objAlumnoBL.ListarTodos();
            var response = from alumno in result
                           select new AlumnoModel()
                           {
                               Id = alumno.id,
                               Nombre = alumno.nombre,
                               Apellido = alumno.apellido,
                               Edad = alumno.edad
                           };
            return Ok(response);
        }

        [HttpPost]
        public IHttpActionResult Registrar(alumno objAlumno) {
            var result = objAlumnoBL.Registrar(objAlumno);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult Actualizar(alumno objAlumno)
        {
            var result = objAlumnoBL.Actualizar(objAlumno);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult Buscar(int id)
        {
            var result = objAlumnoBL.Buscar(id);
            var response = new AlumnoModel()
            {
                Id = result.id,
                Nombre = result.nombre,
                Apellido = result.apellido,
                Edad = result.edad
            };
            return Ok(response);
        }

        [HttpDelete]
        public IHttpActionResult Eliminar(int id)
        {
            var result = objAlumnoBL.Eliminar(id);
            return Ok(result);
        }
    }
}
