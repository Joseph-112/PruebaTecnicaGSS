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
    
    public partial class alquiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alquiler()
        {
            this.pagos = new HashSet<pagos>();
        }
    
        public int id_alquiler { get; set; }
        public System.DateTime fecha { get; set; }
        public byte tiempo { get; set; }
        public double valor_total { get; set; }
        public double saldo { get; set; }
        public double abono_inicial { get; set; }
        public string devuelto { get; set; }
        public string cedula_cliente { get; set; }
        public string placa_carro { get; set; }
    
        public virtual carro carro { get; set; }
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagos> pagos { get; set; }
    }
}
