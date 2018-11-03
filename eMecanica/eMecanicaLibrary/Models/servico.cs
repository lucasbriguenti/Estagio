namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.servico")]
    internal partial class servico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        internal servico()
        {
            contareceber = new HashSet<contareceber>();
            produto_servico = new HashSet<produto_servico>();
            servico1 = new HashSet<servico>();
            servico_maodeobra = new HashSet<servico_maodeobra>();
            usuario1 = new HashSet<usuario>();
        }

        [Key]
        internal int ser_id { get; set; }

        [Required]
        [StringLength(15)]
        internal string vei_placa { get; set; }

        internal decimal ser_valortotal { get; set; }

        internal int usu_id { get; set; }

        internal int cli_id { get; set; }

        [StringLength(40)]
        internal string ser_descricao { get; set; }

        [Column(TypeName = "date")]
        internal DateTime ser_dtinicio { get; set; }

        [Column(TypeName = "date")]
        internal DateTime? ser_dtfim { get; set; }

        internal double ser_valortotal_1 { get; set; }

        internal int? ser_id_garantia { get; set; }

        internal virtual cliente cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<contareceber> contareceber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<produto_servico> produto_servico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<servico> servico1 { get; set; }

        internal virtual servico servico2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<servico_maodeobra> servico_maodeobra { get; set; }

        internal virtual usuario usuario { get; set; }

        internal virtual veiculo veiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<usuario> usuario1 { get; set; }
    }
}
