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
    
    public partial class PRODUCTOR
    {
        public PRODUCTOR()
        {
            this.POSTULACION = new HashSet<POSTULACION>();
            this.PRODUCTOS = new HashSet<PRODUCTOS>();
            this.VENTAS = new HashSet<VENTAS>();
        }
    
        public decimal PRODUCTORID { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONO { get; set; }
        public string CORREO { get; set; }
    
        public virtual ICollection<POSTULACION> POSTULACION { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
        public virtual ICollection<PRODUCTOS> PRODUCTOS { get; set; }
        public virtual ICollection<VENTAS> VENTAS { get; set; }
    }
}
