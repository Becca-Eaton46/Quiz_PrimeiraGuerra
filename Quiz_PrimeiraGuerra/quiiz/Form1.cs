using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // encerrar a aplicação
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pergunta1 p1 = new Pergunta1(); // objeto Pergunta1
            p1.ShowDialog(); // mostrar a tela Pergunta1

        }
    }
}
