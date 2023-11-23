using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeriaVirtual.Negocio
{
   public class Transporte
    {
        public decimal Transporteid { get; set; }
        public string Tipotransporte { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Estadotransporte { get; set; }
        public MedioTransporte ID { get; set; }


    }
}
