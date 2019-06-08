namespace HCI_Movies.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class mija : DbContext
    {
        public mija()
            : base("name=mija")
        {
        }

        public virtual DbSet<actor> actors { get; set; }
        public virtual DbSet<director> directors { get; set; }
        public virtual DbSet<genre> genres { get; set; }
        public virtual DbSet<language> languages { get; set; }
        public virtual DbSet<member_of_cast_and_crew> member_of_cast_and_crew { get; set; }
        public virtual DbSet<movie> movies { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<actor>()
                .HasMany(e => e.movies)
                .WithMany(e => e.actors)
                .Map(m => m.ToTable("movie_actor", "movies"));

            modelBuilder.Entity<director>()
                .HasMany(e => e.movies)
                .WithMany(e => e.directors)
                .Map(m => m.ToTable("movie_director", "movies"));

            modelBuilder.Entity<genre>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<genre>()
                .HasMany(e => e.movies)
                .WithMany(e => e.genres)
                .Map(m => m.ToTable("movie_genre", "movies"));

            modelBuilder.Entity<language>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<language>()
                .HasMany(e => e.movies)
                .WithMany(e => e.languages)
                .Map(m => m.ToTable("movie_language", "movies"));

            modelBuilder.Entity<member_of_cast_and_crew>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<member_of_cast_and_crew>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<member_of_cast_and_crew>()
                .Property(e => e.bio)
                .IsUnicode(false);

            modelBuilder.Entity<member_of_cast_and_crew>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<member_of_cast_and_crew>()
                .HasOptional(e => e.actor)
                .WithRequired(e => e.member_of_cast_and_crew);

            modelBuilder.Entity<member_of_cast_and_crew>()
                .HasOptional(e => e.director)
                .WithRequired(e => e.member_of_cast_and_crew);

            modelBuilder.Entity<movie>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<movie>()
                .Property(e => e.poster)
                .IsUnicode(false);

            modelBuilder.Entity<movie>()
                .Property(e => e.tagline)
                .IsUnicode(false);

            modelBuilder.Entity<movie>()
                .Property(e => e.plot_summary)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password_hash)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.salt)
                .IsUnicode(false);
        }
    }
}
