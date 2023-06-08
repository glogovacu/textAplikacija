namespace ProjekatTVP
{
    partial class FormRecepcionar
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
            this.lbxRezervacije = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnMenjajRezervaciju = new System.Windows.Forms.Button();
            this.btnUnesiRezervaciju = new System.Windows.Forms.Button();
            this.btnBrisiRezervaciju = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRezervacijeIDSobe = new System.Windows.Forms.TextBox();
            this.txtRezervacijeIDGosta = new System.Windows.Forms.TextBox();
            this.txtRezervacijeTip = new System.Windows.Forms.TextBox();
            this.dateRezervacijeDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dateRezervacijeDatumDo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbxRezervacije
            // 
            this.lbxRezervacije.FormattingEnabled = true;
            this.lbxRezervacije.HorizontalScrollbar = true;
            this.lbxRezervacije.Location = new System.Drawing.Point(25, 61);
            this.lbxRezervacije.Name = "lbxRezervacije";
            this.lbxRezervacije.ScrollAlwaysVisible = true;
            this.lbxRezervacije.Size = new System.Drawing.Size(272, 147);
            this.lbxRezervacije.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // btnMenjajRezervaciju
            // 
            this.btnMenjajRezervaciju.Location = new System.Drawing.Point(12, 351);
            this.btnMenjajRezervaciju.Name = "btnMenjajRezervaciju";
            this.btnMenjajRezervaciju.Size = new System.Drawing.Size(139, 23);
            this.btnMenjajRezervaciju.TabIndex = 3;
            this.btnMenjajRezervaciju.Text = "Menjaj";
            this.btnMenjajRezervaciju.UseVisualStyleBackColor = true;
            this.btnMenjajRezervaciju.Click += new System.EventHandler(this.btnMenjajRezervaciju_Click);
            // 
            // btnUnesiRezervaciju
            // 
            this.btnUnesiRezervaciju.Location = new System.Drawing.Point(12, 380);
            this.btnUnesiRezervaciju.Name = "btnUnesiRezervaciju";
            this.btnUnesiRezervaciju.Size = new System.Drawing.Size(285, 29);
            this.btnUnesiRezervaciju.TabIndex = 5;
            this.btnUnesiRezervaciju.Text = "Unesi";
            this.btnUnesiRezervaciju.UseVisualStyleBackColor = true;
            this.btnUnesiRezervaciju.Click += new System.EventHandler(this.btnUnesiRezervaciju_Click);
            // 
            // btnBrisiRezervaciju
            // 
            this.btnBrisiRezervaciju.Location = new System.Drawing.Point(157, 351);
            this.btnBrisiRezervaciju.Name = "btnBrisiRezervaciju";
            this.btnBrisiRezervaciju.Size = new System.Drawing.Size(140, 23);
            this.btnBrisiRezervaciju.TabIndex = 6;
            this.btnBrisiRezervaciju.Text = "Brisi";
            this.btnBrisiRezervaciju.UseVisualStyleBackColor = true;
            this.btnBrisiRezervaciju.Click += new System.EventHandler(this.btnBrisiRezervaciju_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Sobe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Gosta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Datum od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datum do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tip rezervacije";
            // 
            // txtRezervacijeIDSobe
            // 
            this.txtRezervacijeIDSobe.Location = new System.Drawing.Point(97, 220);
            this.txtRezervacijeIDSobe.Name = "txtRezervacijeIDSobe";
            this.txtRezervacijeIDSobe.Size = new System.Drawing.Size(200, 20);
            this.txtRezervacijeIDSobe.TabIndex = 14;
            // 
            // txtRezervacijeIDGosta
            // 
            this.txtRezervacijeIDGosta.Location = new System.Drawing.Point(97, 246);
            this.txtRezervacijeIDGosta.Name = "txtRezervacijeIDGosta";
            this.txtRezervacijeIDGosta.Size = new System.Drawing.Size(200, 20);
            this.txtRezervacijeIDGosta.TabIndex = 16;
            // 
            // txtRezervacijeTip
            // 
            this.txtRezervacijeTip.Location = new System.Drawing.Point(97, 326);
            this.txtRezervacijeTip.Name = "txtRezervacijeTip";
            this.txtRezervacijeTip.Size = new System.Drawing.Size(200, 20);
            this.txtRezervacijeTip.TabIndex = 20;
            // 
            // dateRezervacijeDatumOd
            // 
            this.dateRezervacijeDatumOd.Location = new System.Drawing.Point(97, 274);
            this.dateRezervacijeDatumOd.Name = "dateRezervacijeDatumOd";
            this.dateRezervacijeDatumOd.Size = new System.Drawing.Size(200, 20);
            this.dateRezervacijeDatumOd.TabIndex = 21;
            // 
            // dateRezervacijeDatumDo
            // 
            this.dateRezervacijeDatumDo.Location = new System.Drawing.Point(97, 300);
            this.dateRezervacijeDatumDo.Name = "dateRezervacijeDatumDo";
            this.dateRezervacijeDatumDo.Size = new System.Drawing.Size(200, 20);
            this.dateRezervacijeDatumDo.TabIndex = 22;
            // 
            // FormRecepcionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 446);
            this.Controls.Add(this.dateRezervacijeDatumDo);
            this.Controls.Add(this.dateRezervacijeDatumOd);
            this.Controls.Add(this.txtRezervacijeTip);
            this.Controls.Add(this.txtRezervacijeIDGosta);
            this.Controls.Add(this.txtRezervacijeIDSobe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrisiRezervaciju);
            this.Controls.Add(this.btnUnesiRezervaciju);
            this.Controls.Add(this.btnMenjajRezervaciju);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxRezervacije);
            this.Name = "FormRecepcionar";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Recepcionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnMenjajRezervaciju;
        private System.Windows.Forms.Button btnUnesiRezervaciju;
        private System.Windows.Forms.Button btnBrisiRezervaciju;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRezervacijeIDSobe;
        private System.Windows.Forms.TextBox txtRezervacijeIDGosta;
        private System.Windows.Forms.TextBox txtRezervacijeTip;
        private System.Windows.Forms.DateTimePicker dateRezervacijeDatumOd;
        private System.Windows.Forms.DateTimePicker dateRezervacijeDatumDo;
    }
}