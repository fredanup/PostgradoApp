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
    
    public partial class TDICTAMEN_INGRESADOVIEW
    {
        public int id { get; set; }
        public string Alumno { get; set; }
        public string Dictaminante { get; set; }
        public string Asunto { get; set; }
        public string Destinatario { get; set; }
        public System.DateTime Fecha_de_emisión { get; set; }
        public byte[] Foto_de_dictamen { get; set; }
        public System.DateTime Fecha_de_ingreso { get; set; }
        public bool Apto { get; set; }
        public string Detalle { get; set; }
    }
}
