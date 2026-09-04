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
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DroneConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclarations des objects 
            Drone drone = new Drone(0, 10, 50);

            // Paramètre 
            Console.CursorVisible = false;

            // Boucle qui fait tourner les drones jusqu'à qui reste aucun drone 
            while (drone.oneIsAlive())
            {
                drone.changeState();
                drone.drawDrone();
                System.Threading.Thread.Sleep(500);             // Pause de 0,5 sec

                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
