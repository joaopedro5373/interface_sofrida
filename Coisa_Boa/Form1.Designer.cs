namespace Coisa_Boa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Adicionar = new Button();
            Remover = new Button();
            dataGridView_lista = new DataGridView();
            buttonviewProdutos = new Button();
            buttonViewFornecedores = new Button();
            butonViewClientes = new Button();
            buttonViewCompras = new Button();
            buttonViewVendas = new Button();
            removerCliente_click = new Button();
            adicionarCliente_click = new Button();
            removerFornecedor_click = new Button();
            adicionarFornecedor_click = new Button();
            adicionarCompra_click = new Button();
            removerCompra_click = new Button();
            removerVenda_click = new Button();
            adicionarVenda_click = new Button();
            buttonRemoverCliente = new Button();
            AdicionarCompra = new Button();
            RemoverCompra = new Button();
            RemoverVenda = new Button();
            AdicionarVenda = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista).BeginInit();
            SuspendLayout();
            // 
            // Adicionar
            // 
            Adicionar.BackColor = Color.FromArgb(255, 192, 192);
            Adicionar.Cursor = Cursors.Hand;
            Adicionar.ForeColor = Color.FromArgb(64, 0, 0);
            Adicionar.Location = new Point(12, 63);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(159, 23);
            Adicionar.TabIndex = 0;
            Adicionar.Text = "Adicionar Produto";
            Adicionar.UseVisualStyleBackColor = false;
            Adicionar.Click += Adicionar_Click;
            // 
            // Remover
            // 
            Remover.BackColor = Color.FromArgb(255, 192, 192);
            Remover.Cursor = Cursors.Hand;
            Remover.ForeColor = Color.FromArgb(64, 0, 0);
            Remover.Location = new Point(12, 92);
            Remover.Name = "Remover";
            Remover.Size = new Size(159, 23);
            Remover.TabIndex = 1;
            Remover.Text = "Remover Produto";
            Remover.UseVisualStyleBackColor = false;
            Remover.Click += Remover_Click;
            // 
            // dataGridView_lista
            // 
            dataGridView_lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_lista.Location = new Point(12, 121);
            dataGridView_lista.Name = "dataGridView_lista";
            dataGridView_lista.ShowCellToolTips = false;
            dataGridView_lista.Size = new Size(819, 508);
            dataGridView_lista.TabIndex = 2;
            dataGridView_lista.CellContentClick += dataGridView_lista_CellContentClick;
            // 
            // buttonviewProdutos
            // 
            buttonviewProdutos.BackColor = Color.FromArgb(255, 192, 192);
            buttonviewProdutos.Cursor = Cursors.IBeam;
            buttonviewProdutos.ForeColor = Color.FromArgb(64, 0, 0);
            buttonviewProdutos.Image = (Image)resources.GetObject("buttonviewProdutos.Image");
            buttonviewProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonviewProdutos.Location = new Point(12, 16);
            buttonviewProdutos.Name = "buttonviewProdutos";
            buttonviewProdutos.Size = new Size(159, 41);
            buttonviewProdutos.TabIndex = 3;
            buttonviewProdutos.Text = "Produtos";
            buttonviewProdutos.UseVisualStyleBackColor = false;
            buttonviewProdutos.Click += buttonviewProdutos_Click;
            // 
            // buttonViewFornecedores
            // 
            buttonViewFornecedores.BackColor = Color.FromArgb(192, 192, 255);
            buttonViewFornecedores.ForeColor = Color.FromArgb(0, 0, 64);
            buttonViewFornecedores.Image = Properties.Resources.fornecedor;
            buttonViewFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewFornecedores.Location = new Point(342, 16);
            buttonViewFornecedores.Name = "buttonViewFornecedores";
            buttonViewFornecedores.Size = new Size(159, 41);
            buttonViewFornecedores.TabIndex = 3;
            buttonViewFornecedores.Text = "Fornecedores";
            buttonViewFornecedores.UseVisualStyleBackColor = false;
            buttonViewFornecedores.Click += buttonViewFornecedores_Click;
            // 
            // butonViewClientes
            // 
            butonViewClientes.BackColor = Color.FromArgb(192, 255, 255);
            butonViewClientes.ForeColor = Color.FromArgb(0, 0, 64);
            butonViewClientes.Image = Properties.Resources.cliente;
            butonViewClientes.ImageAlign = ContentAlignment.MiddleLeft;
            butonViewClientes.Location = new Point(177, 16);
            butonViewClientes.Name = "butonViewClientes";
            butonViewClientes.Size = new Size(159, 41);
            butonViewClientes.TabIndex = 3;
            butonViewClientes.Text = "Clientes";
            butonViewClientes.UseVisualStyleBackColor = false;
            butonViewClientes.Click += butonViewClientes_Click;
            // 
            // buttonViewCompras
            // 
            buttonViewCompras.BackColor = Color.FromArgb(192, 255, 192);
            buttonViewCompras.ForeColor = Color.FromArgb(0, 64, 0);
            buttonViewCompras.Image = Properties.Resources.compra1;
            buttonViewCompras.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewCompras.Location = new Point(507, 16);
            buttonViewCompras.Name = "buttonViewCompras";
            buttonViewCompras.Size = new Size(159, 41);
            buttonViewCompras.TabIndex = 3;
            buttonViewCompras.Text = "Compras";
            buttonViewCompras.UseVisualStyleBackColor = false;
            buttonViewCompras.Click += buttonViewCompras_Click;
            // 
            // buttonViewVendas
            // 
            buttonViewVendas.BackColor = Color.FromArgb(255, 255, 192);
            buttonViewVendas.ForeColor = Color.FromArgb(64, 64, 0);
            buttonViewVendas.Image = Properties.Resources.venda;
            buttonViewVendas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewVendas.Location = new Point(672, 16);
            buttonViewVendas.Name = "buttonViewVendas";
            buttonViewVendas.Size = new Size(159, 41);
            buttonViewVendas.TabIndex = 3;
            buttonViewVendas.Text = "Vendas";
            buttonViewVendas.UseVisualStyleBackColor = false;
            buttonViewVendas.Click += buttonViewVendas_Click;
            // 
            // removerCliente_click
            // 
            removerCliente_click.Location = new Point(0, 0);
            removerCliente_click.Name = "removerCliente_click";
            removerCliente_click.Size = new Size(75, 23);
            removerCliente_click.TabIndex = 10;
            // 
            // adicionarCliente_click
            // 
            adicionarCliente_click.BackColor = Color.FromArgb(192, 255, 255);
            adicionarCliente_click.ForeColor = Color.FromArgb(0, 64, 64);
            adicionarCliente_click.Location = new Point(177, 63);
            adicionarCliente_click.Name = "adicionarCliente_click";
            adicionarCliente_click.Size = new Size(159, 23);
            adicionarCliente_click.TabIndex = 5;
            adicionarCliente_click.Text = "Adicionar Cliente";
            adicionarCliente_click.UseVisualStyleBackColor = false;
            adicionarCliente_click.Click += adicionarCliente_click_Click;
            // 
            // removerFornecedor_click
            // 
            removerFornecedor_click.BackColor = Color.FromArgb(192, 192, 255);
            removerFornecedor_click.ForeColor = Color.FromArgb(0, 0, 64);
            removerFornecedor_click.Location = new Point(342, 92);
            removerFornecedor_click.Name = "removerFornecedor_click";
            removerFornecedor_click.Size = new Size(159, 23);
            removerFornecedor_click.TabIndex = 5;
            removerFornecedor_click.Text = "Remover Fornecedor";
            removerFornecedor_click.UseVisualStyleBackColor = false;
            removerFornecedor_click.Click += removerFornecedor_click_Click;
            // 
            // adicionarFornecedor_click
            // 
            adicionarFornecedor_click.BackColor = Color.FromArgb(192, 192, 255);
            adicionarFornecedor_click.ForeColor = Color.FromArgb(0, 0, 64);
            adicionarFornecedor_click.Location = new Point(342, 63);
            adicionarFornecedor_click.Name = "adicionarFornecedor_click";
            adicionarFornecedor_click.Size = new Size(159, 23);
            adicionarFornecedor_click.TabIndex = 5;
            adicionarFornecedor_click.Text = "Adicionar Fornecedor";
            adicionarFornecedor_click.UseVisualStyleBackColor = false;
            adicionarFornecedor_click.Click += adicionarFornecedor_click_Click;
            // 
            // adicionarCompra_click
            // 
            adicionarCompra_click.Location = new Point(0, 0);
            adicionarCompra_click.Name = "adicionarCompra_click";
            adicionarCompra_click.Size = new Size(75, 23);
            adicionarCompra_click.TabIndex = 9;
            // 
            // removerCompra_click
            // 
            removerCompra_click.Location = new Point(0, 0);
            removerCompra_click.Name = "removerCompra_click";
            removerCompra_click.Size = new Size(75, 23);
            removerCompra_click.TabIndex = 6;
            // 
            // removerVenda_click
            // 
            removerVenda_click.Location = new Point(0, 0);
            removerVenda_click.Name = "removerVenda_click";
            removerVenda_click.Size = new Size(75, 23);
            removerVenda_click.TabIndex = 8;
            // 
            // adicionarVenda_click
            // 
            adicionarVenda_click.Location = new Point(0, 0);
            adicionarVenda_click.Name = "adicionarVenda_click";
            adicionarVenda_click.Size = new Size(75, 23);
            adicionarVenda_click.TabIndex = 7;
            // 
            // buttonRemoverCliente
            // 
            buttonRemoverCliente.BackColor = Color.FromArgb(192, 255, 255);
            buttonRemoverCliente.ForeColor = Color.FromArgb(0, 64, 64);
            buttonRemoverCliente.Location = new Point(177, 92);
            buttonRemoverCliente.Name = "buttonRemoverCliente";
            buttonRemoverCliente.Size = new Size(159, 23);
            buttonRemoverCliente.TabIndex = 5;
            buttonRemoverCliente.Text = "Remover Cliente";
            buttonRemoverCliente.UseVisualStyleBackColor = false;
            buttonRemoverCliente.Click += buttonRemoverCliente_Click;
            // 
            // AdicionarCompra
            // 
            AdicionarCompra.BackColor = Color.FromArgb(192, 255, 192);
            AdicionarCompra.ForeColor = Color.FromArgb(0, 64, 0);
            AdicionarCompra.Location = new Point(507, 63);
            AdicionarCompra.Name = "AdicionarCompra";
            AdicionarCompra.Size = new Size(159, 23);
            AdicionarCompra.TabIndex = 5;
            AdicionarCompra.Text = "Adicionar Compra";
            AdicionarCompra.UseVisualStyleBackColor = false;
            AdicionarCompra.Click += AdicionarCompra_Click;
            // 
            // RemoverCompra
            // 
            RemoverCompra.BackColor = Color.FromArgb(192, 255, 192);
            RemoverCompra.ForeColor = Color.FromArgb(0, 64, 0);
            RemoverCompra.Location = new Point(507, 92);
            RemoverCompra.Name = "RemoverCompra";
            RemoverCompra.Size = new Size(159, 23);
            RemoverCompra.TabIndex = 5;
            RemoverCompra.Text = "Remover Compra";
            RemoverCompra.UseVisualStyleBackColor = false;
            RemoverCompra.Click += RemoverCompra_Click;
            // 
            // RemoverVenda
            // 
            RemoverVenda.BackColor = Color.FromArgb(255, 255, 192);
            RemoverVenda.ForeColor = Color.FromArgb(64, 64, 0);
            RemoverVenda.Location = new Point(672, 92);
            RemoverVenda.Name = "RemoverVenda";
            RemoverVenda.Size = new Size(159, 23);
            RemoverVenda.TabIndex = 5;
            RemoverVenda.Text = "Remover Fornecedor";
            RemoverVenda.UseVisualStyleBackColor = false;
            // 
            // AdicionarVenda
            // 
            AdicionarVenda.BackColor = Color.FromArgb(255, 255, 192);
            AdicionarVenda.ForeColor = Color.FromArgb(64, 64, 0);
            AdicionarVenda.Location = new Point(672, 63);
            AdicionarVenda.Name = "AdicionarVenda";
            AdicionarVenda.Size = new Size(159, 23);
            AdicionarVenda.TabIndex = 5;
            AdicionarVenda.Text = "Adicionar Fornecedor";
            AdicionarVenda.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(842, 641);
            Controls.Add(AdicionarVenda);
            Controls.Add(AdicionarCompra);
            Controls.Add(adicionarFornecedor_click);
            Controls.Add(removerCompra_click);
            Controls.Add(adicionarVenda_click);
            Controls.Add(removerVenda_click);
            Controls.Add(adicionarCompra_click);
            Controls.Add(RemoverVenda);
            Controls.Add(RemoverCompra);
            Controls.Add(removerFornecedor_click);
            Controls.Add(buttonRemoverCliente);
            Controls.Add(adicionarCliente_click);
            Controls.Add(removerCliente_click);
            Controls.Add(butonViewClientes);
            Controls.Add(buttonViewVendas);
            Controls.Add(buttonViewCompras);
            Controls.Add(buttonViewFornecedores);
            Controls.Add(buttonviewProdutos);
            Controls.Add(dataGridView_lista);
            Controls.Add(Remover);
            Controls.Add(Adicionar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_lista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Adicionar;
        private Button Remover;
        private DataGridView dataGridView_lista;
        private Button buttonviewProdutos;
        private Button buttonViewFornecedores;
        private Button butonViewClientes;
        private Button buttonViewCompras;
        private Button buttonViewVendas;
        private Button removerCliente_click;
        private Button adicionarCliente_click;
        private Button removerFornecedor_click;
        private Button adicionarFornecedor_click;
        private Button adicionarCompra_click;
        private Button removerCompra_click;
        private Button removerVenda_click;
        private Button adicionarVenda_click;
        private Button buttonRemoverCliente;
        private Button AdicionarCompra;
        private Button RemoverCompra;
        private Button RemoverVenda;
        private Button AdicionarVenda;
    }
}
