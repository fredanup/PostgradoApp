//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostgradoApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TMAESTRIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TMAESTRIA()
        {
            this.TDOCENTE_MAESTRIA = new HashSet<TDOCENTE_MAESTRIA>();
        }
    
        public int id { get; set; }
        public string especialidad { get; set; }
        public string universidad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TDOCENTE_MAESTRIA> TDOCENTE_MAESTRIA { get; set; }
    }
}
