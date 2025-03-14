using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU2
{
    public partial class frmInsertar : Form
    {
        public frmInsertar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassdDAT cd = new ClassdDAT();
            bool f = cd.comando("INSERT INTO USUARIOS VALUES " +
                "               \r\n('" + textBoxAP.Text + "','" + textBoxAM.Text + "','" + textBoxNM.Text + "','" + maskedTextBox1.Text + "','" + textBoxCRR.Text + "')");

            if (f)
            {
                MessageBox.Show("Datos Insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al insertar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxTEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
