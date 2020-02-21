namespace LoginA.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LoginDBContext : DbContext
    {
        public LoginDBContext()
            : base("name=LoginDBContext")
        {
        }

        public virtual DbSet<tblAdmin> tblAdmins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.admin_id)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.ad_soyad)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.eposta)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.rol)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.parolatekrar)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.parola)
                .IsUnicode(false);

            modelBuilder.Entity<tblAdmin>()
                .Property(e => e.foto)
                .IsUnicode(false);
        }
    }
}
