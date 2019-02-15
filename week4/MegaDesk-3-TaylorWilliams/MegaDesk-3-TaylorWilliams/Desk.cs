using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TaylorWilliams
{
    class Desk
    {
        public double Width { get; set; }
        public double Depth { get; set; }
        public int NumbersOfDrawers { get; set; }
        public DesktopMaterial DesktopMaterial { get; set; }
        public RushTime ProductionTime { get; set; }
    }

    public enum DesktopMaterial
    {
        Pine = 50,
        Laminate = 100,
        Oak = 200,
        RoseWood = 300,
        Veneer = 125,
    }

    public enum RushTime
    {
        Defualt = 14,
        three = 3,
        Five = 5,
        Seven = 7,
    }
}
