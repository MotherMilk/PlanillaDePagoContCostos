using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class InventarioItem
    {
        public string Fecha { get; set; }
        public string Concepto { get; set; }
        public int EntradasCantidad { get; set; }
        public decimal EntradasValorUnitario { get; set; }
        public decimal EntradasValorTotal { get; set; }

        public InventarioItem(string fecha, string concepto, int entradasCantidad, decimal entradasValorUnitario, decimal entradasValorTotal)
        {
            Fecha = fecha;
            Concepto = concepto;
            EntradasCantidad = entradasCantidad;
            EntradasValorUnitario = entradasValorUnitario;
            EntradasValorTotal = entradasValorTotal;
        }
    }
}
