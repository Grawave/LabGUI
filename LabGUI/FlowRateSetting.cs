using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGUI
{
    internal class FlowRateSetting
    {
        private double flowRate;
        private double durationSec;
        private int ID;
    

        public FlowRateSetting(double flowRate, double durationSec, int ID)
        {
            this.flowRate = flowRate;
            this.durationSec = durationSec;
            this.ID = ID;
        }


        public double getFlowRate()
        {
            return this.flowRate;
        }

        public double getDurationSec()
        {
            return this.durationSec;
        }

        public int getID()
        {
            return this.ID;
        }
    }
}
