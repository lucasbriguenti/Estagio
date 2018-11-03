namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.contapagar")]
    internal partial class contapagar
    {
        [Key]
        internal int conp_id { get; set; }

        [Column(TypeName = "date")]
        internal DateTime conp_dataemissao { get; set; }

        [Column(TypeName = "date")]
        internal DateTime conp_datavencimento { get; set; }

        [Column(TypeName = "date")]
        internal DateTime? conp_datapagamento { get; set; }

        internal decimal conp_valor { get; set; }

        internal int conp_parcela { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        internal string conp_formapagamento { get; set; }

        internal int? com_id { get; set; }

        internal int? des_id { get; set; }

        internal virtual compra compra { get; set; }

        internal virtual despesa despesa { get; set; }
    }
}
