namespace eMecanica.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estagio.cliente_pj")]
    public partial class cliente_pj
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cli_id { get; set; }

        [Required]
        [StringLength(25)]
        public string cli_cnpj { get; set; }

        [Required]
        [StringLength(30)]
        public string cli_iestadual { get; set; }

        [Required]
        [StringLength(30)]
        public string cli_razaosocial { get; set; }

        public virtual cliente cliente { get; set; }
    }
}
