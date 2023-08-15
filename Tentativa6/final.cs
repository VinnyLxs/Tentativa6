using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tentativa6
{
    public partial class final : Form
    {
        DAO entrar;


        public final()
        {
            InitializeComponent();
            entrar = new DAO();

        }

        private void final_Load(object sender, EventArgs e)
        {
            acertos.Text = Variaveis.acertos.ToString();
            erros.Text = Variaveis.erros.ToString();

        }

        private void acertos_Click(object sender, EventArgs e)
        {

        }

        private void erros_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = entrar.Pontuacao (acertos.Text, erros.Text, "Pontuacao");
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }

           this.Close();    
        }
    }
}
