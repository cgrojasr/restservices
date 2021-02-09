using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CR.Demo.REST.Models
{
    public class AlumnoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
}