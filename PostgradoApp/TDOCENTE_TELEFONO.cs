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
    
    public partial class TDOCENTE_TELEFONO
    {
        public int id { get; set; }
        public Nullable<int> id_docente { get; set; }
        public string numero_movil { get; set; }
    
        public virtual TDOCENTE TDOCENTE { get; set; }
    }
}
