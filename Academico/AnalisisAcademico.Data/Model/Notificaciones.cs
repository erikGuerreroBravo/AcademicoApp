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
    
    public partial class Notificaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notificaciones()
        {
            this.Mensajes = new HashSet<Mensajes>();
        }
    
        public int idNotificacion { get; set; }
        public Nullable<int> idSegPersonal { get; set; }
        public Nullable<int> idSolicitud { get; set; }
        public string strNotificacion { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mensajes> Mensajes { get; set; }
        public virtual SegPersonalAdministrativo SegPersonalAdministrativo { get; set; }
        public virtual Solicitud Solicitud { get; set; }
    }
}
