using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Muebles_JJ.Infrastructure;

namespace Muebles_JJ.Infrastructure.Data
{
    public partial class Muebles_JJDbContext : DbContext
    {
        public Muebles_JJDbContext()
        {
        }

        public Muebles_JJDbContext(DbContextOptions<Muebles_JJDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CantidadInsumo> CantidadInsumo { get; set; }
        public virtual DbSet<ColorProducto> ColorProducto { get; set; }
        public virtual DbSet<ComprobantePago> ComprobantePago { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<Insumo> Insumo { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<MaterialProducto> MaterialProducto { get; set; }
        public virtual DbSet<MedidaProducto> MedidaProducto { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("database=muebles_jj;server=localhost;port=3306;user id=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CantidadInsumo>(entity =>
            {
                entity.HasKey(e => e.IdCantidad)
                    .HasName("PRIMARY");

                entity.ToTable("cantidad_insumo");

                entity.Property(e => e.IdCantidad)
                    .HasColumnName("ID_Cantidad")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ColorProducto>(entity =>
            {
                entity.HasKey(e => e.IdColor)
                    .HasName("PRIMARY");

                entity.ToTable("color_producto");

                entity.Property(e => e.IdColor)
                    .HasColumnName("ID_Color")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ComprobantePago>(entity =>
            {
                entity.HasKey(e => e.IdComprobante)
                    .HasName("PRIMARY");

                entity.ToTable("comprobante_pago");

                entity.HasIndex(e => e.IdVentaFk)
                    .HasName("ID_Venta_FK");

                entity.Property(e => e.IdComprobante)
                    .HasColumnName("ID_Comprobante")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Fecha).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdVentaFk)
                    .HasColumnName("ID_Venta_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdVentaFkNavigation)
                    .WithMany(p => p.ComprobantePago)
                    .HasForeignKey(d => d.IdVentaFk)
                    .HasConstraintName("comprobante_pago_ibfk_1");
            });

            modelBuilder.Entity<Documento>(entity =>
            {
                entity.HasKey(e => e.IdDocumento)
                    .HasName("PRIMARY");

                entity.ToTable("documento");

                entity.Property(e => e.IdDocumento)
                    .HasColumnName("ID_Documento")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Insumo>(entity =>
            {
                entity.HasKey(e => e.IdInsumo)
                    .HasName("PRIMARY");

                entity.ToTable("insumo");

                entity.HasIndex(e => e.IdCantidadFk)
                    .HasName("ID_Cantidad_FK");

                entity.Property(e => e.IdInsumo)
                    .HasColumnName("ID_Insumo")
                    .HasColumnType("int(2)");

                entity.Property(e => e.IdCantidadFk)
                    .HasColumnName("ID_Cantidad_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdCantidadFkNavigation)
                    .WithMany(p => p.Insumo)
                    .HasForeignKey(d => d.IdCantidadFk)
                    .HasConstraintName("insumo_ibfk_1");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario)
                    .HasName("PRIMARY");

                entity.ToTable("inventario");

                entity.HasIndex(e => e.IdInsumoFk)
                    .HasName("ID_Insumo_FK");

                entity.HasIndex(e => e.IdProductoFk)
                    .HasName("ID_Producto_FK");

                entity.Property(e => e.IdInventario)
                    .HasColumnName("ID_Inventario")
                    .HasColumnType("int(2)");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnName("Fecha_Entrada")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaSalida)
                    .HasColumnName("Fecha_Salida")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdInsumoFk)
                    .HasColumnName("ID_Insumo_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProductoFk)
                    .HasColumnName("ID_Producto_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdInsumoFkNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdInsumoFk)
                    .HasConstraintName("inventario_ibfk_1");

                entity.HasOne(d => d.IdProductoFkNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.IdProductoFk)
                    .HasConstraintName("inventario_ibfk_2");
            });

            modelBuilder.Entity<MaterialProducto>(entity =>
            {
                entity.HasKey(e => e.IdMaterial)
                    .HasName("PRIMARY");

                entity.ToTable("material_producto");

                entity.Property(e => e.IdMaterial)
                    .HasColumnName("ID_Material")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<MedidaProducto>(entity =>
            {
                entity.HasKey(e => e.IdMedida)
                    .HasName("PRIMARY");

                entity.ToTable("medida_producto");

                entity.Property(e => e.IdMedida)
                    .HasColumnName("ID_Medida")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CantidadCentimetros)
                    .HasColumnName("Cantidad_Centimetros")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PRIMARY");

                entity.ToTable("pedido");

                entity.HasIndex(e => e.IdVentaFk)
                    .HasName("ID_Venta_FK");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("ID_Pedido")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DireccionEntrega)
                    .HasColumnName("Direccion_Entrega")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdVentaFk)
                    .HasColumnName("ID_Venta_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdVentaFkNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdVentaFk)
                    .HasConstraintName("pedido_ibfk_1");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PRIMARY");

                entity.ToTable("persona");

                entity.HasIndex(e => e.IdDocumentoFk)
                    .HasName("ID_Documento_FK");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("ID_Persona")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdDocumentoFk)
                    .HasColumnName("ID_Documento_FK")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumeroDocumento)
                    .HasColumnName("Numero_Documento")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("Primer_Apellido")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("Primer_Nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("Segundo_Apellido")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("Segundo_Nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdDocumentoFkNavigation)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.IdDocumentoFk)
                    .HasConstraintName("persona_ibfk_1");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("producto");

                entity.HasIndex(e => e.IdColorFk)
                    .HasName("ID_Color_FK");

                entity.HasIndex(e => e.IdMaterialFk)
                    .HasName("ID_Material_FK");

                entity.HasIndex(e => e.IdMedidaFk)
                    .HasName("ID_Medida_FK");

                entity.HasIndex(e => e.IdTipoFk)
                    .HasName("ID_Tipo_FK");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("ID_Producto")
                    .HasColumnType("int(2)");

                entity.Property(e => e.IdColorFk)
                    .HasColumnName("ID_Color_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdMaterialFk)
                    .HasColumnName("ID_Material_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdMedidaFk)
                    .HasColumnName("ID_Medida_FK")
                    .HasColumnType("int(30)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdTipoFk)
                    .HasColumnName("ID_Tipo_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdColorFkNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdColorFk)
                    .HasConstraintName("producto_ibfk_3");

                entity.HasOne(d => d.IdMaterialFkNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdMaterialFk)
                    .HasConstraintName("producto_ibfk_2");

                entity.HasOne(d => d.IdMedidaFkNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdMedidaFk)
                    .HasConstraintName("producto_ibfk_4");

                entity.HasOne(d => d.IdTipoFkNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdTipoFk)
                    .HasConstraintName("producto_ibfk_1");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.Property(e => e.IdRol)
                    .HasColumnName("ID_Rol")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Telefono>(entity =>
            {
                entity.HasKey(e => e.IdTelefono)
                    .HasName("PRIMARY");

                entity.ToTable("telefono");

                entity.HasIndex(e => e.IdUsuarioFk)
                    .HasName("ID_Usuario_FK");

                entity.Property(e => e.IdTelefono)
                    .HasColumnName("ID_Telefono")
                    .HasColumnType("int(1)");

                entity.Property(e => e.Extension)
                    .HasColumnType("int(4)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdUsuarioFk)
                    .HasColumnName("ID_Usuario_FK")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Numero)
                    .HasColumnType("bigint(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdUsuarioFkNavigation)
                    .WithMany(p => p.Telefono)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .HasConstraintName("telefono_ibfk_1");
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_producto");

                entity.Property(e => e.IdTipo)
                    .HasColumnName("ID_Tipo")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.IdPersonaFk)
                    .HasName("ID_Persona_FK");

                entity.HasIndex(e => e.IdRolFk)
                    .HasName("ID_Rol_FK");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasColumnType("int(2)");

                entity.Property(e => e.ContraseñaUsuario)
                    .HasColumnName("Contraseña_Usuario")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdPersonaFk)
                    .HasColumnName("ID_Persona_FK")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdRolFk)
                    .HasColumnName("ID_Rol_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NombreUsuario)
                    .HasColumnName("Nombre_Usuario")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdPersonaFkNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdPersonaFk)
                    .HasConstraintName("usuario_ibfk_1");

                entity.HasOne(d => d.IdRolFkNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdRolFk)
                    .HasConstraintName("usuario_ibfk_2");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PRIMARY");

                entity.ToTable("venta");

                entity.HasIndex(e => e.IdProductoFk)
                    .HasName("ID_Producto_FK");

                entity.Property(e => e.IdVenta)
                    .HasColumnName("ID_Venta")
                    .HasColumnType("int(2)");

                entity.Property(e => e.CantidadProducto)
                    .HasColumnName("Cantidad_Producto")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fecha).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProductoFk)
                    .HasColumnName("ID_Producto_FK")
                    .HasColumnType("int(2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubTotal)
                    .HasColumnName("Sub_Total")
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Total)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdProductoFkNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.IdProductoFk)
                    .HasConstraintName("venta_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
