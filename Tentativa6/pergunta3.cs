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
    public partial class pergunta3 : Form
    {
        public pergunta3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Variaveis.acertos += 1;
            this.Hide();
            pergunta4 p4 = new pergunta4();
            p4.FormClosed += (s, args) => this.Close();
            p4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            this.Hide();
            pergunta4 p4 = new pergunta4();
            p4.FormClosed += (s, args) => this.Close();
            p4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            this.Hide();
            pergunta4 p4 = new pergunta4();
            p4.FormClosed += (s, args) => this.Close();
            p4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            this.Hide();
            pergunta4 p4 = new pergunta4();
            p4.FormClosed += (s, args) => this.Close();
            p4.Show();
        }

        private void pergunta3_Load(object sender, EventArgs e)
        {

        }
    }
}
