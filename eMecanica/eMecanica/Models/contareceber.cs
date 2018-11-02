namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.contareceber")]
    public partial class contareceber
    {
        [Key]
        public int conr_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime conr_datavencimento { get; set; }

        public decimal? conr_valorpago { get; set; }

        public decimal conr_valor { get; set; }

        public int conr_parcela { get; set; }

        [Column(TypeName = "date")]
        public DateTime conr_dataemissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? conr_datapagamento { get; set; }

        public int? ser_id { get; set; }

        public int? ven_id { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string conr_formapagamento { get; set; }

        public virtual servico servico { get; set; }

        public virtual venda venda { get; set; }
    }
}
