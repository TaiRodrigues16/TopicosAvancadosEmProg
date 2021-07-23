using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeFinalTAP
{
    using servCEP;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(inputPesquisa.Text);
                text.Text = "Endereco: " + resposta.end + "\nBairro: " + resposta.bairro + "\nCidade: " + resposta.cidade;
            }

            
        }

        private void inputPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
