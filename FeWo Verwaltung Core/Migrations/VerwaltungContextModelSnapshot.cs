﻿// <auto-generated />
using System;
using FeWo_Verwaltung_Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FeWo_Verwaltung_Core.Migrations
{
    [DbContext(typeof(VerwaltungContext))]
    partial class VerwaltungContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("FeWo_Verwaltung_Core.MietWohnung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beschreibung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Hausnummer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ort")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Plz")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Strasse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VermierterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VermierterId");

                    b.ToTable("MietWohnungen");
                });

            modelBuilder.Entity("FeWo_Verwaltung_Core.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Hausnummer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ort")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<int>("Plz")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Strasse")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vorname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("FeWo_Verwaltung_Core.Vermietet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Abreise")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Ankunft")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MietWohnungId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MieterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MietWohnungId");

                    b.HasIndex("MieterId");

                    b.ToTable("VermietetSet");
                });

            modelBuilder.Entity("FeWo_Verwaltung_Core.Mieter", b =>
                {
                    b.HasBaseType("FeWo_Verwaltung_Core.User");

                    b.HasDiscriminator().HasValue("Mieter");
                });

            modelBuilder.Entity("FeWo_Verwaltung_Core.Vermierter", b =>
                {
                    b.HasBaseType("FeWo_Verwaltung_Core.User");

                    b.HasDiscriminator().HasValue("Vermierter");
                });

            modelBuilder.Entity("FeWo_Verwaltung_Core.MietWohnung", b =>
                {
                    b.HasOne("FeWo_Verwaltung_Core.Vermierter", "Vermierter")
                        .WithMany()
                        .HasForeignKey("VermierterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FeWo_Verwaltung_Core.Vermietet", b =>
                {
                    b.HasOne("FeWo_Verwaltung_Core.MietWohnung", null)
                        .WithMany("Mietliste")
                        .HasForeignKey("MietWohnungId");

                    b.HasOne("FeWo_Verwaltung_Core.User", "Mieter")
                        .WithMany()
                        .HasForeignKey("MieterId");
                });
#pragma warning restore 612, 618
        }
    }
}
