using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie1.models
{
    public enum Clasa
    {
        Economy,
        Business,
        First
    }

    public class Ruta
    {
        public string Id { get; set; }

        public string Destinatie { get; set; }
        public double Pret { get; set; }

        public Clasa Clasa { get; set; }

        public Pasager Pasager { get; set; }
    }
}
