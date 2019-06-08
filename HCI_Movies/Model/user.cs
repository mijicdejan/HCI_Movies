namespace HCI_Movies.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("movies.user")]
    public partial class user
    {
        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string username { get; set; }

        [Required]
        [StringLength(45)]
        public string password_hash { get; set; }

        [Column(TypeName = "char")]
        [Required]
        [StringLength(8)]
        public string salt { get; set; }
    }
}
