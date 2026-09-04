using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneConsole
{
    public class Drone
    {
        // Properties
        private int _posX;
        private int _posY;
        private int _battery;

        public int Battery { get => _battery; }

        /// <summary>
        /// Construction pérsonalisé du drone
        /// </summary>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        /// <param name="battery"></param>
        public Drone(int posX, int posY, int battery)
        {
            this._posX = posX;
            this._posY = posY;
            this._battery = battery;
        }

        /// <summary>
        /// Construction par défaut du drone 
        /// </summary>
        public Drone()
        {
            this._posX = 0;
            this._posY = 10;
            this._battery = 50;
        }

        /// <summary>
        /// Changer l'état du drone 
        /// </summary>
        public void changeState()
        {
            if (_battery > 0)
            {
                _posX = _posX + 1;
                _battery = _battery - 2;
            }
        }

        /// <summary>
        /// Afficher le drone et sa batterie
        /// </summary>
        public void drawDrone()
        {
            Console.SetCursorPosition(_posX, _posY);
            if (_battery <= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("  " + _battery + "%");
                Console.SetCursorPosition(_posX, _posY + 1);
                Console.Write("x-O-x");
                Console.ResetColor();
            }
            else
            {
                if (_battery <= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  " + _battery + "%");
                    Console.ResetColor();
                    Console.SetCursorPosition(_posX, _posY + 1);
                    Console.Write("x-O-x");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" " + _battery + "%");
                    Console.ResetColor();
                    Console.SetCursorPosition(_posX, _posY + 1);
                    Console.Write("x-O-x");
                }
            }   
        }
    }
}
