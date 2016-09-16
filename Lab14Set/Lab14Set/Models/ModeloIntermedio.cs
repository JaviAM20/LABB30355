using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Set.Models
{
    public class ModeloIntermedio{

        public CLIENTE modeloCLIENTE { get; set; }
        public Telefono modeloTelefono { get; set; }
        public Telefono modeloTelefono2 { get; set; }
        public Cuenta modeloCuenta { get; set; }
        public Cuenta modeloCuenta2 { get; set; }
        public Cuenta modeloCuenta3 { get; set; }
        public List<CLIENTE> listaCLIENTES = new List<CLIENTE>();
        public List<Telefono> listaTelefonos = new List<Telefono>();
        public List<Cuenta> listaCuentas = new List<Cuenta>();


    }
}
