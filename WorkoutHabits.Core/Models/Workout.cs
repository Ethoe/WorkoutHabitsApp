using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutHabits.Core.Models
{
    /// <summary>
    /// A full workout contains multiple exercises and a name
    /// </summary>
    class Workout
    {
        public string Name { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
    }
}
