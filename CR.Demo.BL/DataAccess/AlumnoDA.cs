using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Demo.BL.DataAccess
{
    class AlumnoDA
    {
        private readonly dbDemoDataContext dc;
        public AlumnoDA()
        {
            dc = new dbDemoDataContext();
        }

        public IEnumerable<alumno> ListarTodos() {
            var query = from alumno in dc.alumnos
                        select alumno;

            return query;
        }

        public alumno Buscar(int id) {
            var query = from alumno in dc.alumnos
                        where alumno.id.Equals(id)
                        select alumno;

            return query.Single();
        }

        public int Registrar(alumno objAlumno) {
            dc.alumnos.InsertOnSubmit(objAlumno);
            dc.SubmitChanges();

            return objAlumno.id;
        }

        public bool Actualizar(alumno objAlumno) {
            var query = (from alumno in dc.alumnos
                         where alumno.id.Equals(objAlumno.id)
                         select alumno).Single();

            query.nombre = objAlumno.nombre;
            query.apellido = objAlumno.apellido;
            query.edad = objAlumno.edad;

            dc.SubmitChanges();

            return true;
        }

        public bool Eliminar(int id) {
            var query = (from alumno in dc.alumnos
                         where alumno.id.Equals(id)
                         select alumno).Single();

            dc.alumnos.DeleteOnSubmit(query);
            dc.SubmitChanges();

            return true;
        }
    }
}
