namespace GerenciadorPedidos.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GerenciadorPedidosContext : DbContext
    {
        public GerenciadorPedidosContext()
            : base("name=ModeloDados")
        {
        }

        public virtual DbSet<ACAO> ACAO { get; set; }
        public virtual DbSet<FORMA_RECEBIMENTO> FORMA_RECEBIMENTO { get; set; }
        public virtual DbSet<FORMA_REMESSA> FORMA_REMESSA { get; set; }
        public virtual DbSet<HISTORICO_PEDIDO> HISTORICO_PEDIDO { get; set; }
        public virtual DbSet<HISTORICO_PEDIDO_ACAO> HISTORICO_PEDIDO_ACAO { get; set; }
        public virtual DbSet<OPERADOR> OPERADOR { get; set; }
        public virtual DbSet<PEDIDO> PEDIDO { get; set; }
        public virtual DbSet<PEDIDO_PESSOA> PEDIDO_PESSOA { get; set; }
        public virtual DbSet<PERFIL> PERFIL { get; set; }
        public virtual DbSet<PESSOA> PESSOA { get; set; }
        public virtual DbSet<STATUS> STATUS { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<SEQUENCIA_PEDIDO> SEQUENCIA_PEDIDO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ACAO>()
                .HasMany(e => e.HISTORICO_PEDIDO_ACAO)
                .WithRequired(e => e.ACAO1)
                .HasForeignKey(e => e.ACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMA_RECEBIMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<FORMA_RECEBIMENTO>()
                .HasMany(e => e.PEDIDO)
                .WithRequired(e => e.FORMA_RECEBIMENTO1)
                .HasForeignKey(e => e.FORMA_RECEBIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORMA_REMESSA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<FORMA_REMESSA>()
                .HasMany(e => e.PEDIDO)
                .WithRequired(e => e.FORMA_REMESSA1)
                .HasForeignKey(e => e.FORMA_REMESSA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HISTORICO_PEDIDO>()
                .HasMany(e => e.HISTORICO_PEDIDO_ACAO)
                .WithRequired(e => e.HISTORICO_PEDIDO1)
                .HasForeignKey(e => e.HISTORICO_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPERADOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADOR>()
                .Property(e => e.RAMAL)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADOR>()
                .Property(e => e.IDENTIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADOR>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADOR>()
                .HasMany(e => e.HISTORICO_PEDIDO)
                .WithRequired(e => e.OPERADOR1)
                .HasForeignKey(e => e.OPERADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.DOCUMENTOS)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.VALOR)
                .HasPrecision(9, 2);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.DOCUMENTALISTA)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .Property(e => e.OBSERVACOES)
                .IsUnicode(false);

            modelBuilder.Entity<PEDIDO>()
                .HasMany(e => e.HISTORICO_PEDIDO)
                .WithRequired(e => e.PEDIDO1)
                .HasForeignKey(e => e.PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PEDIDO>()
                .HasMany(e => e.PEDIDO_PESSOA)
                .WithRequired(e => e.PEDIDO1)
                .HasForeignKey(e => e.PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PERFIL>()
                .HasMany(e => e.OPERADOR)
                .WithRequired(e => e.PERFIL1)
                .HasForeignKey(e => e.PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PEDIDO_PESSOA)
                .WithRequired(e => e.PESSOA1)
                .HasForeignKey(e => e.PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STATUS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<STATUS>()
                .HasMany(e => e.PEDIDO)
                .WithRequired(e => e.STATUS1)
                .HasForeignKey(e => e.STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .HasMany(e => e.PEDIDO)
                .WithRequired(e => e.TIPO_USUARIO1)
                .HasForeignKey(e => e.TIPO_USUARIO)
                .WillCascadeOnDelete(false);
        }
    }
}
