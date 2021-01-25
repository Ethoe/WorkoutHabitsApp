using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutHabits.Core.Models
{
    /// <summary>
    /// An individual exercise that describes what it works, explination and name
    /// </summary>
    class Exercise
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Explination { get; set; }
        public int Progression { get; set; }
        public int Time { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
    }
}
