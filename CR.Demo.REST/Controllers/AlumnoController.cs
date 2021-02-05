using CR.Demo.BL;
using CR.Demo.BL.BusinessLogic;
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
        AlumnoBL objAlumnoBL;

        public AlumnoController()
        {
            objAlumnoBL = new AlumnoBL();
        }

        [HttpPost]
        public IHttpActionResult Registrar(alumno objAlumno) {
            var result = objAlumnoBL.Registrar(objAlumno);
            return Ok(result);
        }
    }
}
