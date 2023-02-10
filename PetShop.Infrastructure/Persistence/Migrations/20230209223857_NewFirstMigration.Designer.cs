﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Infrastructure.Persistence;

namespace PetShop.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(PetShopDbContext))]
    [Migration("20230209223857_NewFirstMigration")]
    partial class NewFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetShop.Core.Entities.Address", b =>
                {
                    b.Property<int>("IdAddress")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserIdUser")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAddress");

                    b.HasIndex("IdClient");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("IdClient");

                    b.HasIndex("IdUser");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Consultation", b =>
                {
                    b.Property<int>("IdConsultation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ConsultationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdPet")
                        .HasColumnType("int");

                    b.Property<int>("IdVet")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdConsultation");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdPet");

                    b.HasIndex("IdVet");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Pet", b =>
                {
                    b.Property<int>("IdPet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("PetsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("IdPet");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdUser");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("PetShop.Core.Entities.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Address", b =>
                {
                    b.HasOne("PetShop.Core.Entities.User", "User")
                        .WithOne("Address")
                        .HasForeignKey("PetShop.Core.Entities.Address", "IdAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Core.Entities.Client", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PetShop.Core.Entities.User", null)
                        .WithMany("Addresses")
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Client");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Client", b =>
                {
                    b.HasOne("PetShop.Core.Entities.User", "User")
                        .WithMany("Clients")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Consultation", b =>
                {
                    b.HasOne("PetShop.Core.Entities.Client", "Client")
                        .WithMany("Consultations")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PetShop.Core.Entities.Pet", "Pet")
                        .WithMany("Consultations")
                        .HasForeignKey("IdPet")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PetShop.Core.Entities.User", "Vet")
                        .WithMany("Consultations")
                        .HasForeignKey("IdVet")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Pet");

                    b.Navigation("Vet");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Pet", b =>
                {
                    b.HasOne("PetShop.Core.Entities.Client", "Client")
                        .WithMany("Pets")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PetShop.Core.Entities.User", "User")
                        .WithMany("Pets")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Client", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Consultations");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("PetShop.Core.Entities.Pet", b =>
                {
                    b.Navigation("Consultations");
                });

            modelBuilder.Entity("PetShop.Core.Entities.User", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Addresses");

                    b.Navigation("Clients");

                    b.Navigation("Consultations");

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
