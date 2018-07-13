namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HISTORICO_PEDIDO_ACAO
    {
        [Key]
        public int CODIGO { get; set; }

        public int HISTORICO_PEDIDO { get; set; }

        public int ACAO { get; set; }

        public virtual ACAO ACAO1 { get; set; }

        public virtual HISTORICO_PEDIDO HISTORICO_PEDIDO1 { get; set; }
    }
}
