//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnalisisAcademico.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seguimiento
    {
        public int idBit { get; set; }
        public Nullable<int> idSegUsuario { get; set; }
        public Nullable<bool> bitEtapaUno { get; set; }
        public Nullable<bool> bitEtapaDos { get; set; }
        public Nullable<bool> bitEtapaTres { get; set; }
        public Nullable<bool> bitEtapaCuatro { get; set; }
        public Nullable<bool> bitEtapaCinco { get; set; }
    
        public virtual SegUsuarios SegUsuarios { get; set; }
    }
}