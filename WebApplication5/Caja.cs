//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Caja
    {
        public int IDCaja { get; set; }
        public int IDCliente { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public string Detalle { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
