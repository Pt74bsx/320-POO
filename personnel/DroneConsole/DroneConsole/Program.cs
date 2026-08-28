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

            System.Threading.Thread.Sleep(500);     // Pause de 0,5 sec

            // Boucle qui se répéte tant que la battrie est plus grande que 0
            while (batterie > 0)
            {
                Console.Clear();
                Console.SetCursorPosition(pos_X, POS_Y);

                // Affichage drone quand il a plus de batterie 
                if (batterie == 2)
                {
                    Console.Write("____");
                    Console.SetCursorPosition(pos_X, POS_Y - 1);
                    Console.Write("Drone mort");
                    System.Threading.Thread.Sleep(500);
                    break;
                }

                // Drone fonctionne si la batterie est plus grande ou égal à 3
                if (batterie >= 3)
                {
                    batterie = etatDrone(batterie);
                    pos_X = DrawDrone(pos_X, POS_Y, batterie);
                }

                System.Threading.Thread.Sleep(500);  // Pause de 0,5 sec
            }

            Console.ReadLine(); // Permet d'éviter la fermeture du programme (temporaire)
        }

        /// <summary>
        /// Méthode qui permet de dessinner 
        /// le drone et sa batterie
        /// au bonne endroit 
        /// </summary>
        /// <param name="pos_X"></param>
        /// <param name="POS_Y"></param>
        /// <param name="batterie"></param>
        /// <returns></returns>
        static int DrawDrone(int pos_X, int POS_Y, int batterie)
        {
            pos_X = pos_X + 1;
            Console.Write("x-O-x");
            Console.SetCursorPosition(pos_X, POS_Y - 1);
            Console.Write(batterie + "%");

            return pos_X;
        }

        /// <summary>
        /// Méthode qui permet de gérer 
        /// l'état du drone comme la batterie
        /// </summary>
        /// <param name="batterie"></param>
        /// <returns></returns>
        static int etatDrone(int batterie)
        {
            batterie = batterie - 2;

            return batterie;
        }
    }
}
