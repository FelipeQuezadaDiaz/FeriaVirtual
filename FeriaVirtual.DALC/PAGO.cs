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
    
    public partial class PAGO
    {
        public decimal PAGOID { get; set; }
        public System.DateTime FECHA_PAGO { get; set; }
        public decimal PAGO1 { get; set; }
        public decimal VENTAID { get; set; }
        public decimal USUARIOID { get; set; }
    
        public virtual USUARIOS USUARIOS { get; set; }
        public virtual VENTAS VENTAS { get; set; }
    }
}
