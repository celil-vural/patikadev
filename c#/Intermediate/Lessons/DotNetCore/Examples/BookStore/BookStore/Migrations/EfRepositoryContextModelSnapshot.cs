﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Concrete.Ef;

#nullable disable

namespace BookStore.Migrations
{
    [DbContext(typeof(EfRepositoryContext))]
    partial class EfRepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.Concrete.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Celil",
                            Surname = "Vural"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorId1")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("GenreId1")
                        .HasColumnType("int");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("AuthorId1");

                    b.HasIndex("GenreId");

                    b.HasIndex("GenreId1");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            GenreId = 1,
                            PageCount = 224,
                            PublishDate = new DateTime(2001, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Lean Startup"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            GenreId = 2,
                            PageCount = 224,
                            PublishDate = new DateTime(2010, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Herland"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            GenreId = 2,
                            PageCount = 224,
                            PublishDate = new DateTime(2002, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Herland"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsActive = true,
                            Name = "PersonalGrowth"
                        },
                        new
                        {
                            Id = 2,
                            IsActive = true,
                            Name = "ScienceFiction"
                        },
                        new
                        {
                            Id = 3,
                            IsActive = true,
                            Name = "Novel"
                        });
                });

            modelBuilder.Entity("Entity.Concrete.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.Concrete.Models.Book", b =>
                {
                    b.HasOne("Entity.Concrete.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Models.Author", null)
                        .WithMany("Books")
                        .HasForeignKey("AuthorId1");

                    b.HasOne("Entity.Concrete.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Concrete.Models.Genre", null)
                        .WithMany("Books")
                        .HasForeignKey("GenreId1");

                    b.Navigation("Author");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Entity.Concrete.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Entity.Concrete.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
