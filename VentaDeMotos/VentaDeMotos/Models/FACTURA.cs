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
    
    public partial class FACTURA
    {
        public int FACTURA_ID { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public Nullable<int> ID_MOTO { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public string FECHA { get; set; }
        public string EMPRESA { get; set; }
    
        public virtual CLIENTES CLIENTES { get; set; }
        public virtual CLIENTES CLIENTES1 { get; set; }
        public virtual MOTO MOTO { get; set; }
    }
}
