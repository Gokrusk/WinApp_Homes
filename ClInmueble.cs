using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_Homes
{
    internal class ClInmueble
    {
        public ClInmueble()
        {
            this.estadoVenta = "DISPONIBLE";
        }

        public void GenerarCodigo(int num)
        {
            this.codigo = this.tipo + '_' + num.ToString();
        }

        public string codigo { get; set; }
        public string tipo { get; set; }
        public float precio { get; set; }
        public string ubicacion { get; set; }
        public string estadoVenta { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
    }
}
