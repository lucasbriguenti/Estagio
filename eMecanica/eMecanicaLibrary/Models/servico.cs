namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("servico")]
    public partial class servico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public servico()
        {
            contaReceber = new HashSet<contaReceber>();
            produto_servico = new HashSet<produto_servico>();
            servico1 = new HashSet<servico>();
            servico_maoDeObra = new HashSet<servico_maoDeObra>();
            usuario1 = new HashSet<usuario>();
        }

        [Key]
        public int ser_id { get; set; }

        [Required]
        [StringLength(15)]
        public string vei_placa { get; set; }

        public decimal ser_valortotal { get; set; }

        public int usu_id { get; set; }

        public int cli_id { get; set; }

        [StringLength(40)]
        public string ser_descricao { get; set; }

        public DateTime ser_dtinicio { get; set; }

        public DateTime? ser_dtfim { get; set; }

        public float ser_valortotal_1 { get; set; }

        public int? ser_id_garantia { get; set; }

        public virtual cliente cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contaReceber> contaReceber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto_servico> produto_servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servico> servico1 { get; set; }

        public virtual servico servico2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servico_maoDeObra> servico_maoDeObra { get; set; }

        public virtual usuario usuario { get; set; }

        public virtual veiculo veiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario> usuario1 { get; set; }
    }
}