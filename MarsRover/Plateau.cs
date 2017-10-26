using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Plateau
    {
        protected Coordinates upperCoordinates = new Coordinates(0, 0);
        protected Coordinates lowerCoordinates = new Coordinates(0, 0);

        public Plateau(int upperXCooridnate, int upperYCoordinate)
        {
            this.upperCoordinates= this.upperCoordinates.AddNewCoordinate(upperXCooridnate, upperXCooridnate);
        }

        
        public string CheckDirection(string currentDirection, string turnDirection)
        {
            switch(currentDirection)
            {
                case "N":
                    if(turnDirection.Equals("L"))
                    {
                        return "W";
                    }
                    else
                    {
                        return "E";
                    }
                    break;
                case "E":
                    if (turnDirection.Equals("L"))
                    {
                        return "N";
                    }
                    else
                    {
                        return "S";
                    }
                    break;
                case "S":
                    if (turnDirection.Equals("L"))
                    {
                        return "E";
                    }
                    else
                    {
                        return "W";
                    }
                    break;
                case "W":
                    if (turnDirection.Equals("L"))
                    {
                        return "S";
                    }
                    else
                    {
                        return "N";
                    }
                    break;
            }
            return "N";
        }
    }
}
