﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tentativa6
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Variaveis.acertos += 1;
            this.Hide();
            Pergunta2 p2 = new Pergunta2();
            p2.FormClosed += (s, args) => this.Close();
            p2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            this.Hide();
            Pergunta2 p2 = new Pergunta2();
            p2.FormClosed += (s, args) => this.Close();
            p2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            this.Hide();
            Pergunta2 p2 = new Pergunta2();
            p2.FormClosed += (s, args) => this.Close();
            p2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Variaveis.erros += 1;
            this.Hide();
            Pergunta2 p2 = new Pergunta2();
            p2.FormClosed += (s, args) => this.Close();
            p2.Show();
        }

        private void Pergunta1_Load(object sender, EventArgs e)
        {

        }
    }
}
