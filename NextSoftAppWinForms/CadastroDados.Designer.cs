
namespace NextSoftAppWinForms
{
    partial class CadastroDados
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
            this.txtID = new System.Windows.Forms.NumericUpDown();
            this.txtIdade = new System.Windows.Forms.NumericUpDown();
            this.txtApto = new System.Windows.Forms.NumericUpDown();
            this.txtCondominio = new System.Windows.Forms.NumericUpDown();
            this.txtFamilia = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbApto = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCondominio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamilia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(65, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(103, 20);
            this.txtID.TabIndex = 36;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(65, 228);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(103, 20);
            this.txtIdade.TabIndex = 35;
            // 
            // txtApto
            // 
            this.txtApto.Location = new System.Drawing.Point(65, 180);
            this.txtApto.Name = "txtApto";
            this.txtApto.Size = new System.Drawing.Size(103, 20);
            this.txtApto.TabIndex = 34;
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(287, 224);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(103, 20);
            this.txtCondominio.TabIndex = 33;
            // 
            // txtFamilia
            // 
            this.txtFamilia.Location = new System.Drawing.Point(287, 180);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(103, 20);
            this.txtFamilia.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "idCONDOMINIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "idFAMILIA:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(60, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(106, 29);
            this.lbTitulo.TabIndex = 29;
            this.lbTitulo.Text = "TITULO";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(149, 273);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 32);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(9, 228);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(43, 13);
            this.lbIdade.TabIndex = 27;
            this.lbIdade.Text = "IDADE:";
            // 
            // lbApto
            // 
            this.lbApto.AutoSize = true;
            this.lbApto.Location = new System.Drawing.Point(12, 182);
            this.lbApto.Name = "lbApto";
            this.lbApto.Size = new System.Drawing.Size(39, 13);
            this.lbApto.TabIndex = 26;
            this.lbApto.Text = "APTO:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(65, 134);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(323, 20);
            this.txtBairro.TabIndex = 25;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(6, 134);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(51, 13);
            this.lbBairro.TabIndex = 24;
            this.lbBairro.Text = "BAIRRO:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(9, 89);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(42, 13);
            this.lbNome.TabIndex = 23;
            this.lbNome.Text = "NOME:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(9, 50);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 22;
            this.lbID.Text = "ID:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 89);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(323, 20);
            this.txtNome.TabIndex = 21;
            // 
            // CadastroDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 318);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtApto);
            this.Controls.Add(this.txtCondominio);
            this.Controls.Add(this.txtFamilia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbIdade);
            this.Controls.Add(this.lbApto);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextSoft - Cadastro e alteração de dados";
            this.Load += new System.EventHandler(this.CadastroDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCondominio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamilia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtID;
        private System.Windows.Forms.NumericUpDown txtIdade;
        private System.Windows.Forms.NumericUpDown txtApto;
        private System.Windows.Forms.NumericUpDown txtCondominio;
        private System.Windows.Forms.NumericUpDown txtFamilia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbApto;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtNome;
    }
}