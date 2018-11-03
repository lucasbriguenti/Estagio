namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.contareceber")]
    internal partial class contareceber
    {
        [Key]
        internal int conr_id { get; set; }

        [Column(TypeName = "date")]
        internal DateTime conr_datavencimento { get; set; }

        internal decimal? conr_valorpago { get; set; }

        internal decimal conr_valor { get; set; }

        internal int conr_parcela { get; set; }

        [Column(TypeName = "date")]
        internal DateTime conr_dataemissao { get; set; }

        [Column(TypeName = "date")]
        internal DateTime? conr_datapagamento { get; set; }

        internal int? ser_id { get; set; }

        internal int? ven_id { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        internal string conr_formapagamento { get; set; }

        internal virtual servico servico { get; set; }

        internal virtual venda venda { get; set; }
    }
}
