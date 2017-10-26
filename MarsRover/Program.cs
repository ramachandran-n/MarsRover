using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "MMRMMRMRRM".ToCharArray();

            //Initialize the Plateau, Rover and current direction
            Plateau plateau = new Plateau(5, 5);
            Coordinates initialCoordinate = new Coordinates(3,3);
            string currentDirection = "E";
            Rover rover = new Rover(plateau, initialCoordinate, currentDirection);
            Console.WriteLine("Initial Rover position:" + rover.GetCurrentRoverPosition());
            foreach(var character in input)
            {
                switch(character)
                {
                    case 'L':
                        rover.RotateLeft();
                        break;
                    case 'R':
                        rover.RotateRight();
                        break;
                    case 'M':
                        rover.Move();
                        break;
                }
            }
            
            Console.Read();          
        }
    }
}
