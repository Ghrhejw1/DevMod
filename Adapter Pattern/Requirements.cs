using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Requirements
    {
        private int gpuGb;
        private int HDDGb;
        private int RAMGb;
        private double cpuGhz;
        private int coresNum;

        public Requirements(int gpuGb, int HDDGb, int RAMGb, double cpuGhz, int coresNum)
        {
            this.gpuGb = gpuGb;
            this.HDDGb = HDDGb;
            this.RAMGb = RAMGb;
            this.cpuGhz = cpuGhz;
            this.coresNum = coresNum;
        }

        public int getGpuGb() => gpuGb;
        public int getHDDGb() => HDDGb;
        public int getRAMGb() => RAMGb;
        public double getCpuGhz() => cpuGhz;
        public int getCoresNum() => coresNum;
    }
}
