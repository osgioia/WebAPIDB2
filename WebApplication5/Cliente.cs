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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Caja = new HashSet<Caja>();
            this.Servicio = new HashSet<Servicio>();
        }
    
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Cuit_DNI { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public int IDTipoCliente { get; set; }
        public string Observacion { get; set; }
        public string Direccion { get; set; }
        public Nullable<bool> Borrado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Caja> Caja { get; set; }
        public virtual TipoCliente TipoCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}