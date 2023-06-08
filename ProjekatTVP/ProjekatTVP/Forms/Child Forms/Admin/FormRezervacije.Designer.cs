namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    partial class FormRezervacije
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
            this.dateRezervacijeDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dateRezervacijeDatumDo = new System.Windows.Forms.DateTimePicker();
            this.txtRezervacijeTip = new System.Windows.Forms.TextBox();
            this.txtRezervacijeIDGosta = new System.Windows.Forms.TextBox();
            this.txtRezervacijeIDSobe = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnUnesiRez = new System.Windows.Forms.Button();
            this.btnBrisiRez = new System.Windows.Forms.Button();
            this.btnMenjajRez = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxRezervacije = new System.Windows.Forms.ListBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateRezervacijeDatumOd
            // 
            this.dateRezervacijeDatumOd.Location = new System.Drawing.Point(392, 275);
            this.dateRezervacijeDatumOd.Name = "dateRezervacijeDatumOd";
            this.dateRezervacijeDatumOd.Size = new System.Drawing.Size(102, 20);
            this.dateRezervacijeDatumOd.TabIndex = 95;
            // 
            // dateRezervacijeDatumDo
            // 
            this.dateRezervacijeDatumDo.Location = new System.Drawing.Point(392, 301);
            this.dateRezervacijeDatumDo.Name = "dateRezervacijeDatumDo";
            this.dateRezervacijeDatumDo.Size = new System.Drawing.Size(100, 20);
            this.dateRezervacijeDatumDo.TabIndex = 94;
            // 
            // txtRezervacijeTip
            // 
            this.txtRezervacijeTip.Location = new System.Drawing.Point(392, 327);
            this.txtRezervacijeTip.Name = "txtRezervacijeTip";
            this.txtRezervacijeTip.Size = new System.Drawing.Size(100, 20);
            this.txtRezervacijeTip.TabIndex = 93;
            // 
            // txtRezervacijeIDGosta
            // 
            this.txtRezervacijeIDGosta.Location = new System.Drawing.Point(392, 249);
            this.txtRezervacijeIDGosta.Name = "txtRezervacijeIDGosta";
            this.txtRezervacijeIDGosta.Size = new System.Drawing.Size(100, 20);
            this.txtRezervacijeIDGosta.TabIndex = 92;
            // 
            // txtRezervacijeIDSobe
            // 
            this.txtRezervacijeIDSobe.Location = new System.Drawing.Point(392, 223);
            this.txtRezervacijeIDSobe.Name = "txtRezervacijeIDSobe";
            this.txtRezervacijeIDSobe.Size = new System.Drawing.Size(100, 20);
            this.txtRezervacijeIDSobe.TabIndex = 91;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 90;
            this.label16.Text = "Tip rezervacije";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(310, 305);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 89;
            this.label18.Text = "Datum do";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(310, 279);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "Datum od";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(310, 252);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 87;
            this.label20.Text = "ID Gosta";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(310, 226);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 86;
            this.label22.Text = "ID Sobe";
            // 
            // btnUnesiRez
            // 
            this.btnUnesiRez.Location = new System.Drawing.Point(310, 382);
            this.btnUnesiRez.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUnesiRez.Name = "btnUnesiRez";
            this.btnUnesiRez.Size = new System.Drawing.Size(182, 23);
            this.btnUnesiRez.TabIndex = 85;
            this.btnUnesiRez.Text = "Unesi";
            this.btnUnesiRez.UseVisualStyleBackColor = true;
            // 
            // btnBrisiRez
            // 
            this.btnBrisiRez.Location = new System.Drawing.Point(400, 351);
            this.btnBrisiRez.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrisiRez.Name = "btnBrisiRez";
            this.btnBrisiRez.Size = new System.Drawing.Size(94, 23);
            this.btnBrisiRez.TabIndex = 84;
            this.btnBrisiRez.Text = "Brisi";
            this.btnBrisiRez.UseVisualStyleBackColor = true;
            // 
            // btnMenjajRez
            // 
            this.btnMenjajRez.Location = new System.Drawing.Point(310, 351);
            this.btnMenjajRez.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMenjajRez.Name = "btnMenjajRez";
            this.btnMenjajRez.Size = new System.Drawing.Size(84, 23);
            this.btnMenjajRez.TabIndex = 83;
            this.btnMenjajRez.Text = "Menjaj";
            this.btnMenjajRez.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Rezervacije";
            // 
            // lbxRezervacije
            // 
            this.lbxRezervacije.FormattingEnabled = true;
            this.lbxRezervacije.HorizontalScrollbar = true;
            this.lbxRezervacije.Location = new System.Drawing.Point(310, 62);
            this.lbxRezervacije.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxRezervacije.Name = "lbxRezervacije";
            this.lbxRezervacije.Size = new System.Drawing.Size(182, 160);
            this.lbxRezervacije.TabIndex = 81;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(650, 86);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Linija za menjanje(ID)";
            // 
            // FormRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateRezervacijeDatumOd);
            this.Controls.Add(this.dateRezervacijeDatumDo);
            this.Controls.Add(this.txtRezervacijeTip);
            this.Controls.Add(this.txtRezervacijeIDGosta);
            this.Controls.Add(this.txtRezervacijeIDSobe);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnUnesiRez);
            this.Controls.Add(this.btnBrisiRez);
            this.Controls.Add(this.btnMenjajRez);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxRezervacije);
            this.Name = "FormRezervacije";
            this.Text = "FormRezervacije";
            this.Load += new System.EventHandler(this.FormRezervacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateRezervacijeDatumOd;
        private System.Windows.Forms.DateTimePicker dateRezervacijeDatumDo;
        private System.Windows.Forms.TextBox txtRezervacijeTip;
        private System.Windows.Forms.TextBox txtRezervacijeIDGosta;
        private System.Windows.Forms.TextBox txtRezervacijeIDSobe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnUnesiRez;
        private System.Windows.Forms.Button btnBrisiRez;
        private System.Windows.Forms.Button btnMenjajRez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxRezervacije;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
    }
}