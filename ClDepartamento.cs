using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_Homes
{
    internal class ClDepartamento
    {
        public ClDepartamento()
        {
            this.estadoVenta = "DISPONIBLE";
        }

        public void GenerarCodigo()
        {
            this.codigo = this.tipo.Substring(0, 3) + '_' + this.nombre.Substring(0,5);
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
