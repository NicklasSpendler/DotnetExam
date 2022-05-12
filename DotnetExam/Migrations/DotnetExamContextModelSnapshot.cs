﻿// <auto-generated />
using System;
using DotnetExam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotnetExam.Migrations
{
    [DbContext(typeof(DotnetExamContext))]
    partial class DotnetExamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DotnetExam.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("DotnetExam.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("DotnetExam.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("albumId")
                        .HasColumnType("int");

                    b.Property<int?>("artistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("albumId");

                    b.HasIndex("artistId");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("DotnetExam.Models.Song", b =>
                {
                    b.HasOne("DotnetExam.Models.Album", "album")
                        .WithMany("Songs")
                        .HasForeignKey("albumId");

                    b.HasOne("DotnetExam.Models.Artist", "artist")
                        .WithMany("Songs")
                        .HasForeignKey("artistId");

                    b.Navigation("album");

                    b.Navigation("artist");
                });

            modelBuilder.Entity("DotnetExam.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("DotnetExam.Models.Artist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
