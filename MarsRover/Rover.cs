using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        Plateau plateau = null;
        Coordinates currentCoordinates = null;
        Coordinates coordinatesAfterMove = null;
        string currentDirection = string.Empty;

        public Rover(Plateau plateau, Coordinates currentCoordinate, string direction)
        {
            this.plateau = plateau;
            this.currentCoordinates = currentCoordinate;
            this.currentDirection = direction;
        }

        public string GetCurrentRoverPosition()
        {
            return this.currentCoordinates.currentCoordinates() + " " + currentDirection;
        }

        public void RotateLeft()
        {
            currentDirection = plateau.CheckDirection(currentDirection, "L");
        }

        public void RotateRight()
        {
            currentDirection = plateau.CheckDirection(currentDirection, "R");
        }

        public void Move()
        {
            currentCoordinates = currentCoordinates.CoordinateToMove(currentCoordinates, currentDirection);
            Console.WriteLine(GetCurrentRoverPosition());
        }

    }
}
