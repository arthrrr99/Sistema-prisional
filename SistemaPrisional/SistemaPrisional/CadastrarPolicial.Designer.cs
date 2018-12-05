namespace SistemaPrisional
{
    partial class CadastrarPolicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPolicial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_identificacao = new System.Windows.Forms.MaskedTextBox();
            this.txt_autorizacao = new System.Windows.Forms.MaskedTextBox();
            this.txt_confirmarsenha = new System.Windows.Forms.MaskedTextBox();
            this.txt_senha = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(43, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO DE IDENTIFICAÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATA DE NASCIMENTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(43, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "SENHA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(43, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "NUMERO DE AUTORIZAÇÃO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(254, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "CONFIRME A SENHA:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(95, 29);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(476, 20);
            this.txt_nome.TabIndex = 8;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(190, 215);
            this.txt_nascimento.Mask = "00/00/0000";
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(95, 20);
            this.txt_nascimento.TabIndex = 9;
            // 
            // txt_identificacao
            // 
            this.txt_identificacao.Location = new System.Drawing.Point(221, 97);
            this.txt_identificacao.Mask = "000.000.00";
            this.txt_identificacao.Name = "txt_identificacao";
            this.txt_identificacao.Size = new System.Drawing.Size(100, 20);
            this.txt_identificacao.TabIndex = 10;
            // 
            // txt_autorizacao
            // 
            this.txt_autorizacao.Location = new System.Drawing.Point(217, 277);
            this.txt_autorizacao.Mask = "000.000-00";
            this.txt_autorizacao.Name = "txt_autorizacao";
            this.txt_autorizacao.Size = new System.Drawing.Size(100, 20);
            this.txt_autorizacao.TabIndex = 11;
            // 
            // txt_confirmarsenha
            // 
            this.txt_confirmarsenha.BackColor = System.Drawing.SystemColors.Info;
            this.txt_confirmarsenha.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_confirmarsenha.Location = new System.Drawing.Point(384, 329);
            this.txt_confirmarsenha.Mask = "000000000000";
            this.txt_confirmarsenha.Name = "txt_confirmarsenha";
            this.txt_confirmarsenha.Size = new System.Drawing.Size(126, 20);
            this.txt_confirmarsenha.TabIndex = 13;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(99, 331);
            this.txt_senha.Mask = "000000000000";
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(141, 20);
            this.txt_senha.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(504, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold);
            this.txt_usuario.Location = new System.Drawing.Point(43, 157);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(121, 16);
            this.txt_usuario.TabIndex = 16;
            this.txt_usuario.Text = "NOME DE USUARIO:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CadastrarPolicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 419);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_confirmarsenha);
            this.Controls.Add(this.txt_autorizacao);
            this.Controls.Add(this.txt_identificacao);
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarPolicial";
            this.Text = "CADASTRO POLICIAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox txt_nascimento;
        private System.Windows.Forms.MaskedTextBox txt_identificacao;
        private System.Windows.Forms.MaskedTextBox txt_autorizacao;
        private System.Windows.Forms.MaskedTextBox txt_confirmarsenha;
        private System.Windows.Forms.MaskedTextBox txt_senha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.TextBox textBox1;
    }
}