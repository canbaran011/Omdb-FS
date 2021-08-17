using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Omdb.Entities.Entities;

#nullable disable

namespace Omdb.DAL.Concrete.EntityFramework
{
    public partial class OmdbContext : DbContext
    {
        public OmdbContext()
        {
        }

        public OmdbContext(DbContextOptions<OmdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-3PLQBCK\\SQLEXPRESS;Database=Omdb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Actors)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoxOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Director)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dvd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DVD");

                entity.Property(e => e.Genre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImdbId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imdbID");

                entity.Property(e => e.ImdbRating)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imdbRating");

                entity.Property(e => e.ImdbVotes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imdbVotes");

                entity.Property(e => e.Metascore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note1).IsUnicode(false);

                entity.Property(e => e.Note2).IsUnicode(false);

                entity.Property(e => e.Plot).IsUnicode(false);

                entity.Property(e => e.Poster).IsUnicode(false);

                entity.Property(e => e.Production)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rated)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ratings)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Released)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Response)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Runtime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website).IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Movies_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Note2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
