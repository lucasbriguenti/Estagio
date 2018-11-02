namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.produto_servico")]
    public partial class produto_servico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ser_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prod_id { get; set; }

        public decimal? ps_desconto { get; set; }

        public int ps_quantidade { get; set; }

        public decimal ps_valorVenda { get; set; }

        public virtual produto produto { get; set; }

        public virtual servico servico { get; set; }
    }
}
