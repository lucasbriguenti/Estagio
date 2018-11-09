namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("contaPagar")]
    public partial class contaPagar
    {
        [Key]
        public int conp_id { get; set; }

        public DateTime conp_dataemissao { get; set; }

        public DateTime conp_datavencimento { get; set; }

        public DateTime? conp_datapagamento { get; set; }

        public decimal conp_valor { get; set; }

        public int conp_parcela { get; set; }

        [Required]
        [StringLength(1)]
        public string conp_formapagamento { get; set; }

        public int? com_id { get; set; }

        public int? des_id { get; set; }

        public virtual compra compra { get; set; }

        public virtual despesa despesa { get; set; }
    }
}
