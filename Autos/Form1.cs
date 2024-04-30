namespace Autos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            frmAuto auto = new frmAuto(cboColor.Text, txtAlias.Text);
            auto.Show();
        }
    }
}