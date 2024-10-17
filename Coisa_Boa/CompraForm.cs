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
    public partial class CompraForm : Form
    {
        public int idProduto { get { return (int)this.numericUpDownProduto.Value; } }
        public int idFornecedor { get { return (int)this.numericUpDownFornecedor.Value; } }
        public int quantidade { get { return (int)this.numericUpDownCOMPRA.Value; } }
        public float desconto { get { return (float)this.numericUpDownDesconto.Value; } }

        public CompraForm()
        {
            InitializeComponent();
        }

        private void CompraForm_Load(object sender, EventArgs e)
        {

        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numericUpDownProduto_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
