namespace ProjekatTVP
{
    partial class FormLogin
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
            this.curvedPanel1 = new ProjekatTVP.UI_Elements.CurvedPanel();
            this.txtPassword = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtKorisnickoIme = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.btnLogin = new ProjekatTVP.UI_Elements.CurvedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.curvedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // curvedPanel1
            // 
            this.curvedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.curvedPanel1.Controls.Add(this.txtPassword);
            this.curvedPanel1.Controls.Add(this.txtKorisnickoIme);
            this.curvedPanel1.Controls.Add(this.btnLogin);
            this.curvedPanel1.Controls.Add(this.label2);
            this.curvedPanel1.Controls.Add(this.label1);
            this.curvedPanel1.Controls.Add(this.label4);
            this.curvedPanel1.Location = new System.Drawing.Point(363, 101);
            this.curvedPanel1.Name = "curvedPanel1";
            this.curvedPanel1.Size = new System.Drawing.Size(472, 523);
            this.curvedPanel1.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.IsFocused = false;
            this.txtPassword.Location = new System.Drawing.Point(40, 314);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(398, 52);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.BackColor = System.Drawing.SystemColors.Window;
            this.txtKorisnickoIme.BorderColor = System.Drawing.Color.Black;
            this.txtKorisnickoIme.BorderFocusColor = System.Drawing.Color.Gray;
            this.txtKorisnickoIme.BorderRadius = 10;
            this.txtKorisnickoIme.BorderSize = 1;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKorisnickoIme.ForeColor = System.Drawing.Color.DimGray;
            this.txtKorisnickoIme.IsFocused = false;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(40, 217);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorisnickoIme.Multiline = false;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtKorisnickoIme.PasswordChar = false;
            this.txtKorisnickoIme.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtKorisnickoIme.PlaceholderText = "Username";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(398, 52);
            this.txtKorisnickoIme.TabIndex = 12;
            this.txtKorisnickoIme.Texts = "";
            this.txtKorisnickoIme.UnderlinedStyle = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.BorderOffset = 1;
            this.btnLogin.CurveSize = 10;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(40, 395);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(398, 62);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter your Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter your Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 81);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign In";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjekatTVP.Properties.Resources.Saly_2;
            this.pictureBox3.Location = new System.Drawing.Point(760, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(403, 444);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(118)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::ProjekatTVP.Properties.Resources.Saly_3;
            this.pictureBox2.Location = new System.Drawing.Point(86, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 279);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(118)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 715);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 715);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.curvedPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.curvedPanel1.ResumeLayout(false);
            this.curvedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private UI_Elements.CurvedPanel curvedPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UI_Elements.CurvedButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private UI_Elements.CustomTextBox txtKorisnickoIme;
        private UI_Elements.CustomTextBox txtPassword;
    }
}

