namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.servico_maodeobra")]
    public partial class servico_maodeobra
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mdo_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ser_id { get; set; }

        public decimal smdo_valor { get; set; }

        public decimal? smdo_desconto { get; set; }

        public virtual maodeobra maodeobra { get; set; }

        public virtual servico servico { get; set; }
    }
}
