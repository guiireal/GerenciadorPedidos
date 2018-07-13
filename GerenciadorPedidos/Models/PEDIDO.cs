namespace GerenciadorPedidos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PEDIDO")]
    public partial class PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PEDIDO()
        {
            HISTORICO_PEDIDO = new HashSet<HISTORICO_PEDIDO>();
            PEDIDO_PESSOA = new HashSet<PEDIDO_PESSOA>();
        }

        [Key]
        public int CODIGO { get; set; }

        public int NUMERO { get; set; }

        public DateTime? REMESSA_CORREIO { get; set; }

        [Required]
        [StringLength(200)]
        public string ENDERECO { get; set; }

        [StringLength(15)]
        public string TELEFONE { get; set; }

        [StringLength(60)]
        public string EMAIL { get; set; }

        public DateTime DATA_PEDIDO { get; set; }

        public DateTime DATA_ATENDIMENTO { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DOCUMENTOS { get; set; }

        public decimal VALOR { get; set; }

        [Required]
        [StringLength(50)]
        public string DOCUMENTALISTA { get; set; }

        [StringLength(255)]
        public string OBSERVACOES { get; set; }

        public int STATUS { get; set; }

        public int FORMA_RECEBIMENTO { get; set; }

        public int FORMA_REMESSA { get; set; }

        public int TIPO_USUARIO { get; set; }

        public virtual FORMA_RECEBIMENTO FORMA_RECEBIMENTO1 { get; set; }

        public virtual FORMA_REMESSA FORMA_REMESSA1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HISTORICO_PEDIDO> HISTORICO_PEDIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDO_PESSOA> PEDIDO_PESSOA { get; set; }

        public virtual STATUS STATUS1 { get; set; }

        public virtual TIPO_USUARIO TIPO_USUARIO1 { get; set; }
    }
}
