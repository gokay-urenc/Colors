using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renkler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rastgele = new Random();
            int renk = rastgele.Next(0, 256);
            int renk_2 = rastgele.Next(0, 256);
            int renk_3 = rastgele.Next(0, 256);
            this.BackColor = Color.FromArgb(renk, renk_2, renk_3);
        }
    }
}
