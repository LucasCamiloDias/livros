using livros.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livros.View
{
    public partial class biblioteca : Form
    {   Emprestimo emprestimo = new Emprestimo();
        public biblioteca()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
 
            lbl_nomecli.Text = "Nome cliente: " + txt_nomeCi.Text;
            lbl_cpfcli.Text = "Ano livro: " + txt_CpfCli.Text;
            lbl_nmcli.Text = "Nome do Livro: " + txt_NomeLivro.Text;
            lbl_anolivro.Text = "CPF Cliente: " + txt_AnoLivro.Text;

            string UF = cBox_desc.Text;
            decimal v = Convert.ToDecimal(txt_ValorLivro.Text);
            lbl_resultado.Text = lbl_resultado.Text + emprestimo.Calcular(UF, v).ToString();
        }
    }
}
