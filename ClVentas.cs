using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_Homes
{
    internal class ClVentas
    {
        public ClVentas() 
        {
          
        }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CodigoInmueble { get; set; }
        public float Mensualidad { get; set; }
        public string NumeroMeses { get; set; } 


    }
}
