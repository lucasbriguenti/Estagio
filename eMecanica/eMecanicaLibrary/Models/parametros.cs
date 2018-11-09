namespace eMecanicaLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class parametros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int par_id { get; set; }

        public int end_id { get; set; }

        [Required]
        [StringLength(25)]
        public string par_inscestadual { get; set; }

        [Required]
        [StringLength(25)]
        public string par_inscmunicipal { get; set; }

        [Required]
        [StringLength(50)]
        public string par_razaosocial { get; set; }

        [Required]
        [StringLength(50)]
        public string par_nomefantasia { get; set; }

        [Required]
        [StringLength(20)]
        public string par_cnpj { get; set; }

        [StringLength(200)]
        public string par_logo { get; set; }

        [StringLength(20)]
        public string par_corfundo { get; set; }

        [StringLength(20)]
        public string par_corfonte { get; set; }

        public virtual endereco endereco { get; set; }
    }
}
