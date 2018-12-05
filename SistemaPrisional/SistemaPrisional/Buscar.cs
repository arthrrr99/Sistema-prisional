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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();

            txt_nome.Enabled = true;
            txt_CPF.Enabled = true;
            txt_RG.Enabled = true;
            txt_historico.Enabled = true;
            txt_nascimento.Enabled = true;
            pict_foto.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adicionar add = new Adicionar();
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.ShowDialog();
        }
    }
}
