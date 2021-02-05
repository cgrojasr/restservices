using CR.Demo.BL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR.Demo.BL.BusinessLogic
{
    public class AlumnoBL
    {
        private readonly AlumnoDA objAlumnoDA;
        public AlumnoBL()
        {
            objAlumnoDA = new AlumnoDA();
        }

        public IEnumerable<alumno> ListarTodos() {
            return objAlumnoDA.ListarTodos();
        }

        public int Registrar(alumno objAlumno) {
            return objAlumnoDA.Registrar(objAlumno);
        }

        public alumno Buscar(int id) {
            return objAlumnoDA.Buscar(id);
        }

        public bool Actualizar(alumno objAlumno) {
            return objAlumnoDA.Actualizar(objAlumno);
        }

        public bool Eliminar(int id) {
            return objAlumnoDA.Eliminar(id);
        }
    }
}
