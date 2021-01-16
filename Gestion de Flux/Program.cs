﻿using AutoMapper;
using CsvHelper;
using Gestion_de_Flux.Mapping;
using Gestion_de_Flux.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TinyCsvParser;

namespace Gestion_de_Flux
{
    class Program
    {
        static void Main(string[] args)
        {
            // the app is starting here
            InitializeAutomapper();

            //recuperation du fichier sans header avec separateur ";"
            CsvParserOptions csvParserOptions = new CsvParserOptions(false,';');

            var csvParser = new CsvParser<CsvRecordLigne>(csvParserOptions, new CsvRecordLigneMapping());
            var records = csvParser.ReadFromFile(@"C:\Users\ismai\Desktop\FluxGestion\Fluuux\PRDG_ADS_SANTE_210108.csv", Encoding.UTF8).ToList();

            //constitue la liste des Flux du fichier
            var listeCommandes = new List<CreWithSSA>();
            foreach (var record in records)
            {
                if (record.Result.SEG.ToUpper() == "SSA")
                {
                    continue;
                }

                var creWithSsa = new CreWithSSA()
                {
                    cre = Mapper.Map<Cre>(record),
                    ListSSA=records.Where(r=>r.Result.SEG.ToUpper()== "SSA" && r.Result.Col26 == record.Result.NUM_SEG)
                    .Select(r=> Mapper.Map<Ssa>(r.Result)).ToList()
                };
                listeCommandes.Add(creWithSsa);
            }
          

            Console.WriteLine("Hello World!");
        }

        static void InitializeAutomapper()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<CsvRecordLigne, Cre>()
                    .ForMember(dest => dest.TYPE_GR_RSQ, opt => opt.MapFrom(src => src.Col26))
                    .ForMember(dest => dest.TYPE_RSQ, opt => opt.MapFrom(src => src.Col27))
                    .ForMember(dest => dest.NAT_PREST, opt => opt.MapFrom(src => src.Col28))
                    .ForMember(dest => dest.MNT, opt => opt.MapFrom(src => src.Col29));

                config.CreateMap<CsvRecordLigne, Ssa>()
                    .ForMember(dest => dest.SEG_SSA, opt => opt.MapFrom(src => src.Col26))
                    .ForMember(dest => dest.TYPE_GR_RSQ, opt => opt.MapFrom(src => src.Col27))
                    .ForMember(dest => dest.TYPE_RSQ, opt => opt.MapFrom(src => src.Col28))
                    .ForMember(dest => dest.NAT_PREST, opt => opt.MapFrom(src => src.Col29));
            });
        }
    }
}