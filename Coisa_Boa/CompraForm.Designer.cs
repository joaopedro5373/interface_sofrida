namespace Coisa_Boa
{
    partial class CompraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownCOMPRA = new NumericUpDown();
            numericUpDownFornecedor = new NumericUpDown();
            numericUpDownProduto = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            OK_button = new Button();
            Cancel_button = new Button();
            numericUpDownDesconto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCOMPRA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFornecedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownCOMPRA
            // 
            numericUpDownCOMPRA.Location = new Point(172, 165);
            numericUpDownCOMPRA.Name = "numericUpDownCOMPRA";
            numericUpDownCOMPRA.Size = new Size(120, 23);
            numericUpDownCOMPRA.TabIndex = 0;
            numericUpDownCOMPRA.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownFornecedor
            // 
            numericUpDownFornecedor.Location = new Point(172, 120);
            numericUpDownFornecedor.Name = "numericUpDownFornecedor";
            numericUpDownFornecedor.Size = new Size(120, 23);
            numericUpDownFornecedor.TabIndex = 0;
            numericUpDownFornecedor.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownProduto
            // 
            numericUpDownProduto.Location = new Point(172, 78);
            numericUpDownProduto.Name = "numericUpDownProduto";
            numericUpDownProduto.Size = new Size(120, 23);
            numericUpDownProduto.TabIndex = 0;
            numericUpDownProduto.TextAlign = HorizontalAlignment.Right;
            numericUpDownProduto.ValueChanged += numericUpDownProduto_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 80);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "ID Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 122);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "ID Fornecedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 167);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Quantidade ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 211);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 2;
            label4.Text = "Desconto";
            // 
            // OK_button
            // 
            OK_button.Location = new Point(97, 286);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(75, 23);
            OK_button.TabIndex = 3;
            OK_button.Text = "OK";
            OK_button.UseVisualStyleBackColor = true;
            OK_button.Click += OK_button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(206, 286);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(75, 23);
            Cancel_button.TabIndex = 3;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += Cancel_button_Click;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.DecimalPlaces = 2;
            numericUpDownDesconto.Location = new Point(172, 211);
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(120, 23);
            numericUpDownDesconto.TabIndex = 0;
            numericUpDownDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // CompraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 353);
            Controls.Add(Cancel_button);
            Controls.Add(OK_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownProduto);
            Controls.Add(numericUpDownFornecedor);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownCOMPRA);
            Name = "CompraForm";
            Text = "CompraForm";
            Load += CompraForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCOMPRA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFornecedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownCOMPRA;
        private NumericUpDown numericUpDownFornecedor;
        private NumericUpDown numericUpDownProduto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button OK_button;
        private Button Cancel_button;
        private NumericUpDown numericUpDownDesconto;
    }
}