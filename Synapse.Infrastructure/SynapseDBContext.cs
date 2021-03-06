﻿using Microsoft.EntityFrameworkCore;
using Synapse.Infrastructure;
using Synapse.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Synapse.Infrastructure
{
    public class SynapseDBContext : DbContext
    {
        public SynapseDBContext(DbContextOptions<SynapseDBContext> options):base(options)
        {
        }

        public DbSet<CreAds> CreAds { get; set; }
        public DbSet<SsaAds> SsaAds { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<PrestationCommune> PrestationCommunes { get; set; }

        public DbSet<CreDcs> CreDcs { get; set; }

        public DbSet<ReservoirAccapulco> ReservoirAccapulco { get; set; }
        public DbSet<FluxFile> FluxFiles { get; set; }

        public DbSet<Etat_Prestation> Etat_Prestations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OE8AEG7\SQLEXPRESS;Initial Catalog=SynapseDb;Integrated Security=True");


            string connStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=host.docker.internal)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));Persist Security Info=True;User ID=system;Password=Rani@2020";
            optionsBuilder.UseOracle(connStr);
                //.EnableSensitiveDataLogging();

            //optionsBuilder.UseOracle(@"Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = host.docker.internal)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=system;Password=Rani@2020)");
        }
    }
}
