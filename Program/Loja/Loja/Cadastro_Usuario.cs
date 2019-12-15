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
        string modo = string.Empty;
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        private void Cadastro_Usuario_Load(object sender, EventArgs e)
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


    }
}
