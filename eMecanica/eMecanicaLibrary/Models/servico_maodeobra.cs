namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.servico_maodeobra")]
    internal partial class servico_maodeobra
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int mdo_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int ser_id { get; set; }

        internal decimal smdo_valor { get; set; }

        internal decimal? smdo_desconto { get; set; }

        internal virtual maodeobra maodeobra { get; set; }

        internal virtual servico servico { get; set; }
    }
}
