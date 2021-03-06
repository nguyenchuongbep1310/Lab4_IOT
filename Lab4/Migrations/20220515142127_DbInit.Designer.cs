// <auto-generated />
using Lab4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab4.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220515142127_DbInit")]
    partial class DbInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab4.Data.ThietBi", b =>
                {
                    b.Property<int>("MaThietBi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnhSang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoAm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NhietDo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenThietBi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TinhTrang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaThietBi");

                    b.ToTable("ThietBi");
                });
#pragma warning restore 612, 618
        }
    }
}
