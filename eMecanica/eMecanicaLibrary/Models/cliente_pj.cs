namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cliente_pj")]
    internal partial class cliente_pj
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        internal int cli_id { get; set; }

        [Required]
        [StringLength(25)]
        internal string cli_cnpj { get; set; }

        [Required]
        [StringLength(30)]
        internal string cli_iestadual { get; set; }

        [Required]
        [StringLength(30)]
        internal string cli_razaosocial { get; set; }

        internal virtual cliente cliente { get; set; }
    }
}
