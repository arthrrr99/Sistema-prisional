using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrisional
{
    public partial class CadastrarPolicial : Form
    {
        public CadastrarPolicial()
        {
            InitializeComponent();

            txt_nome.Enabled = true;
            txt_senha.Enabled = true;
            txt_confirmarsenha.Enabled = true;
            txt_usuario.Enabled = true;
            txt_identificacao.Enabled = true;
            txt_autorizacao.Enabled = true;
            txt_nascimento.Enabled = true;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
