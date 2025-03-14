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
    public partial class frmActualizarUsuario : Form
    {
        public frmActualizarUsuario(string id, string apaterno, string amaterno, string nombre, string telefono, string correo)
        {
            InitializeComponent();
            textBoxID.Text = id;
            textBoxAP.Text = apaterno;
            textBoxAM.Text = amaterno;
            textBoxNM.Text = nombre;
            maskedTextBox1.Text = telefono;
            textBoxCRR.Text = correo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassdDAT cd = new ClassdDAT();
            bool f = cd.comando("update USUARIOS set " +
                "\r\nAPATERNO='" + textBoxAP.Text + "'," +
                "\r\nAMATERNO='" + textBoxAM.Text + "'," +
                "\r\nNOMBRE='" + textBoxNM.Text + "'," +
                "\r\nTELEFONO='" + maskedTextBox1.Text + "'," +
                "\r\nCORREO='" + textBoxCRR.Text + "'" +
                "\r\nWHERE ID=" + textBoxID.Text);

            if (f)
            {
                MessageBox.Show("Datos Actualizado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassdDAT cd = new ClassdDAT();
            bool f = cd.comando("delete from USUARIOS" +
                                "\r\nwhere ID =" + textBoxID.Text);
            if (f)
            {
                MessageBox.Show("Datos Eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
