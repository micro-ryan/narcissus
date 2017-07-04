using Microsoft.EntityFrameworkCore;
using Narcissus.Security.Core;
using System;

namespace Narcissus.Security.EF
{
    public class IdentityDbContext<TUser, TRole, TUserRole, TUserKey, TRoleKey, TClaimKey, TRoleClaim, TUserClaim> : DbContext
        where TUserKey : IEquatable<TUserKey>
        where TRoleKey : IEquatable<TRoleKey>
        where TClaimKey : IEquatable<TClaimKey>
        where TUser : IdentityUser<TUserKey>
        where TRole : IdentityRole<TRoleKey>
        where TUserRole : IdentityUserRole<TUserKey, TRoleKey>        
        where TRoleClaim : IdentityRoleClaim<TRoleKey, TClaimKey>
        where TUserClaim : IdentityUserClaim<TUserKey, TClaimKey>
    {
        public IdentityDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TRole> Roles { get; set; }
        public DbSet<TUser> Users { get; set; }
        public DbSet<TUserRole> UserRoles { get; set; }
        public DbSet<TRoleClaim> RoleClaims { get; set; }
        public DbSet<TUserClaim> UserClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TUser>(b =>
            {
                b.ToTable("Users");

                b.HasKey(u => u.ID);
                b.HasIndex(u => u.NormalizedEmail).HasName("UserNormalizedEmail").IsUnique();
                b.HasIndex(u => u.NormalizedPhoneNumber).HasName("UserNormalizedPhoneNumber").IsUnique();
                b.HasMany<TUserRole>().WithOne().HasForeignKey(ur => ur.UserID).IsRequired();
            });

            builder.Entity<TRole>(b =>
            {
                b.ToTable("Roles");

                b.HasKey(r => r.ID);
                b.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();                

                b.Property(u => u.Name).HasMaxLength(256);
                b.Property(u => u.NormalizedName).HasMaxLength(256);

                b.HasMany<TUserRole>().WithOne().HasForeignKey(ur => ur.RoleID).IsRequired();
                b.HasMany<TRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleID).IsRequired();
            });

            builder.Entity<TUserRole>(b =>
            {
                b.HasKey(ur => new { ur.UserID, ur.RoleID });
                b.ToTable("UserRoles");
            });
            
            builder.Entity<TRoleClaim>(b =>
            {
                b.HasKey(rc => new { rc.RoleID ,rc.ClaimID});
                b.ToTable("RoleClaims");
            });

            builder.Entity<TUserClaim>(b =>
            {
                b.HasKey(uc => new { uc.UserID, uc.ClaimID });
                b.ToTable("UserClaims");
            });
        }
    }
}
