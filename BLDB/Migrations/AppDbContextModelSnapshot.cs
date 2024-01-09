﻿// <auto-generated />
using BLDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BLDB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Creatures.Monster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ArmorClass")
                        .HasColumnType("integer");

                    b.Property<int>("AttackModifier")
                        .HasColumnType("integer");

                    b.Property<int>("AttackPerRound")
                        .HasColumnType("integer");

                    b.Property<string>("Damage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DamageModifier")
                        .HasColumnType("integer");

                    b.Property<int>("HitPoints")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Monsters");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            ArmorClass = 19,
                            AttackModifier = 5,
                            AttackPerRound = 2,
                            Damage = "4d6",
                            DamageModifier = 7,
                            HitPoints = 200,
                            Name = "Planetar"
                        },
                        new
                        {
                            Id = -2,
                            ArmorClass = 17,
                            AttackModifier = 4,
                            AttackPerRound = 3,
                            Damage = "1d10",
                            DamageModifier = 6,
                            HitPoints = 160,
                            Name = "Relentless juggernaut"
                        },
                        new
                        {
                            Id = -3,
                            ArmorClass = 14,
                            AttackModifier = 4,
                            AttackPerRound = 1,
                            Damage = "3d8",
                            DamageModifier = 8,
                            HitPoints = 200,
                            Name = "Cloud giant"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}