//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FeriaVirtual.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class MEDIOTRANSPORTE
    {
        public MEDIOTRANSPORTE()
        {
            this.TRANSPORTE = new HashSet<TRANSPORTE>();
            this.SUBASTA_MEDIO = new HashSet<SUBASTA_MEDIO>();
        }
    
        public decimal MEDIOID { get; set; }
        public string PATENTE { get; set; }
        public decimal ANCHO { get; set; }
        public decimal LARGO { get; set; }
        public decimal ALTO { get; set; }
        public Nullable<decimal> CAPACIDAD { get; set; }
        public Nullable<short> REFRIGERADO { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public decimal TRANSPORTISTAID { get; set; }
    
        public virtual ICollection<TRANSPORTE> TRANSPORTE { get; set; }
        public virtual TRANSPORTISTA TRANSPORTISTA { get; set; }
        public virtual ICollection<SUBASTA_MEDIO> SUBASTA_MEDIO { get; set; }
    }
}
