namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.contapagar")]
    public partial class contapagar
    {
        [Key]
        public int conp_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime conp_dataemissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime conp_datavencimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? conp_datapagamento { get; set; }

        public decimal conp_valor { get; set; }

        public int conp_parcela { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string conp_formapagamento { get; set; }

        public int? com_id { get; set; }

        public int? des_id { get; set; }

        public virtual compra compra { get; set; }

        public virtual despesa despesa { get; set; }
    }
}
