using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Http;


namespace mvc_cowde.Models
{
    public class CadastroLogin
    {
        //abrindo conexao com banco de dados
        static MySqlConnection con =
            Conexao.getConexao();

        //atributos da classe que fazem referência às informações do usuário 
        public int id_usuario;
        public string nome;
        public string nome_usuario;
        public string email;
        public int senha;
        public int idade;
        private string avatar;
        public CadastroLogin()
        {
        }

        public CadastroLogin(string avatar)
        {
            this.avatar = avatar;
        }
        //construtor
        public CadastroLogin(string nome, string nome_usuario, string email, int idade, int senha)
        {
            this.nome = nome;
            this.nome_usuario = nome_usuario;
            this.email = email;
            this.idade = idade;
            this.senha = senha;
        }

        public CadastroLogin(string nome, string nome_usuario, string email)
        {
            this.nome = nome;
            this.nome_usuario = nome_usuario;
            this.email = email;
        }

        public CadastroLogin(int id_usuario, string nome, string nome_usuario, string email, int idade, int senha)
        {
            this.id_usuario = id_usuario;
            this.nome = nome;
            this.nome_usuario = nome_usuario;
            this.email = email;
            this.idade = idade;
            this.senha = senha;
        }

        public CadastroLogin(int v1, string v2, string v3)
        {
        }

        public CadastroLogin(int v1, string v2)
        {
        }

        //Foi preciso criar esse construtor dando argumentos aos parametros criados para corrigir o erro CS7036

        public static bool EmailJaCadastrado(string email)
        {
            bool status = false;
            try
            {
                con.Open();

                MySqlCommand qry = new MySqlCommand("SELECT email FROM tb_usuario WHERE email = @email", con);
                qry.Parameters.AddWithValue("@email", email);
                UsuarioCadastrado uc = null;
                MySqlDataReader leitor = qry.ExecuteReader();

                while (leitor.Read())
                {
                    uc = new UsuarioCadastrado(
                    leitor["email"].ToString());
                    status = true;
                }

                con.Close();
            }
            catch (Exception e)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            return status;
        }


        //internal static é uma chave de acesso para arquivos, classes, métodos, variaveis, et

        //método de cadastrar que vai ser ligado com os componentes de tela da página de cadastro utilizando o controller
        internal string CadastrarModel()
        {
            //tentando fazer um procedimento
            try
            {
                if (EmailJaCadastrado(this.email) == true)
                {
                    return "Jogador já foi cadastado";
                }
                else
                {
                    con.Open();

                    //instanciando classe dos comandos mysql
                    MySqlCommand qry = new MySqlCommand(
                        //o parametro é o nome da coluna no bcd
                        "INSERT INTO tb_usuario (nome,nome_usuario, email, idade, senha) VALUES(@nome,@nome_usuario, @email, @idade, @senha)", con);//comando mysql para adicionar informações em uma tabela
                                                                                                                                                    //dando valor aos parametros utilizados no mysqlcommand
                    qry.Parameters.AddWithValue("@nome", this.nome);
                    qry.Parameters.AddWithValue("@nome_usuario", this.nome_usuario);
                    qry.Parameters.AddWithValue("@email", this.email);
                    qry.Parameters.AddWithValue("@idade", this.idade);
                    qry.Parameters.AddWithValue("@senha", this.senha);

                    qry.ExecuteNonQuery();
                    con.Close();
                    return "Jogador cadastrado com sucesso!";
                }
            }
            catch (Exception e)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return e.Message;
            }
        }

        internal string AutualizarModel(string emailRecebido)
        {
            //tentando fazer um procedimento
            try
            {
                CadastroLogin usuario = new CadastroLogin();
                mvc_cowde.Controllers.DadosController listar = new mvc_cowde.Controllers.DadosController();
                usuario = listar.ListarDados(emailRecebido);

                con.Open();

                //instanciando classe dos comandos mysql
                MySqlCommand qry = new MySqlCommand(
                //o parametro é o nome da coluna no bcd
                "UPDATE tb_usuario SET nome = @nome WHERE id_usuario = @id_usuario", con);//comando mysql para adicionar informações em uma tabela

                qry.Parameters.AddWithValue("@id_usuario", usuario.id_usuario);

                if (this.nome != null || this.nome != "")
                {
                    qry.Parameters.AddWithValue("@nome", this.nome);
                }
                else
                {
                    qry.Parameters.AddWithValue("@nome", usuario.nome);
                }

                qry.ExecuteNonQuery();


                //instanciando classe dos comandos mysql
                MySqlCommand qry1 = new MySqlCommand(
                //o parametro é o nome da coluna no bcd
                "UPDATE tb_usuario SET nome_usuario = @nome_usuario WHERE id_usuario = @id_usuario", con);
                //comando mysql para adicionar informações em uma tabela

                //dando valor aos parametros utilizados no mysqlcommand
                qry1.Parameters.AddWithValue("@id_usuario", usuario.id_usuario);

                if (this.nome_usuario != null || this.nome_usuario != "")
                {
                    qry1.Parameters.AddWithValue("@nome_usuario", this.nome_usuario);
                }
                else
                {
                    qry1.Parameters.AddWithValue("@nome_usuario", usuario.nome_usuario);
                }

                qry1.ExecuteNonQuery();

                con.Close();

                return "Nome atualizado com sucesso!";

            }
            catch (Exception e)
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return e.Message;
            }
        }

        internal string PassarEmail(string email)
        {
            email = this.email;
            return email;
        }

        //buscar a img do banco
        static public CadastroLogin list_img(string email)
        {
            CadastroLogin user = new CadastroLogin();
            try
            {
                con.Open();

                //instanciando classe dos comandos mysql
                MySqlCommand listar = new MySqlCommand(
                //o parametro é o nome da coluna no bcd
                "SELECT * FROM tb_usuario where email = @id", con);
                //comando mysql para adicionar informações em uma tabela

                //dando valor aos parametros utilizados no mysqlcommand
                listar.Parameters.AddWithValue("@id", email);
                MySqlDataReader leitor = listar.ExecuteReader();

                while (leitor.Read())
                {
                    user = new CadastroLogin(leitor["perfil"].ToString());
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }


            return user;
        }

        static public string salvarAvat(string imagem, string email)
        {
            string sitAvatar = "";

            try
            {
                con.Open();

                MySqlCommand salvarImg = new MySqlCommand("update tb_usuario set perfil = @imagem where email = @email", con);
                salvarImg.Parameters.AddWithValue("@imagem", imagem);
                salvarImg.Parameters.AddWithValue("@email", email);

                salvarImg.ExecuteNonQuery();
                sitAvatar = "Sucesso uhu";

            }
            catch (Exception)
            {
                sitAvatar = "Erro de conexão.";
                throw;
            }
            finally
            {
                con.Close();
            }
            return sitAvatar;
        }


        //getters e setters
        //a finalidade de getters condiz com o controle de acesso dos atributos de uma classe, ele é utilizado para pegar o valor desse atributo/retornar o valor
        //já o setters, faz o papel de definir e atualizar o valor de um atributo
        public string Nome { get => nome; set => nome = value; }
        public string Nome_Usuario { get => nome_usuario; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }
        public int Senha { get => senha; set => senha = value; }
        public string Avatar { get => avatar; set => avatar = value; }
    }
}