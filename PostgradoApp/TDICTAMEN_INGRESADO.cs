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
    
    public partial class TDICTAMEN_INGRESADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TDICTAMEN_INGRESADO()
        {
            this.TDICTAMEN_DEVUELTO = new HashSet<TDICTAMEN_DEVUELTO>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_alumno { get; set; }
        public Nullable<int> id_dictaminante { get; set; }
        public string asunto { get; set; }
        public string destinatario { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public byte[] foto_dictamen { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public bool apto { get; set; }
    
        public virtual TALUMNO TALUMNO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TDICTAMEN_DEVUELTO> TDICTAMEN_DEVUELTO { get; set; }
        public virtual TDOCENTE TDOCENTE { get; set; }
    }
}
