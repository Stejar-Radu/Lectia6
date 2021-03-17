using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie1.models
{
    public class Pasager
    {
        public string Id { get; set; }

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string NumarTelefon { get; set; }

        public List<Ruta> Rute { get; set; }
    }
}
