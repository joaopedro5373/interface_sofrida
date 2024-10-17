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
    public partial class adicionarcliente_Form : Form
    {
        public string nome { get { return textBoxNome.Text; } }
        public string telefone { get { return textBoxTelefone.Text; } }
        public string email { get { return textBoxEmail.Text; } }
        public string endereco { get { return textBoxEndereco.Text; } }


        public adicionarcliente_Form()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_click_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_click_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void adicionarcliente_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
