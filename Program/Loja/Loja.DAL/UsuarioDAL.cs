using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DTO;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT*FROM tbUser";
                CM.Connection = CON;
                SqlDataReader ER;
                IList<usuario_DTO> listUsuarioDTO = new List<usuario_DTO>();
                CON.Open();
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        usuario_DTO usu = new usuario_DTO();
                        /*nome dos objetos criados na DTO
                        * Cada objeto criado é enviado para a lista, possibilitando
                        * que no final vc tenha uma lista com vários usuários */
                        usu.idUser = Convert.ToInt32(ER["idUser"]);
                        usu.perfil = Convert.ToInt32(ER["perfil"]);
                        usu.register = Convert.ToDateTime(ER["register"]);
                        usu.name = Convert.ToString(ER["name"]);
                        usu.email = Convert.ToString(ER["email"]);
                        usu.login = Convert.ToString(ER["register"]);
                        usu.password = Convert.ToString(ER["password"]);
                        usu.situation = Convert.ToString(ER["situation"]);
                        listUsuarioDTO.Add(usu);
                    }
                }
                return listUsuarioDTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
            
    }
}
