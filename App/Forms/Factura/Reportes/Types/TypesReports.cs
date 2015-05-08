using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Forms.Factura.Reportes.Types
{
    class TypesReports
    {
    }

    public class VendedorDataSourceReports
    {
        public string Codigo { get; set; }

        public string Tipo { get; set; }

        public string Nombre { get; set; }

        public int Mes { get; set; }

        public decimal Comision { get; set; }

        public decimal VentasMensual { get; set; }

        public decimal VentasAcum { get; set; }
    }
}
