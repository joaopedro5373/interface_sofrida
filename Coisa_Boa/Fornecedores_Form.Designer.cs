﻿namespace Coisa_Boa
{
    partial class Fornecedores_Form
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
            OK_click = new Button();
            Cancel_click = new Button();
            textBoxEndereco = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            textBoxTelefone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // OK_click
            // 
            OK_click.Location = new Point(339, 190);
            OK_click.Name = "OK_click";
            OK_click.Size = new Size(75, 23);
            OK_click.TabIndex = 0;
            OK_click.Text = "OK";
            OK_click.UseVisualStyleBackColor = true;
            OK_click.Click += OK_click_Click;
            // 
            // Cancel_click
            // 
            Cancel_click.Location = new Point(424, 190);
            Cancel_click.Name = "Cancel_click";
            Cancel_click.Size = new Size(75, 23);
            Cancel_click.TabIndex = 1;
            Cancel_click.Text = "Cancel";
            Cancel_click.UseVisualStyleBackColor = true;
            Cancel_click.Click += Cancel_click_Click;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.Location = new Point(339, 64);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(151, 23);
            textBoxEndereco.TabIndex = 2;
            textBoxEndereco.TextChanged += textBox2_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(75, 191);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(151, 23);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(75, 64);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(151, 23);
            textBoxNome.TabIndex = 2;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(75, 127);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(151, 23);
            textBoxTelefone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 173);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereço E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 109);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 46);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 3;
            label5.Text = "Endereço Físico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 9);
            label6.Name = "label6";
            label6.Size = new Size(137, 15);
            label6.TabIndex = 3;
            label6.Text = "Cadastrando Fornecedor";
            // 
            // Fornecedores_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 257);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxEndereco);
            Controls.Add(Cancel_click);
            Controls.Add(OK_click);
            Name = "Fornecedores_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedores_Form";
            Load += Fornecedores_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OK_click;
        private Button Cancel_click;
        private TextBox textBoxEndereco;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private TextBox textBoxTelefone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}