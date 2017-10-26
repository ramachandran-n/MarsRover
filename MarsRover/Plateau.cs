using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Plateau
    {
        public int upperXValue { get; set; }
        public int upperYValue { get; set; }

        int lowerXValue = 0;
        int lowerYValue = 0;

        public Plateau(int x, int y)
        {
            upperXValue = x;
            upperYValue = y;
        }

        //This checkd
        public bool CheckValueWithInRange
        {
            get
            {
                if (upperXValue >= 0 && upperYValue >= 0 && lowerXValue >= 0 && lowerYValue >= 0)
                    return true;
                return false;
            }
        }
    }

    public enum Directions
    {
        North,
        South,
        East,
        West
    }
}
