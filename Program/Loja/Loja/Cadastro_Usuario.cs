using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DTO;
using Loja.BLL;

namespace Loja
{
    public partial class Cadastro_Usuario : Form
    {
        string modo = "";
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void Cadastro_Usuario_Load(object sender, EventArgs e)
        {

            carregaGrid();
        }

        public void carregaGrid()
        {
            try
            {
                IList<usuario_DTO> listUsuario_DTO = new List<usuario_DTO>();
                listUsuario_DTO = new UsuarioBLL().cargaUsuario();
                /*Preencher dados no DataGridView*/
                dataGridView1.DataSource = listUsuario_DTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cadastro_Usuario_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loja2DataSet.tbUser' table. You can move, or remove it, as needed.
            this.tbUserTableAdapter.Fill(this.loja2DataSet.tbUser);

        }
    }
}
