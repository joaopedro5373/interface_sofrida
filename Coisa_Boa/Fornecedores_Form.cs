using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coisa_Boa
{
    public partial class Fornecedores_Form : Form
    {
        public string nome { get { return textBoxNome.Text; }  }
        public string telefone { get { return textBoxTelefone.Text;  } }
        public string email { get { return textBoxEmail.Text; }  }
        public string endereco { get { return textBoxEndereco.Text; }  }

        public Fornecedores_Form()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_click_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_click_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Fornecedores_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
