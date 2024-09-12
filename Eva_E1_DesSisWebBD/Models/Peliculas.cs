using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eva_E1_DesSisWebBD.Models
{
    public class Peliculas
    {
        public int idPelicula { get; set; }
        public string nombrePelicula { get; set; }
        public int numeroSala { get; set; }
        public string horario { get; set; }
        public string urlPelicula { get; set; }
    }
}