using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        //Constructor
        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
        }

        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public int Days { get; set; }
        public bool Hired { get; set; } = false;

        //Methods
        public override string ToString()
        {
            return $"-Renovator: {this.Name}" + Environment.NewLine +
            $"--Specialty: {this.Type}" + Environment.NewLine +
            $"--Rate per day: {this.Rate} BGN";
        }
    }
}