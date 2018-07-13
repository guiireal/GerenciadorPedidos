namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEQUENCIA_PEDIDO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQUENCIA { get; set; }
    }
}
