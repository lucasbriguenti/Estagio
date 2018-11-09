namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class produto_nota
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string not_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prod_id { get; set; }

        public int pn_qtde { get; set; }

        public decimal pn_valor { get; set; }

        public decimal pn_valortributo { get; set; }

        public int pn_csosn { get; set; }

        [Required]
        [StringLength(4)]
        public string pn_cfop { get; set; }

        public virtual notaFiscal notaFiscal { get; set; }

        public virtual produto produto { get; set; }
    }
}
