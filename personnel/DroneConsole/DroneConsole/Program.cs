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
using System.Threading.Tasks;

namespace DroneConsole
{
    internal class Program
    {
        // Déclarations des constantes
        const int POS_Y = 20;           // Position Y du drone 

        static void Main(string[] args)
        {
            // Déclarations des variables 
            int pos_X = 0;              // Position X du drone 
            int batterie = 50;          // Batterie du drone 

            Console.Clear();

            Console.CursorVisible = false;
            Console.SetCursorPosition(pos_X, POS_Y);
            Console.Write("x-O-x");
            Console.SetCursorPosition(pos_X, POS_Y - 1);
            Console.Write(batterie + "%");

            System.Threading.Thread.Sleep(500);

            while (batterie > 0) 
            {
                Console.Clear();
                Console.SetCursorPosition(pos_X, POS_Y);

                if (batterie == 2)
                {
                    Console.Write("____");
                    Console.SetCursorPosition(pos_X, POS_Y - 1);
                    Console.Write("Drone mort");
                    System.Threading.Thread.Sleep(500);
                    break;
                }

                if (batterie >= 3)
                {
                    pos_X = pos_X + 1;
                    batterie = batterie - 2;
                    Console.Write("x-O-x");
                    Console.SetCursorPosition(pos_X, POS_Y - 1);
                    Console.Write(batterie + "%");
                }

                System.Threading.Thread.Sleep(500);
            }

            Console.ReadLine();
        }
    }
}
