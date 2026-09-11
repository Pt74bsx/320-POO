/******************************************************************************
** PROGRAMME  Program.cs                                                     **
**                                                                           **
** Lieu      : ETML - section informatique                                   **
** Auteur    : PT74BSX                                                       **
** Date      : 28.08.2026                                                    **
**                                                                           **
** Modifications                                                             **
** Auteur  :                                                                 **
** Version : X.X                                                             **
** Date    :                                                                 **
** Raisons :                                                                 **
**                                                                           **
**                                                                           **
******************************************************************************/

/******************************************************************************
** DESCRIPTION                                                               **
** Petit programme qui fait bouger un drone           	                     **
** avec système de position et de battrie                                    **
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DroneConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 2;

            List<Drone> drones = new List<Drone> { 
                new Drone(0, 10, 50), 
                new Drone(0, 15, 30) 
            };

            Console.CursorVisible = false;

            while (oneIsAlive(drones))
            {
                Console.Clear();

                foreach (Drone drone in drones)
                {
                    drone.changeState();
                    drone.drawDrone();
                }

                Thread.Sleep(100);

                count++; 

                if (count == 10)
                {
                    drones.Add(new Drone(0, 20, 60));
                }
            }

            Console.ReadKey();
        }

        static bool oneIsAlive(List<Drone> drones)
        {
            foreach (Drone drone in drones)
            {
                if (drone.Battery > 1)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
