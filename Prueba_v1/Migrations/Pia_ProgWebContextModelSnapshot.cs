﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba_v1.Models.dbModels;

#nullable disable

namespace Prueba_v1.Migrations
{
    [DbContext(typeof(Pia_ProgWebContext))]
    partial class Pia_ProgWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Carrito", b =>
                {
                    b.Property<int>("IdUsusario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_ususario");

                    b.Property<int>("IdComida")
                        .HasColumnType("int")
                        .HasColumnName("Id_comida");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.HasKey("IdUsusario", "IdComida");

                    b.HasIndex("IdComida");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Categorium", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"), 1L, 1);

                    b.Property<string>("Descripción")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("descripción");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Comidum", b =>
                {
                    b.Property<int>("IdComida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_comida");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdComida"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("descripcion");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("id_categoria");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<decimal>("Precio")
                        .HasColumnType("numeric(18,0)")
                        .HasColumnName("precio");

                    b.HasKey("IdComida");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Comida");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.DetalleDePedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_pedido");

                    b.Property<int>("IdComida")
                        .HasColumnType("int")
                        .HasColumnName("id_comida");

                    b.Property<decimal>("Cantidad")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("cantidad");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("precio");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("subtotal");

                    b.HasKey("IdPedido", "IdComida");

                    b.HasIndex("IdComida");

                    b.ToTable("Detalle_de_Pedido");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Estado", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_estado");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"), 1L, 1);

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombre_estado");

                    b.HasKey("IdEstado");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_pedido");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("id_estado");

                    b.Property<int>("IdUsuarios")
                        .HasColumnType("int")
                        .HasColumnName("id_usuarios");

                    b.Property<string>("LugarRecoger")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nchar(40)")
                        .HasColumnName("lugar_recoger")
                        .IsFixedLength();

                    b.Property<decimal>("TotalPagar")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("total_pagar");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdEstado");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Reseña", b =>
                {
                    b.Property<int>("IdReseña")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_reseña");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReseña"), 1L, 1);

                    b.Property<string>("Comentario")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("comentario");

                    b.Property<int>("IdComida")
                        .HasColumnType("int")
                        .HasColumnName("id_comida");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("id_usuario");

                    b.Property<decimal?>("Puntuación")
                        .HasColumnType("decimal(18,0)")
                        .HasColumnName("puntuación");

                    b.HasKey("IdReseña");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Reseñas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba_v1.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Carrito", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.Comidum", "IdComidaNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("IdComida")
                        .IsRequired()
                        .HasConstraintName("FK_Carrito_Comida");

                    b.HasOne("Prueba_v1.Models.dbModels.ApplicationUser", "IdUsusario1")
                        .WithMany("Carritos")
                        .HasForeignKey("IdUsusario")
                        .IsRequired()
                        .HasConstraintName("FK_Carrito_Usuarios");

                    b.HasOne("Prueba_v1.Models.dbModels.Pedido", "IdUsusarioNavigation")
                        .WithMany("Carritos")
                        .HasForeignKey("IdUsusario")
                        .IsRequired()
                        .HasConstraintName("FK_Carrito_Pedido");

                    b.Navigation("IdComidaNavigation");

                    b.Navigation("IdUsusario1");

                    b.Navigation("IdUsusarioNavigation");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Comidum", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.Categorium", "IdCategoriaNavigation")
                        .WithMany("Comida")
                        .HasForeignKey("IdCategoria")
                        .IsRequired()
                        .HasConstraintName("FK_Comida_Categoria");

                    b.Navigation("IdCategoriaNavigation");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.DetalleDePedido", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.Comidum", "IdComidaNavigation")
                        .WithMany("DetalleDePedidos")
                        .HasForeignKey("IdComida")
                        .IsRequired()
                        .HasConstraintName("FK_Detalle_de_Pedido_Comida");

                    b.HasOne("Prueba_v1.Models.dbModels.Pedido", "IdPedidoNavigation")
                        .WithMany("DetalleDePedidos")
                        .HasForeignKey("IdPedido")
                        .IsRequired()
                        .HasConstraintName("FK_Detalle_de_Pedido_Pedido");

                    b.Navigation("IdComidaNavigation");

                    b.Navigation("IdPedidoNavigation");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Pedido", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.Estado", "IdEstadoNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_Pedido_Estado");

                    b.HasOne("Prueba_v1.Models.dbModels.ApplicationUser", "IdPedidoNavigation")
                        .WithOne("Pedido")
                        .HasForeignKey("Prueba_v1.Models.dbModels.Pedido", "IdPedido")
                        .IsRequired()
                        .HasConstraintName("FK_Pedido_Usuarios");

                    b.Navigation("IdEstadoNavigation");

                    b.Navigation("IdPedidoNavigation");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Reseña", b =>
                {
                    b.HasOne("Prueba_v1.Models.dbModels.ApplicationUser", "IdUsuario1")
                        .WithMany("Reseñas")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Reseñas_Usuarios");

                    b.HasOne("Prueba_v1.Models.dbModels.Comidum", "IdUsuarioNavigation")
                        .WithMany("Reseñas")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Reseñas_Comida");

                    b.Navigation("IdUsuario1");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.ApplicationUser", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("Pedido");

                    b.Navigation("Reseñas");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Categorium", b =>
                {
                    b.Navigation("Comida");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Comidum", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("DetalleDePedidos");

                    b.Navigation("Reseñas");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Estado", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Prueba_v1.Models.dbModels.Pedido", b =>
                {
                    b.Navigation("Carritos");

                    b.Navigation("DetalleDePedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
