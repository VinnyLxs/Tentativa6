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
    public partial class Form1 : Form
    {
        Inicio ini;
        DAO conectar;
        public Form1()
        {
            InitializeComponent();
            ini= new Inicio();
            conectar= new DAO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ini.ShowDialog();
        }
    }
}
