using System.Data;

namespace ExamenU2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizarUsuario frm = new frmActualizarUsuario(
                dataGridView1[0, e.RowIndex].Value.ToString(),
                dataGridView1[1, e.RowIndex].Value.ToString(),
                dataGridView1[2, e.RowIndex].Value.ToString(),
                dataGridView1[3, e.RowIndex].Value.ToString(),
                dataGridView1[4, e.RowIndex].Value.ToString(),
                dataGridView1[5, e.RowIndex].Value.ToString()
                );
            frm.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ClassdDAT classdDAT = new ClassdDAT();
            DataSet dataSet = classdDAT.Consulta("select ID, APATERNO as [APELLIDO PATERNO],AMATERNO as [APELLIDO MATERNO],NOMBRE,TELEFONO,CORREO" +
                                                 "\r\nfrom USUARIOS");

            if (dataSet != null)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertar frm = new frmInsertar();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
