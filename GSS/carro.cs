//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSS
{
    using System;
    using System.Collections.Generic;
    
    public partial class carro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carro()
        {
            this.alquiler = new HashSet<alquiler>();
        }
    
        public string placa { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public double costo { get; set; }
        public string disponible { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<alquiler> alquiler { get; set; }
    }
}