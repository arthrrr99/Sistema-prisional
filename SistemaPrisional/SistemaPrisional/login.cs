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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

            txt_usuario.Enabled = true;
            txt_senha.Enabled = true;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
           CadastrarPolicial pm = new CadastrarPolicial();
            pm.ShowDialog();
        }
    }
}
