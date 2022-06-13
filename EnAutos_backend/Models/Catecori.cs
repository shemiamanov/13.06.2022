using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnAutos_backend.Models
{
    public class Catecori
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
