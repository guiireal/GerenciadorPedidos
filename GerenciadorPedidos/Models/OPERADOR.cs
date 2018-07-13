namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OPERADOR")]
    public partial class OPERADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OPERADOR()
        {
            HISTORICO_PEDIDO = new HashSet<HISTORICO_PEDIDO>();
        }

        [Key]
        public int CODIGO { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(20)]
        public string RAMAL { get; set; }

        [Required]
        [StringLength(20)]
        public string IDENTIFICACAO { get; set; }

        [Required]
        [StringLength(16)]
        public string SENHA { get; set; }

        public int PERFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO_PEDIDO> HISTORICO_PEDIDO { get; set; }

        public virtual PERFIL PERFIL1 { get; set; }
    }
}
