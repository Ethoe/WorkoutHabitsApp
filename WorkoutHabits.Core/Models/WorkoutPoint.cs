using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutHabits.Core.Models
{
    class WorkoutPoint
    {
        public DateTime WorkoutDate { get; set; }
        public Workout Routine { get; set; }
    }
}
