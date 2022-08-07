using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace LabGUI
{
    internal class FlowRateSettingsList
    {
        private List<FlowRateSetting> flowRateList;
        private int maxID;
        

        public FlowRateSettingsList()
        {
            this.flowRateList = new List<FlowRateSetting>();
            this.maxID = 0;
        }

        public void add(FlowRateSetting flowRateSetting)
        {
            this.flowRateList.Add(flowRateSetting);
            int id = flowRateSetting.getID();
            if (this.maxID > id) {
                throw new InvalidOperationException("New flowRateSetting's should never be smaller than the 'maxID'");
            } else
            {
                this.maxID = id;
            }
        }

        public List<FlowRateSetting> getFlowRateSettingsList()
        {
            return this.flowRateList;
        }

        public int getMaxID()
        {
            return this.maxID;
        }

    }
}
