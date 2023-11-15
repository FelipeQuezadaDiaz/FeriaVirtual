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
    
    public partial class VENTAS
    {
        public VENTAS()
        {
            this.PAGO = new HashSet<PAGO>();
            this.SUBASTA = new HashSet<SUBASTA>();
            this.VENTA_PRODUCTO = new HashSet<VENTA_PRODUCTO>();
        }
    
        public decimal VENTAID { get; set; }
        public string TIPOVENTA { get; set; }
        public System.DateTime FECHAVENTA { get; set; }
        public decimal TOTALVENTA { get; set; }
        public Nullable<decimal> ESTADOVENTAID { get; set; }
        public Nullable<decimal> TRANSPORTEID { get; set; }
        public decimal PRODUCTORID { get; set; }
        public Nullable<decimal> CLIENTEID { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ESTADOVENTA ESTADOVENTA { get; set; }
        public virtual ICollection<PAGO> PAGO { get; set; }
        public virtual PRODUCTOR PRODUCTOR { get; set; }
        public virtual ICollection<SUBASTA> SUBASTA { get; set; }
        public virtual TRANSPORTE TRANSPORTE { get; set; }
        public virtual ICollection<VENTA_PRODUCTO> VENTA_PRODUCTO { get; set; }
    }
}