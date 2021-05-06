using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiaOra
{
    public class TeamResultsCalculation
    {
        public Boolean blindScore;
        public int game1;
        public int game2;
        public int game3;
        public int series;

        public TeamResultsCalculation()
        {
            blindScore = false;
            game1 = 0;
            game2 = 0;
            game3 = 0;
            series = 0;
        }

        public TeamResultsCalculation(Boolean aBlindScore, int aGame1, int aGame2, int aGame3, int aSeries)
        {
            blindScore = aBlindScore;
            game1 = aGame1;
            game2 = aGame2;
            game3 = aGame3;
            series = aSeries;
        }
    }
}
