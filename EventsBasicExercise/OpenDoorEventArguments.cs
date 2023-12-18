using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBasicExercise
{
    public class OpenDoorEventArguments:EventArgs
    {
        public DateTime BreakTime { get; set; }
    }
}
