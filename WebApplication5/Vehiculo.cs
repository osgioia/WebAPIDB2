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
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.Servicio = new HashSet<Servicio>();
        }
    
        public int IDVehiculo { get; set; }
        public string Marca { get; set; }
        public Nullable<int> Anio { get; set; }
        public string Chasis { get; set; }
        public string Motor { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<long> Km { get; set; }
        public int IDCliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
