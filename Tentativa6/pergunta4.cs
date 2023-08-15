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
    public partial class pergunta4 : Form
    {
        public pergunta4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Variaveis.acertos += 1;
            final fn = new final();
            fn.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            final fn = new final();
            fn.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            final fn = new final();
            fn.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            final fn = new final();
            fn.ShowDialog();
            this.Close();
        }

        private void pergunta4_Load(object sender, EventArgs e)
        {

        }
    }
}
