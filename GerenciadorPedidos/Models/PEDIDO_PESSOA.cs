namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PEDIDO_PESSOA
    {
        [Key]
        public int CODIGO { get; set; }

        public int PESSOA { get; set; }

        public int PEDIDO { get; set; }

        public virtual PEDIDO PEDIDO1 { get; set; }

        public virtual PESSOA PESSOA1 { get; set; }
    }
}
