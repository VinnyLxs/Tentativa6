using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

 

using System.Windows.Forms;
using System.Windows.Markup;
using System.Web;

namespace Tentativa6
    {
        class DAO
        {
            public MySqlConnection conexao;
            
        
            public DAO()
            {
                conexao = new MySqlConnection("server=localhost;DataBase=JogoDeAdivinhacao;Uid=root;password=");
                try
                {
                    conexao.Open();
                } catch (Exception erro)
                {
                    MessageBox.Show("Algo deu errado! \n\n" + erro.Message);
                }
            }

            public string inserir (string nome, string nomeTabela)
            {
                string inserir = $"Insert into {nomeTabela}(nome) values('{nome}')";
                MySqlCommand sql = new MySqlCommand(inserir, conexao);
                string resultado = sql.ExecuteNonQuery() + " Executado!";
                return resultado;
            }
            public string Pontuacao (string acertos,string Erros , string nomeTabela)
            {
                string inserir = $"Insert into {nomeTabela}(acertos, Erros) values('{acertos}','{Erros}')";
                MySqlCommand sql = new MySqlCommand (inserir, conexao);
                string resultado = sql.ExecuteNonQuery() + " Executado!";
                return resultado;
            }
        }
}
