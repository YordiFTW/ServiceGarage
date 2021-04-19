﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ReperatieOpdracht> lijstOpdrachten = (List<ReperatieOpdracht>)Data();
            var opdracht = lijstOpdrachten.Find(s => s.Id.Equals(1));

            foreach (var service in opdracht.Services)
                {
                Console.WriteLine(service);
                }
            
            Console.ReadKey();
        }

        public static IEnumerable<ReperatieOpdracht> Data()
        {
            List<ReperatieOpdracht> opdrachtLijst = new List<ReperatieOpdracht>
                {
                new ReperatieOpdracht
                {
                    Id = 0,
                    Klantnaam = "Jaap",
                    Auto = "Mazda",
                    Services = new List<Service> {Service.BandenSpanning, Service.Computer}                    
                },
                new ReperatieOpdracht
                {
                    Id = 1,
                    Klantnaam = "Piet",
                    Auto = "Volvo",
                    Services = new List<Service> {Service.BandenSpanning, Service.WinterbandenWisselen}
                },
                new ReperatieOpdracht
                {
                    Id = 2,
                    Klantnaam = "Henk",
                    Auto = "BMW",
                    Services = new List<Service> {Service.BandenSpanning, Service.WinterbandenWisselen, Service.Computer, Service.InterieurSchoonmaken, Service.Lichten, Service.Olie, Service.Wassen}
                },               
            };
            return opdrachtLijst;


            //var reperatieOpdracht1 = new ReperatieOpdracht();
            //reperatieOpdracht1.Id = 0;
            //reperatieOpdracht1.Klantnaam = "Jaap";
            //reperatieOpdracht1.Auto = "Mazda";

            //List<Service> services = new List<Service>
            //        {
            //            Service.BandenSpanning,
            //            Service.Computer,
            //        };

            //reperatieOpdracht1.Services = services;
        }
    }
}
