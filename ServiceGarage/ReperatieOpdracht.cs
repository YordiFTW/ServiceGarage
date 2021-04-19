using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceGarage
{
    class ReperatieOpdracht
    {
        public int Id { get; set; }
        public string Klantnaam { get; set; }
        public string Auto { get; set; }

        public List<Service> Services { get; set; } 
    }
}
