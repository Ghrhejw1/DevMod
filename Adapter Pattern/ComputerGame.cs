using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class ComputerGame
    {
        private string name;
        private PegiAgeRating pegiAgeRating;
        private double budgetInMillionsOfDollars;
        private int minimumGpuMemoryInMegabytes;
        private int diskSpaceNeededInGB;
        private int ramNeededInGb;
        private int coresNeeded;
        private double coreSpeedInGhz;

        public ComputerGame(string name,
            PegiAgeRating pegiAgeRating,
            double budgetInMillionsOfDollars,
            int minimumGpuMemoryInMegabytes,
            int diskSpaceNeededInGB,
            int ramNeededInGb,
            int coresNeeded,
            double coreSpeedInGhz)
        {
            this.name = name;
            this.pegiAgeRating = pegiAgeRating;
            this.budgetInMillionsOfDollars = budgetInMillionsOfDollars;
            this.minimumGpuMemoryInMegabytes = minimumGpuMemoryInMegabytes;
            this.diskSpaceNeededInGB = diskSpaceNeededInGB;
            this.ramNeededInGb = ramNeededInGb;
            this.coresNeeded = coresNeeded;
            this.coreSpeedInGhz = coreSpeedInGhz;
        }

        public string getName() => name;
        public PegiAgeRating getPegiAgeRating() => pegiAgeRating;
        public double getBudgetInMillionsOfDollars() => budgetInMillionsOfDollars;
        public int getMinimumGpuMemoryInMegabytes() => minimumGpuMemoryInMegabytes;
        public int getDiskSpaceNeededInGB() => diskSpaceNeededInGB;
        public int getRamNeededInGb() => ramNeededInGb;
        public int getCoresNeeded() => coresNeeded;
        public double getCoreSpeedInGhz() => coreSpeedInGhz;
    }

    public enum PegiAgeRating
    {
        P3, P7, P12, P16, P18
    }
}
