using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TaylorWilliams
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            // use List<T> to populate a comobox
            List<DesktopMaterial> MaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            MaterialBox.DataSource = MaterialList;

            List<RushTime> RushlList = Enum.GetValues(typeof(RushTime)).Cast<RushTime>().ToList();
            DaysBox.DataSource = RushlList;
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MegaDesk)Tag;
            mainMenu.Show();
            Close();
        }

        private void width_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char w = e.KeyChar;

            if (!Char.IsDigit(w) && w != 8 && w != 46)
            {
                e.Handled = true;
            }
        }

        private void depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char w = e.KeyChar;

            if (!Char.IsDigit(w) && w != 8 && w != 46)
            {
                e.Handled = true;
            }
        }

        private void CalcQuote_Click(object sender, EventArgs e)
        {

        }
    }
}
