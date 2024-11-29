using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgram.Models
{
    public class CardioExercise : Exercise
    {
        public double Distance { get; set; }
        public double Speed { get; set; }

        public CardioExercise(string name, int duration, IntensityLevel intensity, double distance, double speed)
            : base(name, duration, intensity)
        {
            Distance = distance;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Distance} km at {Speed} km/h";
        }
    }

}
