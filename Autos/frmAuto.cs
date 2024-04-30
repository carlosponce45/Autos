using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autos
{
    public partial class frmAuto : Form
    {
        Auto auto;
        public frmAuto(string color, string alias)
        {
            InitializeComponent();
            auto = new Auto();
            auto.Pintar(color);
            auto.setAlias(alias);
        }

        private void frmAuto_Load(object sender, EventArgs e)
        {
            switch (auto.DevovlerColor())
            {
                case "ROJO":
                    BackColor = Color.Red;
                    break;
                case "AMARILLO":
                    BackColor = Color.Yellow;
                    break;
                case "VERDE":
                    BackColor = Color.Green;
                    break;
            }
            Text = auto.getAlias();
        }

        private void cmdAcelerar_Click(object sender, EventArgs e)
        {
            auto.Acelerar();
            lblVelocidad.Text = auto.DevolverVelocidad().ToString("000");
        }

        private void cmdFrenar_Click(object sender, EventArgs e)
        {
            auto.Frenar();
            lblVelocidad.Text = auto.DevolverVelocidad().ToString("000");
        }
    }
}
