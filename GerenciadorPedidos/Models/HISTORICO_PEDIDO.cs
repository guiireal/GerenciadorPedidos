namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HISTORICO_PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HISTORICO_PEDIDO()
        {
            HISTORICO_PEDIDO_ACAO = new HashSet<HISTORICO_PEDIDO_ACAO>();
        }

        [Key]
        public int CODIGO { get; set; }

        public DateTime DATA_FATO { get; set; }

        public int PEDIDO { get; set; }

        public int OPERADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO_PEDIDO_ACAO> HISTORICO_PEDIDO_ACAO { get; set; }

        public virtual PEDIDO PEDIDO1 { get; set; }

        public virtual OPERADOR OPERADOR1 { get; set; }
    }
}
