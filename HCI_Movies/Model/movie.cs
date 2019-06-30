namespace HCI_Movies.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("movies.movie")]
    public partial class movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movie()
        {
            actors = new HashSet<actor>();
            directors = new HashSet<director>();
            genres = new HashSet<genre>();
            languages = new HashSet<language>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(250)]
        public string name { get; set; }

        [Required]
        [StringLength(100)]
        public string poster { get; set; }

        [Required]
        [StringLength(200)]
        public string tagline { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string plot_summary { get; set; }

        [Column(TypeName = "date")]
        public DateTime release_date { get; set; }

        public int runtime { get; set; }

        public decimal budget { get; set; }

        public decimal? gross { get; set; }

        public sbyte active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<actor> actors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<director> directors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<genre> genres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<language> languages { get; set; }
    }
}
