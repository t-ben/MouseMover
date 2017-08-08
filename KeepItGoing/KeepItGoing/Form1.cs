using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KeepItGoing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool flipper = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            if (flipper)
            {
                Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y);
            }
            else
            {
                Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);    
            }
            flipper = !flipper;
        }
    }
}
