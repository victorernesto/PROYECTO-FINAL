//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentaDeMotos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROVEDORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVEDORES()
        {
            this.VENTA = new HashSet<VENTA>();
            this.VENTA1 = new HashSet<VENTA>();
        }
    
        public int ID_PROVEDOR { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public Nullable<int> ID_DATOS { get; set; }
    
        public virtual DATOS DATOS { get; set; }
        public virtual DATOS DATOS1 { get; set; }
        public virtual DATOS DATOS2 { get; set; }
        public virtual DATOS DATOS3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA> VENTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTA> VENTA1 { get; set; }
    }
}