﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using Synapse.Infrastructure;

namespace Synapse.Infrastructure.Migrations
{
    [DbContext(typeof(SynapseDBContext))]
    [Migration("20210205190429_OracleInitial")]
    partial class OracleInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("Synapse.Domain.Entities.CreAds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADDR_SOUS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CONV_REF")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DT_FAB")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ETAT_PRESTATION")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EXR_SURV")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("FluxFileId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ID_DG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ID_MESS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ID_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ID_SOUS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LIB_CNT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("MNT")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("MNT_TOT")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("NAT_PREST")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_DG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_FICH")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_PIVOT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_SOUS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_SOUS_COMP")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NUM_FICH_BRIDGE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NUM_SEG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PER_DEB")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PER_FIN")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PIVOT_TYPE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("REF_DG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("REF_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SEG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TYPE_GR_RSQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TYPE_RSQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("VERSION")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("FluxFileId");

                    b.ToTable("CreAds");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.CreDcs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADRESSE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CONT_DG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CONT_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("FluxFileId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("LIGNE_SEG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("MT_DEMAND")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("MT_TOT")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("RAIS_SOC_A")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("RAIS_SOC_B")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("REF_DES_C")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SIRET_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SIRET_SOUS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("FluxFileId");

                    b.ToTable("CreDcs");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.Etat_Prestation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libelle_Etat")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Etat_Prestations");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.FluxFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("File")
                        .HasColumnType("RAW(2000)");

                    b.Property<string>("FileName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime>("ProcessedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.ToTable("FluxFiles");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColonneName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("KeyValues")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NewValues")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("OldValues")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TableName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<Guid>("UpdateGroup")
                        .HasColumnType("RAW(16)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.PrestationCommune", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreAdsId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("CreDcsId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EXR_SURV")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("Etat_PrestationId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("MOIS_SURV")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("MT_PREST_DG")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("PER_DEB")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PER_FIN")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("REF_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("ReservoirAccapPivotId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("CreAdsId");

                    b.HasIndex("CreDcsId");

                    b.HasIndex("Etat_PrestationId");

                    b.HasIndex("ReservoirAccapPivotId");

                    b.ToTable("PrestationCommunes");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.ReservoirAccapulco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateSaisie")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int?>("Etat_PrestationId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Matricule_Apporteur_Gest")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Numero_Bordereau")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Numero_Ordre")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("Etat_PrestationId");

                    b.ToTable("ReservoirAccapulco");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.SsaAds", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ADDR_SOUS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("BASE_RMB_SCS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CAT_ASSUR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_DG_EVT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_DVS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_DVS_REEL")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_DVS_RMB_AUT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_DVS_RMB_SCS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_EVT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_PREST")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_RSQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CD_SEQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CONV_REF")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("COT_ASSUR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("CreId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("DT_FAB")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("ETAT_PRESTATION")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EXR_SURV")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ID_DG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ID_MESS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ID_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ID_SOUS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("LIB_CNT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("MNT_TOT")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("MOIS_SURV")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("MT_AKT_MAX")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("MT_AUT_RMB")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("MT_FRA_REEL")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("MT_PREST_DG")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<decimal>("MT_RMB_SS")
                        .HasColumnType("DECIMAL(18, 2)");

                    b.Property<string>("NATEVT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NAT_PREST")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NB_ACTE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NB_ASSUR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_DG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_FICH")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_PIVOT")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_SOUS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NOM_SOUS_COMP")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NUM_FICH_BRIDGE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NUM_SEG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PER_DEB")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PER_FIN")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PIVOT_TYPE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("REF_DG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("REF_PR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SEG")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SEG_SSA")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("SEX_ASSUR")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TR_AGE")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TX_RMB_SCS")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TYPE_GR_RSQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TYPE_RSQ")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("VERSION")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.HasIndex("CreId");

                    b.ToTable("SsaAds");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.CreAds", b =>
                {
                    b.HasOne("Synapse.Domain.Entities.FluxFile", "FluxFile")
                        .WithMany()
                        .HasForeignKey("FluxFileId");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.CreDcs", b =>
                {
                    b.HasOne("Synapse.Domain.Entities.FluxFile", "FluxFile")
                        .WithMany()
                        .HasForeignKey("FluxFileId");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.PrestationCommune", b =>
                {
                    b.HasOne("Synapse.Domain.Entities.CreAds", "CreAds")
                        .WithMany()
                        .HasForeignKey("CreAdsId");

                    b.HasOne("Synapse.Domain.Entities.CreDcs", "CreDcs")
                        .WithMany()
                        .HasForeignKey("CreDcsId");

                    b.HasOne("Synapse.Domain.Entities.Etat_Prestation", "Etat_Prestation")
                        .WithMany()
                        .HasForeignKey("Etat_PrestationId");

                    b.HasOne("Synapse.Domain.Entities.ReservoirAccapulco", "ReservoirAccapPivot")
                        .WithMany("PrestationCommunes")
                        .HasForeignKey("ReservoirAccapPivotId");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.ReservoirAccapulco", b =>
                {
                    b.HasOne("Synapse.Domain.Entities.Etat_Prestation", "Etat_Prestation")
                        .WithMany()
                        .HasForeignKey("Etat_PrestationId");
                });

            modelBuilder.Entity("Synapse.Domain.Entities.SsaAds", b =>
                {
                    b.HasOne("Synapse.Domain.Entities.CreAds", "Cre")
                        .WithMany("ListSsa")
                        .HasForeignKey("CreId");
                });
#pragma warning restore 612, 618
        }
    }
}
