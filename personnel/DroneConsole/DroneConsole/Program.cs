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
            // Déclarations des objects 
            Drone[] tblDrone = { new Drone(0, 10, 50), new Drone(0, 15, 30) };

            // Paramètre 
            Console.CursorVisible = false;

            // Boucle qui fait tourner les drones jusqu'à qui reste aucun drone 
            while (oneIsAlive(tblDrone))
            {
                Console.Clear();

                for (int i = 0; i < tblDrone.Length; i++)
                {
                    tblDrone[i].changeState();
                    tblDrone[i].drawDrone();
                }

                Thread.Sleep(100);      // Pause de 0,1 sec
            }

            Console.ReadKey();
        }

        static public bool oneIsAlive(Drone[] tblDrone)
        {
            for (int i = 0; i < tblDrone.Length; i++)
            {
                if (tblDrone[i].Battery > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
