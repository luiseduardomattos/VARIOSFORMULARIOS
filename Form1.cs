using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VARIOSFORMULARIOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(textBoxInserir.Text == "")
            {
                MessageBox.Show("Por favor insira um nome no campo!!!", "Aviso", MessageBoxButtons.OK);
                textBoxInserir.Focus();
                return;

            }
            // else é opcional por causa do Return

            textBoxMultiTexto.Text += textBoxInserir.Text + " ,";
            textBoxInserir.Clear();
            textBoxInserir.Focus();
        }
    }
}
