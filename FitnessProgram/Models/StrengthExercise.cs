using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgram.Models { 
public class StrengthExercise : Exercise
{
    public int Weight { get; set; }
    public int Repetitions { get; set; }

    public StrengthExercise(string name, int duration, IntensityLevel intensity, int weight, int repetitions)
        : base(name, duration, intensity)
    {
        Weight = weight;
        Repetitions = repetitions;
    }

    public override string ToString()
    {
        return $"{base.ToString()} - {Weight} kg for {Repetitions} reps";
    }
}
}