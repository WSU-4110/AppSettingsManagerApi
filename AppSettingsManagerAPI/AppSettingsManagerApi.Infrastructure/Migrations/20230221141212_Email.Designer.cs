﻿// <auto-generated />
using System;
using AppSettingsManagerApi.Infrastructure.MySql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppSettingsManagerApi.Infrastructure.Migrations
{
    [DbContext(typeof(SettingsContext))]
    [Migration("20230221141212_Email")]
    partial class Email
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppSettingsManagerApi.Infrastructure.MySql.BaseUser", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.HasKey("UserId");

                    b.ToTable("BaseUsers");
                });

            modelBuilder.Entity("AppSettingsManagerApi.Infrastructure.MySql.Setting", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("BaseUserUserId")
                        .HasColumnType("varchar(36)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("varchar(36)");

                    b.Property<string>("Input")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastUpdatedAt")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp(6)");

                    b.HasKey("Id", "Version");

                    b.HasIndex("BaseUserUserId");

                    b.HasIndex("Id");

                    b.HasIndex("IsCurrent");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("AppSettingsManagerApi.Infrastructure.MySql.Setting", b =>
                {
                    b.HasOne("AppSettingsManagerApi.Infrastructure.MySql.BaseUser", null)
                        .WithMany("Settings")
                        .HasForeignKey("BaseUserUserId");
                });

            modelBuilder.Entity("AppSettingsManagerApi.Infrastructure.MySql.BaseUser", b =>
                {
                    b.Navigation("Settings");
                });
#pragma warning restore 612, 618
        }
    }
}
