using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace TireStore.Models
{
    public class Tire
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int WheelSize { get; set; }
        public int Width { get; set; }
        public int Ratio { get; set; }
    }
}
