using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc_cowde.Models;

namespace mvc_cowde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosController : ControllerBase
    {
        public DadosController()
        { }

        //Método para buscar os dados de um usuário em específico através do seu email
        [HttpGet]
        [Route("/api/[Controller]/{email}")] //Renomear pois já tem um método que usa o GET
        public CadastroLogin ListarDados(string email)
        {
            Models.CadastroLogin usuario = null;

            MySql.Data.MySqlClient.MySqlConnection con = Models.Conexao.getConexao();
            try
            {
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM tb_usuario WHERE email = @e; ", con);
                cmd.Parameters.AddWithValue("@e", email);
                con.Open();

                MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Atribuir os dados do banco ao objeto "u"
                    usuario = new Models.CadastroLogin(reader.GetInt32("id_usuario"), reader.GetString("nome"), reader.GetString("nome_usuario"),
                    reader.GetString("email"), reader.GetInt32("idade"), reader.GetInt32("senha"));
                }
            }
            catch (Exception)
            {
                throw;
            }

            return usuario;
        }
    }
}
