
namespace NextSoftAppWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbListagem = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnGET = new System.Windows.Forms.Button();
            this.btnGetId = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnPutId = new System.Windows.Forms.Button();
            this.btnDeleteId = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtURL.Location = new System.Drawing.Point(112, 5);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(671, 32);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "https://localhost:44395/api";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL API:";
            // 
            // cbListagem
            // 
            this.cbListagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListagem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cbListagem.FormattingEnabled = true;
            this.cbListagem.Location = new System.Drawing.Point(112, 43);
            this.cbListagem.Name = "cbListagem";
            this.cbListagem.Size = new System.Drawing.Size(271, 28);
            this.cbListagem.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(34, 75);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(749, 313);
            this.dataGridView.TabIndex = 3;
            // 
            // btnGET
            // 
            this.btnGET.BackColor = System.Drawing.Color.LightBlue;
            this.btnGET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGET.Location = new System.Drawing.Point(34, 394);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(119, 44);
            this.btnGET.TabIndex = 4;
            this.btnGET.Text = "GET";
            this.btnGET.UseVisualStyleBackColor = false;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // btnGetId
            // 
            this.btnGetId.BackColor = System.Drawing.Color.LightBlue;
            this.btnGetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetId.Location = new System.Drawing.Point(159, 394);
            this.btnGetId.Name = "btnGetId";
            this.btnGetId.Size = new System.Drawing.Size(119, 44);
            this.btnGetId.TabIndex = 5;
            this.btnGetId.Text = "GET [id]";
            this.btnGetId.UseVisualStyleBackColor = false;
            this.btnGetId.Click += new System.EventHandler(this.btnGetId_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.LightBlue;
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(284, 394);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(249, 44);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPutId
            // 
            this.btnPutId.BackColor = System.Drawing.Color.LightBlue;
            this.btnPutId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPutId.Location = new System.Drawing.Point(539, 394);
            this.btnPutId.Name = "btnPutId";
            this.btnPutId.Size = new System.Drawing.Size(119, 44);
            this.btnPutId.TabIndex = 7;
            this.btnPutId.Text = "PUT [id]";
            this.btnPutId.UseVisualStyleBackColor = false;
            this.btnPutId.Click += new System.EventHandler(this.btnPutId_Click);
            // 
            // btnDeleteId
            // 
            this.btnDeleteId.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteId.Location = new System.Drawing.Point(664, 394);
            this.btnDeleteId.Name = "btnDeleteId";
            this.btnDeleteId.Size = new System.Drawing.Size(119, 44);
            this.btnDeleteId.TabIndex = 8;
            this.btnDeleteId.Text = "DELETE [id]";
            this.btnDeleteId.UseVisualStyleBackColor = false;
            this.btnDeleteId.Click += new System.EventHandler(this.btnDeleteId_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtID.Location = new System.Drawing.Point(633, 45);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 25);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "Digite o ID aqui";
            this.txtID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(597, 48);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(30, 20);
            this.lbId.TabIndex = 15;
            this.lbId.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "End Point:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDeleteId);
            this.Controls.Add(this.btnPutId);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnGetId);
            this.Controls.Add(this.btnGET);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.cbListagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Next Soft - Windows Forms e API";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbListagem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.Button btnGetId;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPutId;
        private System.Windows.Forms.Button btnDeleteId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label2;
    }
}

