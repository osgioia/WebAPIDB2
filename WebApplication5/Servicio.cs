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
    
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            this.ServicioDetalle = new HashSet<ServicioDetalle>();
        }
    
        public int IDServicio { get; set; }
        public int IDCliente { get; set; }
        public int IDVehiculo { get; set; }
        public Nullable<System.DateTime> FechaServicio { get; set; }
        public Nullable<long> Km { get; set; }
        public Nullable<int> IDEstado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioDetalle> ServicioDetalle { get; set; }
    }
}