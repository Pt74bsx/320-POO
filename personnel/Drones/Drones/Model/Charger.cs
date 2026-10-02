using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    // La borne de recharge qui permet aux drones de se recharger 
    public class Charger
    {
        private const int SIZE = 20;                                                         
        private static readonly Pen _chargerBrush = new Pen(new SolidBrush(Color.Green), 3);        

        private int _x;
        private int _y;

        public int X => _x;
        public int Y => _y;

        public Charger(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Création du rond 
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(_chargerBrush, _x - SIZE / 2, _y - SIZE / 2, SIZE, SIZE);
        }
    }
}
