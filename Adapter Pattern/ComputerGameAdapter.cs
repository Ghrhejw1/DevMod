using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class ComputerGameAdapter : PCGame
    {
        private ComputerGame _computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            _computerGame = computerGame;
        }

        public string getTitle()
        {
            return _computerGame.getName();
        }

        public int getPegiAllowedAge()
        {
            return _computerGame.getPegiAgeRating() switch
            {
                PegiAgeRating.P3 => 3,
                PegiAgeRating.P7 => 7,
                PegiAgeRating.P12 => 12,
                PegiAgeRating.P16 => 16,
                PegiAgeRating.P18 => 18,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public bool isTripleAGame()
        {
            return _computerGame.getBudgetInMillionsOfDollars() > 50;
        }

        public Requirements getRequirements()
        {
            return new Requirements(
                _computerGame.getMinimumGpuMemoryInMegabytes() / 1024, // Преобразование МБ в ГБ
                _computerGame.getDiskSpaceNeededInGB(),
                _computerGame.getRamNeededInGb(),
                _computerGame.getCoreSpeedInGhz(),
                _computerGame.getCoresNeeded()
            );
        }
    }
}
