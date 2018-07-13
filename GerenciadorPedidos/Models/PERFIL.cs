namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERFIL")]
    public partial class PERFIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERFIL()
        {
            OPERADOR = new HashSet<OPERADOR>();
        }

        [Key]
        public int CODIGO { get; set; }

        public byte INCLUSAO { get; set; }

        public byte ALTERACAO { get; set; }

        public byte DUPLICACAO { get; set; }

        public byte EXCLUSAO { get; set; }

        public byte GERENCIAPERFIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OPERADOR> OPERADOR { get; set; }
    }
}
