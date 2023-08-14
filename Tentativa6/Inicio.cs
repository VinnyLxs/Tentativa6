using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tentativa6
{
    public partial class Inicio : Form
    {
        DAO conectar;
        Pergunta1 pt1;


        public Inicio()
        { 

            InitializeComponent();
            conectar = new DAO();//Ligando o formulário ao Conector do banco
            pt1= new Pergunta1();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            acertos.Text = Variaveis.acertos.ToString();
            erros.Text = Variaveis.erros.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = conectar.inserir(nome.Text,"Jogadores");
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch



            pt1.ShowDialog();

        }//inserir

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
