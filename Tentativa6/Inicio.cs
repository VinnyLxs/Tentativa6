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

        public Inicio()
        { 

            InitializeComponent();
            conectar = new DAO();//Ligando o formulário ao Conector do banco
     
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           
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

            this.Hide();
            Pergunta1 p1 = new Pergunta1();
            p1.FormClosed += (s, args) => this.Close();
            p1.Show();

        }//inserir

        private void nome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
