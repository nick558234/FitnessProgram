using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgram.Models
{
    public class Exercise
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public IntensityLevel Intensity { get; set; } // use enum 'IntensityLevel'

        public Exercise(string name, int duration, IntensityLevel intensity)
        {
            Name = name;
            Duration = duration;
            Intensity = intensity;
        }

        public override string ToString()
        {
            // Retourneert de oefening in leesbare vorm, bijvoorbeeld: "Push-up - 10 minutes (Medium)"
            return $"{Name} - {Duration} minutes ({Intensity})";
        }
    }
    public enum IntensityLevel
    {
        Low,
        Medium,
        High
    }

}
