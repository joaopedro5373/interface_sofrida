using System.ComponentModel;

namespace Coisa_Boa
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            this.dataGridView_lista.DataSource = produtos;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            Criar_Produto cp = new Criar_Produto();
            var resultado = cp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;

                produto.Nome = cp.nomeProduto;
                produto.Fabricante = cp.nomeFabricante;
                produto.PrecoVenda = cp.precoVenda;
                produto.PrecoCompra = cp.precoCompra;

                produtos.Add(produto);

            }
        }

        private void Remover_Click(object sender, EventArgs e)
        {
            if (dataGridView_lista.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView_lista.SelectedRows[0].Index);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonviewProdutos_Click(object sender, EventArgs e) { this.dataGridView_lista.DataSource = produtos; }

        private void butonViewClientes_Click(object sender, EventArgs e) { this.dataGridView_lista.DataSource = clientes; }

        private void buttonViewFornecedores_Click(object sender, EventArgs e) { this.dataGridView_lista.DataSource = fornecedores; }

        private void buttonViewCompras_Click(object sender, EventArgs e) { this.dataGridView_lista.DataSource = vendas; }

        private void buttonViewVendas_Click(object sender, EventArgs e) { this.dataGridView_lista.DataSource = compras; }

        private void dataGridView_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }


        private void adicionarCliente_click_Click(object sender, EventArgs e)
        {
            adicionarcliente_Form ad = new adicionarcliente_Form();
            var resultado = ad.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (clientes.Count == 0) cliente.id = 1;
                else cliente.id = clientes.Max(x => x.id) + 1;

                cliente.nome = ad.nome;
                cliente.telefone = ad.telefone;
                cliente.email = ad.email;
                cliente.endereco = ad.endereco;

                clientes.Add(cliente);
            }
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView_lista.SelectedRows.Count > 0)
            {
                clientes.RemoveAt(dataGridView_lista.SelectedRows[0].Index);
            }
        }

        private void adicionarFornecedor_click_Click(object sender, EventArgs e)
        {
            Fornecedores_Form fo = new Fornecedores_Form();
            var resultado = fo.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = fornecedores.Max(x => x.Id) + 1;

                fornecedor.nome = fo.nome;
                fornecedor.telefone = fo.telefone;
                fornecedor.email = fo.email;
                fornecedor.endereco = fo.endereco;

                fornecedores.Add(fornecedor);
            }
        }

        private void removerFornecedor_click_Click(object sender, EventArgs e)
        {
            if (dataGridView_lista.SelectedRows.Count > 0)
            {
                fornecedores.RemoveAt(dataGridView_lista.SelectedRows[0].Index);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarCompra_Click(object sender, EventArgs e)
        {
            CompraForm cf = new CompraForm();
            var resultado = cf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (compras.Count == 0) compra.id = 1;
                else compra.id = compras.Max(x => x.id) + 1;

                compra.idProduto = cf.idProduto;
                compra.idFornecedor = cf.idFornecedor;
                compra.quantidade = cf.quantidade;
                compra.desconto = cf.desconto;

                compras.Add(compra);
            }
        }

        private void RemoverCompra_Click(object sender, EventArgs e)
        {
            if(dataGridView_lista.SelectedRows.Count > 0)
            {
                compras.RemoveAt(dataGridView_lista.SelectedRows[0].Index);
            }
        }
    }
}