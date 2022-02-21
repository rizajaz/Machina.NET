using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machina
{
    public class ActionStopMotion : Action
    {
        public override ActionType Type => ActionType.StopMotion;

        public ActionStopMotion() : base() { }

        public override string ToString()
        {
            return "Stop robot motions.";
        }

        public override string ToInstruction()
        {
            return $"StopMotion();";
        }
    }
}
