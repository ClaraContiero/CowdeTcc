using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc_cowde.Models;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace mvc_cowde.Models
{
    public class UsuarioCadastrado
    {
        //essa classe tem a finalidade de guardar os atributos de um usuario que ja foi cadastrado e irá efetuar o login
        //esses atributos são usados no controller de login    
        public string email { get; set; }

        public string senha { get; set; }

        static MySqlConnection con =
           Conexao.getConexao();

        public UsuarioCadastrado(string email, string senha)
        {
            this.email = email;
            this.senha = senha;
        }

        public UsuarioCadastrado(string email)
        {
            this.email = email;
        }

        public static bool VerificarUsuarios(string email, string senha)
        {
            bool status = false;
            try
            {
                con.Open();
                MySqlCommand qry = new MySqlCommand(
                    "SELECT * FROM tb_usuario WHERE email = @email AND senha = @senha", con);
                qry.Parameters.AddWithValue("@email", email);
                qry.Parameters.AddWithValue("@senha", senha);

                UsuarioCadastrado uc = null;

                MySqlDataReader leitor = qry.ExecuteReader();

                while (leitor.Read())
                {
                    uc = new UsuarioCadastrado(
                        leitor["email"].ToString(),
                        leitor["senha"].ToString()
                      );
                    status = true;
                }

                //var resultado = qry.ExecuteScalar();

                //if (resultado != null)
                //{
                //return status = true;
                //}

                con.Close();
            }
            catch (Exception e)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            return status;
        }


        public static object Listar(string email)
        {
            Controllers.DadosController listar = new Controllers.DadosController();
            ConversorJSON conversor = new ConversorJSON();
            return conversor.ConverteObjectParaJSon(listar.ListarDados(email));
        }


    }
}
