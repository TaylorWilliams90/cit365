using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TaylorWilliams
{
    class DeskQuote
    {
        #region Odject member variables
        private String CustomerName;
        private DateTime QuoteDate;
        private Desk Desk = new Desk();
        private int Rushdays;
        private double QuoteAmount;
        private string Material;
        #endregion
        #region local variables

        #endregion

        private const int PRICE_BASE = 200;
        private const double SIZE_THRESHOLD = 1000;
        private const double DOUBLE_SIZE_THRESHOLD = 2000;
        private const int PRICE_PER_DRAWER = 50;
        private const int THREE_DAY_RUSH = 3;
        private const int FIVE_DAY_RUSH = 5;
        private const int SEVEN_DAY_RUSH = 7;



        public DeskQuote(double width, double depth, int drawers, string material, int rushDays)
        {
            Desk.Width = width;
            Desk.Depth = depth;
            Desk.NumbersOfDrawers = drawers;
            Desk.DesktopMaterial = material;
            Desk.ProductionTime = rushDays;

        }

        public double CalculateQuoteTotal ()
        {
            return PRICE_BASE + DrawerCost() + SurfaceAddon() + MaterialAddon() + ProductionRate();
        }

        private int DrawerCost()
        {
            return Desk.NumbersOfDrawers * PRICE_PER_DRAWER;

        }

        private double SurfaceAddon()
        {
            double surfaceArea = Desk.Width * Desk.Depth;
            if (surfaceArea < SIZE_THRESHOLD)
            {
                return surfaceArea * 1;
            }
            if (surfaceArea > SIZE_THRESHOLD && surfaceArea < DOUBLE_SIZE_THRESHOLD)
            {
                return surfaceArea * 2;
            }
            else
                return surfaceArea * 3;
        }

        private int MaterialAddon()
        {
            switch (Desk.DesktopMaterial)
            {
                case "oak": return 200;
                case "laminate": return 100;
                case "rosewood": return 250;
                case "veneer": return 100;
                case "pine": return 75;
                default: return 75;
            }
        }

        private double ProductionRate()
        {
            int rate = 60;
            double surfaceArea = Desk.Width * Desk.Depth;
            if (surfaceArea < SIZE_THRESHOLD && Desk.ProductionTime == THREE_DAY_RUSH)
            {
                rate = 60;
            }
            if (surfaceArea > SIZE_THRESHOLD && surfaceArea < DOUBLE_SIZE_THRESHOLD && Desk.ProductionTime == THREE_DAY_RUSH)
            {
                rate = 70;
            }
            if (surfaceArea < DOUBLE_SIZE_THRESHOLD && Desk.ProductionTime == THREE_DAY_RUSH)
            {
                rate = 80;
            }
            if (surfaceArea < SIZE_THRESHOLD && Desk.ProductionTime == FIVE_DAY_RUSH)
            {
                rate = 40;
            }
            if (surfaceArea > SIZE_THRESHOLD && surfaceArea < DOUBLE_SIZE_THRESHOLD && Desk.ProductionTime == FIVE_DAY_RUSH)
            {
                rate = 50;
            }
            if (surfaceArea < DOUBLE_SIZE_THRESHOLD && Desk.ProductionTime == FIVE_DAY_RUSH)
            {
                rate = 60;
            }
            if (surfaceArea < SIZE_THRESHOLD && Desk.ProductionTime == SEVEN_DAY_RUSH)
            {
                rate = 30;
            }
            if (surfaceArea > SIZE_THRESHOLD && surfaceArea < DOUBLE_SIZE_THRESHOLD && Desk.ProductionTime == SEVEN_DAY_RUSH)
            {
                rate = 35;
            }
            if (surfaceArea < DOUBLE_SIZE_THRESHOLD && Desk.ProductionTime == SEVEN_DAY_RUSH)
            {
                rate = 40;
            }

            return rate;
        }
    }
}
