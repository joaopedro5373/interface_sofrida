namespace Coisa_Boa
{
    partial class adicionarcliente_Form
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
            textBoxNome = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label11 = new Label();
            buttonOk_click = new Button();
            buttonCancel_click = new Button();
            textBoxEndereco = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(95, 71);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(171, 23);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(95, 113);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(171, 23);
            textBoxTelefone.TabIndex = 0;
            textBoxTelefone.TextChanged += textBox1_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(95, 155);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(171, 23);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 79);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 158);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 1;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 121);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 1;
            label3.Text = "Telefone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(112, 28);
            label11.Name = "label11";
            label11.Size = new Size(135, 15);
            label11.TabIndex = 4;
            label11.Text = "Informações de Contato";
            // 
            // buttonOk_click
            // 
            buttonOk_click.Location = new Point(95, 255);
            buttonOk_click.Name = "buttonOk_click";
            buttonOk_click.Size = new Size(75, 23);
            buttonOk_click.TabIndex = 5;
            buttonOk_click.Text = "Ok";
            buttonOk_click.UseVisualStyleBackColor = true;
            buttonOk_click.Click += buttonOk_click_Click;
            // 
            // buttonCancel_click
            // 
            buttonCancel_click.Location = new Point(176, 255);
            buttonCancel_click.Name = "buttonCancel_click";
            buttonCancel_click.Size = new Size(75, 23);
            buttonCancel_click.TabIndex = 5;
            buttonCancel_click.Text = "Cancel";
            buttonCancel_click.UseVisualStyleBackColor = true;
            buttonCancel_click.Click += buttonCancel_click_Click;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(95, 194);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(171, 23);
            textBoxEndereco.TabIndex = 0;
            textBoxEndereco.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 202);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // adicionarcliente_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 350);
            Controls.Add(label4);
            Controls.Add(buttonCancel_click);
            Controls.Add(buttonOk_click);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEndereco);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxNome);
            Name = "adicionarcliente_Form";
            Text = "adicionarcliente_Form";
            Load += adicionarcliente_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxTelefone;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label11;
        private Button buttonOk_click;
        private Button buttonCancel_click;
        private TextBox textBoxEndereco;
        private Label label4;
    }
}