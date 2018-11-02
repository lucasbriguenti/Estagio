namespace eMecanica.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Common;
    using MySql.Data.EntityFramework;
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        #region dbsets
        public virtual DbSet<cidade> cidade { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<cliente_pf> cliente_pf { get; set; }
        public virtual DbSet<cliente_pj> cliente_pj { get; set; }
        public virtual DbSet<compra> compra { get; set; }
        public virtual DbSet<contapagar> contapagar { get; set; }
        public virtual DbSet<contareceber> contareceber { get; set; }
        public virtual DbSet<despesa> despesa { get; set; }
        public virtual DbSet<endereco> endereco { get; set; }
        public virtual DbSet<estado> estado { get; set; }
        public virtual DbSet<fornecedor> fornecedor { get; set; }
        public virtual DbSet<maodeobra> maodeobra { get; set; }
        public virtual DbSet<marca> marca { get; set; }
        public virtual DbSet<modelo> modelo { get; set; }
        public virtual DbSet<produto> produto { get; set; }
        public virtual DbSet<produto_compra> produto_compra { get; set; }
        public virtual DbSet<produto_servico> produto_servico { get; set; }
        public virtual DbSet<produto_venda> produto_venda { get; set; }
        public virtual DbSet<servico> servico { get; set; }
        public virtual DbSet<servico_maodeobra> servico_maodeobra { get; set; }
        public virtual DbSet<unidade> unidade { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<veiculo> veiculo { get; set; }
        public virtual DbSet<venda> venda { get; set; }
        #endregion
        #region modelcriating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cidade>()
                .Property(e => e.cid_nome)
                .IsUnicode(false);

            modelBuilder.Entity<cidade>()
                .Property(e => e.cid_cod)
                .IsUnicode(false);

            modelBuilder.Entity<cidade>()
                .HasMany(e => e.endereco)
                .WithRequired(e => e.cidade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.cli_nome)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.cli_email)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.cli_tipo)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.cli_celular)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .Property(e => e.cli_telfixo)
                .IsUnicode(false);

            modelBuilder.Entity<cliente>()
                .HasOptional(e => e.cliente_pf)
                .WithRequired(e => e.cliente)
                .WillCascadeOnDelete();

            modelBuilder.Entity<cliente>()
                .HasOptional(e => e.cliente_pj)
                .WithRequired(e => e.cliente);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.servico)
                .WithRequired(e => e.cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.veiculo)
                .WithRequired(e => e.cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cliente>()
                .HasMany(e => e.venda)
                .WithRequired(e => e.cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cliente_pf>()
                .Property(e => e.cli_cpf)
                .IsUnicode(false);

            modelBuilder.Entity<cliente_pf>()
                .Property(e => e.cli_rg)
                .IsUnicode(false);

            modelBuilder.Entity<cliente_pf>()
                .Property(e => e.cli_sexo)
                .IsUnicode(false);

            modelBuilder.Entity<cliente_pj>()
                .Property(e => e.cli_cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<cliente_pj>()
                .Property(e => e.cli_iestadual)
                .IsUnicode(false);

            modelBuilder.Entity<cliente_pj>()
                .Property(e => e.cli_razaosocial)
                .IsUnicode(false);

            modelBuilder.Entity<compra>()
                .HasMany(e => e.produto_compra)
                .WithRequired(e => e.compra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<contapagar>()
                .Property(e => e.conp_formapagamento)
                .IsUnicode(false);

            modelBuilder.Entity<contareceber>()
                .Property(e => e.conr_formapagamento)
                .IsUnicode(false);

            modelBuilder.Entity<despesa>()
                .Property(e => e.des_descricao)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.end_rua)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.end_bairro)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.end_complemento)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .Property(e => e.end_referencia)
                .IsUnicode(false);

            modelBuilder.Entity<endereco>()
                .HasMany(e => e.cliente)
                .WithRequired(e => e.endereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<endereco>()
                .HasMany(e => e.fornecedor)
                .WithRequired(e => e.endereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<endereco>()
                .HasMany(e => e.usuario)
                .WithRequired(e => e.endereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estado>()
                .Property(e => e.est_cod)
                .IsUnicode(false);

            modelBuilder.Entity<estado>()
                .Property(e => e.est_nome)
                .IsUnicode(false);

            modelBuilder.Entity<estado>()
                .Property(e => e.est_sigla)
                .IsUnicode(false);

            modelBuilder.Entity<estado>()
                .HasMany(e => e.cidade)
                .WithRequired(e => e.estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.for_nome)
                .IsUnicode(false);

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.for_email)
                .IsUnicode(false);

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.for_razaosocial)
                .IsUnicode(false);

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.for_cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.for_telefone1)
                .IsUnicode(false);

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.for_telefone2)
                .IsUnicode(false);

            modelBuilder.Entity<fornecedor>()
                .HasMany(e => e.compra)
                .WithRequired(e => e.fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<maodeobra>()
                .Property(e => e.mdo_descricao)
                .IsUnicode(false);

            modelBuilder.Entity<maodeobra>()
                .HasMany(e => e.servico_maodeobra)
                .WithRequired(e => e.maodeobra)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<marca>()
                .Property(e => e.mar_nome)
                .IsUnicode(false);

            modelBuilder.Entity<marca>()
                .HasMany(e => e.modelo)
                .WithRequired(e => e.marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<modelo>()
                .Property(e => e.mod_nome)
                .IsUnicode(false);

            modelBuilder.Entity<modelo>()
                .HasMany(e => e.veiculo)
                .WithRequired(e => e.modelo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produto>()
                .Property(e => e.prod_nome)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .Property(e => e.prod_codigo)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .Property(e => e.prod_classeimposto)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .Property(e => e.prod_ncm)
                .IsUnicode(false);

            modelBuilder.Entity<produto>()
                .HasMany(e => e.produto_compra)
                .WithRequired(e => e.produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produto>()
                .HasMany(e => e.produto_servico)
                .WithRequired(e => e.produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<produto>()
                .HasMany(e => e.produto_venda)
                .WithRequired(e => e.produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servico>()
                .Property(e => e.vei_placa)
                .IsUnicode(false);

            modelBuilder.Entity<servico>()
                .Property(e => e.ser_descricao)
                .IsUnicode(false);

            modelBuilder.Entity<servico>()
                .HasMany(e => e.produto_servico)
                .WithRequired(e => e.servico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servico>()
                .HasMany(e => e.servico1)
                .WithOptional(e => e.servico2)
                .HasForeignKey(e => e.ser_id_garantia);

            modelBuilder.Entity<servico>()
                .HasMany(e => e.servico_maodeobra)
                .WithRequired(e => e.servico)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<servico>()
                .HasMany(e => e.usuario1)
                .WithMany(e => e.servico1)
                .Map(m => m.ToTable("servico_mecanico", "estagio").MapLeftKey("ser_id").MapRightKey("usu_id"));

            modelBuilder.Entity<unidade>()
                .Property(e => e.un_unidade)
                .IsUnicode(false);

            modelBuilder.Entity<unidade>()
                .Property(e => e.un_abreviacao)
                .IsUnicode(false);

            modelBuilder.Entity<unidade>()
                .HasMany(e => e.produto)
                .WithRequired(e => e.unidade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usu_nome)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usu_email)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usu_senha)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usu_nivelacesso)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.cli_rg)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.cli_cpf)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usu_telfixo)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usu_celular)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.compra)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.despesa)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.servico)
                .WithRequired(e => e.usuario)
                .HasForeignKey(e => e.usu_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.venda)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<veiculo>()
                .Property(e => e.vei_placa)
                .IsUnicode(false);

            modelBuilder.Entity<veiculo>()
                .Property(e => e.vei_km)
                .IsUnicode(false);

            modelBuilder.Entity<veiculo>()
                .HasMany(e => e.servico)
                .WithRequired(e => e.veiculo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda>()
                .HasMany(e => e.produto_venda)
                .WithRequired(e => e.venda)
                .WillCascadeOnDelete(false);
        }
        #endregion

    }
}
