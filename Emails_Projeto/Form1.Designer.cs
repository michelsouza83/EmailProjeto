namespace Emails_Projeto
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtAtualmente = new System.Windows.Forms.Label();
            this.btnObter = new System.Windows.Forms.Button();
            this.btnObterTodosemails = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(12, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(38, 13);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Nome:";
            // 
            // txtSenha
            // 
            this.txtSenha.AutoSize = true;
            this.txtSenha.Location = new System.Drawing.Point(319, 28);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(41, 13);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.Text = "Senha:";
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txtAtualmente
            // 
            this.txtAtualmente.AutoSize = true;
            this.txtAtualmente.Location = new System.Drawing.Point(12, 64);
            this.txtAtualmente.Name = "txtAtualmente";
            this.txtAtualmente.Size = new System.Drawing.Size(110, 13);
            this.txtAtualmente.TabIndex = 2;
            this.txtAtualmente.Text = "Atualmente você tem:";
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(15, 80);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(75, 23);
            this.btnObter.TabIndex = 3;
            this.btnObter.Text = "Obter";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // btnObterTodosemails
            // 
            this.btnObterTodosemails.Location = new System.Drawing.Point(168, 80);
            this.btnObterTodosemails.Name = "btnObterTodosemails";
            this.btnObterTodosemails.Size = new System.Drawing.Size(110, 23);
            this.btnObterTodosemails.TabIndex = 3;
            this.btnObterTodosemails.Text = "Obter todos emails";
            this.btnObterTodosemails.UseVisualStyleBackColor = true;
            this.btnObterTodosemails.Click += new System.EventHandler(this.btnObterTodosemails_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 144);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(631, 199);
            this.listBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seus e-mails";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnObterTodosemails);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.txtAtualmente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtAtualmente;
        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.Button btnObterTodosemails;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
    }
}

