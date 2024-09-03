using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAplicacionBroma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_MouseHover(object sender, EventArgs e)
        {
            Random rnd = new Random(); 
            int lnHorizontal = this.ClientSize.Width - btnAceptar.Width; 
            int lnVertical = this.ClientSize.Height - btnAceptar.Height; 
            int lnNuevaCoordenadaX = rnd.Next(0, lnHorizontal); 
            int lnNuevaCoordenadaY = rnd.Next(0, lnVertical); 
            btnAceptar.Location = new Point(lnNuevaCoordenadaX, lnNuevaCoordenadaY); }
        }
}
