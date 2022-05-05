using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtSaque.Text);
            List<int> listaResultado = CaixaEletronico.CaixaEletrtonico.calcularSaque(valor);

            listaResultado.ForEach(nota =>
            {
                lbResultado.Text += "\n" + nota.ToString();
            }); 
            lbResultado.Visible = true;
               
        }
    }
}
