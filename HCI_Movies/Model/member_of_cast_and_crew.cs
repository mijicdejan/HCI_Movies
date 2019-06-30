namespace HCI_Movies.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("movies.member_of_cast_and_crew")]
    public partial class member_of_cast_and_crew
    {
        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string first_name { get; set; }

        [Required]
        [StringLength(45)]
        public string last_name { get; set; }

        [Required]
        [StringLength(255)]
        public string birthplace { get; set; }

        [Column(TypeName = "date")]
        public DateTime born { get; set; }

        [Column(TypeName = "date")]
        public DateTime? died { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string bio { get; set; }

        [Required]
        [StringLength(100)]
        public string image { get; set; }

        public sbyte active { get; set; }

        public virtual actor actor { get; set; }

        public virtual director director { get; set; }
    }
}
