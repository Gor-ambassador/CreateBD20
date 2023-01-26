﻿// <auto-generated />
using CreateDB20.DBStructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CreateBD20.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230120175633_My Mig")]
    partial class MyMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("CreateBD20.DBStructure.Info", b =>
                {
                    b.Property<int>("InfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Port")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoomType")
                        .HasColumnType("TEXT");

                    b.HasKey("InfoId");

                    b.ToTable("Info");
                });
#pragma warning restore 612, 618
        }
    }
}
