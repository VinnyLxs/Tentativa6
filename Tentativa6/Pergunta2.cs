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
    public partial class Pergunta2 : Form
    {
        public Pergunta2()
        {
            InitializeComponent();
        }

        private void Pergunta2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variaveis.acertos += 1;
            pergunta3 p3 = new pergunta3();
            p3.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            pergunta3 p3 = new pergunta3();
            p3.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            pergunta3 p3 = new pergunta3();
            p3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            pergunta3 p3 = new pergunta3();
            p3.ShowDialog();
            this.Close();
        }
    }
}
