namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.produto_venda")]
    public partial class produto_venda
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ven_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prod_id { get; set; }

        public decimal pv_valor { get; set; }

        public int pv_quantidade { get; set; }

        public decimal? pv_desconto { get; set; }

        public virtual produto produto { get; set; }

        public virtual venda venda { get; set; }
    }
}
