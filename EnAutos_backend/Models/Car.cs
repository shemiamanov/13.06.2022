using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnAutos_backend.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Dours { get; set; }
        public int Seats { get; set; }
        public string Luggage { get; set; }
        public bool Transmission { get; set; }
        public bool AirConditioning { get; set; }
        public string Image { get; set; }
      
    }
}
