namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACAO")]
    public partial class ACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACAO()
        {
            HISTORICO_PEDIDO_ACAO = new HashSet<HISTORICO_PEDIDO_ACAO>();
        }

        [Key]
        public int CODIGO { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO_PEDIDO_ACAO> HISTORICO_PEDIDO_ACAO { get; set; }
    }
}
