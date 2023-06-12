namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    partial class FormGost
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGostIme = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtGostPrezime = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtGostTelefon = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtID = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.dateGostDatumRodjenja = new CustomControls.RJControls.CustomDateTimePicker();
            this.curvedButton1 = new ProjekatTVP.UI_Elements.CurvedButton();
            this.curvedButton2 = new ProjekatTVP.UI_Elements.CurvedButton();
            this.curvedButton3 = new ProjekatTVP.UI_Elements.CurvedButton();
            this.lbxGost = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 90;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 88;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(470, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 87;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 86;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "ID (Only for changing and deleting)";
            // 
            // txtGostIme
            // 
            this.txtGostIme.BackColor = System.Drawing.Color.Wheat;
            this.txtGostIme.BorderColor = System.Drawing.Color.Black;
            this.txtGostIme.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtGostIme.BorderRadius = 10;
            this.txtGostIme.BorderSize = 2;
            this.txtGostIme.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGostIme.ForeColor = System.Drawing.Color.Black;
            this.txtGostIme.IsFocused = false;
            this.txtGostIme.Location = new System.Drawing.Point(234, 103);
            this.txtGostIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtGostIme.Multiline = false;
            this.txtGostIme.Name = "txtGostIme";
            this.txtGostIme.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGostIme.PasswordChar = false;
            this.txtGostIme.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtGostIme.PlaceholderText = "John";
            this.txtGostIme.Size = new System.Drawing.Size(233, 37);
            this.txtGostIme.TabIndex = 96;
            this.txtGostIme.Texts = "";
            this.txtGostIme.UnderlinedStyle = false;
            // 
            // txtGostPrezime
            // 
            this.txtGostPrezime.BackColor = System.Drawing.Color.Wheat;
            this.txtGostPrezime.BorderColor = System.Drawing.Color.Black;
            this.txtGostPrezime.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtGostPrezime.BorderRadius = 10;
            this.txtGostPrezime.BorderSize = 2;
            this.txtGostPrezime.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGostPrezime.ForeColor = System.Drawing.Color.DimGray;
            this.txtGostPrezime.IsFocused = false;
            this.txtGostPrezime.Location = new System.Drawing.Point(234, 181);
            this.txtGostPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtGostPrezime.Multiline = false;
            this.txtGostPrezime.Name = "txtGostPrezime";
            this.txtGostPrezime.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGostPrezime.PasswordChar = false;
            this.txtGostPrezime.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtGostPrezime.PlaceholderText = "Smith";
            this.txtGostPrezime.Size = new System.Drawing.Size(233, 37);
            this.txtGostPrezime.TabIndex = 97;
            this.txtGostPrezime.Texts = "";
            this.txtGostPrezime.UnderlinedStyle = false;
            // 
            // txtGostTelefon
            // 
            this.txtGostTelefon.BackColor = System.Drawing.Color.Wheat;
            this.txtGostTelefon.BorderColor = System.Drawing.Color.Black;
            this.txtGostTelefon.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtGostTelefon.BorderRadius = 10;
            this.txtGostTelefon.BorderSize = 2;
            this.txtGostTelefon.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGostTelefon.ForeColor = System.Drawing.Color.DimGray;
            this.txtGostTelefon.IsFocused = false;
            this.txtGostTelefon.Location = new System.Drawing.Point(474, 181);
            this.txtGostTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtGostTelefon.Multiline = false;
            this.txtGostTelefon.Name = "txtGostTelefon";
            this.txtGostTelefon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGostTelefon.PasswordChar = false;
            this.txtGostTelefon.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtGostTelefon.PlaceholderText = "555-333";
            this.txtGostTelefon.Size = new System.Drawing.Size(233, 37);
            this.txtGostTelefon.TabIndex = 98;
            this.txtGostTelefon.Texts = "";
            this.txtGostTelefon.UnderlinedStyle = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Wheat;
            this.txtID.BorderColor = System.Drawing.Color.Black;
            this.txtID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtID.BorderRadius = 8;
            this.txtID.BorderSize = 2;
            this.txtID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Black;
            this.txtID.IsFocused = false;
            this.txtID.Location = new System.Drawing.Point(234, 36);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtID.PlaceholderText = "";
            this.txtID.Size = new System.Drawing.Size(83, 37);
            this.txtID.TabIndex = 100;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = false;
            // 
            // dateGostDatumRodjenja
            // 
            this.dateGostDatumRodjenja.BorderColor = System.Drawing.Color.Black;
            this.dateGostDatumRodjenja.BorderSize = 2;
            this.dateGostDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateGostDatumRodjenja.Location = new System.Drawing.Point(474, 105);
            this.dateGostDatumRodjenja.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateGostDatumRodjenja.Name = "dateGostDatumRodjenja";
            this.dateGostDatumRodjenja.Size = new System.Drawing.Size(233, 35);
            this.dateGostDatumRodjenja.SkinColor = System.Drawing.Color.Wheat;
            this.dateGostDatumRodjenja.TabIndex = 105;
            this.dateGostDatumRodjenja.TextColor = System.Drawing.Color.Black;
            // 
            // curvedButton1
            // 
            this.curvedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.curvedButton1.BorderColor = System.Drawing.Color.Black;
            this.curvedButton1.BorderOffset = 1;
            this.curvedButton1.CurveSize = 10;
            this.curvedButton1.FlatAppearance.BorderSize = 0;
            this.curvedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curvedButton1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curvedButton1.Location = new System.Drawing.Point(234, 225);
            this.curvedButton1.Name = "curvedButton1";
            this.curvedButton1.Size = new System.Drawing.Size(233, 43);
            this.curvedButton1.TabIndex = 106;
            this.curvedButton1.Text = "Change";
            this.curvedButton1.UseVisualStyleBackColor = false;
            // 
            // curvedButton2
            // 
            this.curvedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.curvedButton2.BorderColor = System.Drawing.Color.Black;
            this.curvedButton2.BorderOffset = 1;
            this.curvedButton2.CurveSize = 10;
            this.curvedButton2.FlatAppearance.BorderSize = 0;
            this.curvedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curvedButton2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curvedButton2.Location = new System.Drawing.Point(474, 225);
            this.curvedButton2.Name = "curvedButton2";
            this.curvedButton2.Size = new System.Drawing.Size(233, 43);
            this.curvedButton2.TabIndex = 107;
            this.curvedButton2.Text = "Delete";
            this.curvedButton2.UseVisualStyleBackColor = false;
            // 
            // curvedButton3
            // 
            this.curvedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.curvedButton3.BorderColor = System.Drawing.Color.Black;
            this.curvedButton3.BorderOffset = 1;
            this.curvedButton3.CurveSize = 10;
            this.curvedButton3.FlatAppearance.BorderSize = 0;
            this.curvedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curvedButton3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curvedButton3.Location = new System.Drawing.Point(234, 274);
            this.curvedButton3.Name = "curvedButton3";
            this.curvedButton3.Size = new System.Drawing.Size(473, 43);
            this.curvedButton3.TabIndex = 108;
            this.curvedButton3.Text = "Add";
            this.curvedButton3.UseVisualStyleBackColor = false;
            // 
            // lbxGost
            // 
            this.lbxGost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(140)))));
            this.lbxGost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxGost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxGost.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbxGost.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxGost.FormattingEnabled = true;
            this.lbxGost.HorizontalScrollbar = true;
            this.lbxGost.ItemHeight = 26;
            this.lbxGost.Location = new System.Drawing.Point(0, 335);
            this.lbxGost.Name = "lbxGost";
            this.lbxGost.Size = new System.Drawing.Size(932, 260);
            this.lbxGost.TabIndex = 110;
            this.lbxGost.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxGost_DrawItem_1);
            // 
            // FormGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(932, 595);
            this.Controls.Add(this.lbxGost);
            this.Controls.Add(this.curvedButton3);
            this.Controls.Add(this.curvedButton2);
            this.Controls.Add(this.curvedButton1);
            this.Controls.Add(this.dateGostDatumRodjenja);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtGostTelefon);
            this.Controls.Add(this.txtGostPrezime);
            this.Controls.Add(this.txtGostIme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGost";
            this.Text = "Guests";
            this.Load += new System.EventHandler(this.FormGost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private UI_Elements.CustomTextBox txtGostIme;
        private UI_Elements.CustomTextBox txtGostPrezime;
        private UI_Elements.CustomTextBox txtGostTelefon;
        private UI_Elements.CustomTextBox txtID;
        private CustomControls.RJControls.CustomDateTimePicker dateGostDatumRodjenja;
        private UI_Elements.CurvedButton curvedButton1;
        private UI_Elements.CurvedButton curvedButton2;
        private UI_Elements.CurvedButton curvedButton3;
        private System.Windows.Forms.ListBox lbxGost;
    }
}