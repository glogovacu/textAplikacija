namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    partial class FormUser
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
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.lbxUser = new ProjekatTVP.UI_Elements.CustomListBox();
            this.curvedButton3 = new ProjekatTVP.UI_Elements.CustomButton();
            this.curvedButton2 = new ProjekatTVP.UI_Elements.CustomButton();
            this.curvedButton1 = new ProjekatTVP.UI_Elements.CustomButton();
            this.txtID = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtUserPassword = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtUserLastName = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtUserFirstName = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserUsername = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.SuspendLayout();
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "admin",
            "recepcionar"});
            this.cmbUserType.Location = new System.Drawing.Point(231, 242);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(473, 21);
            this.cmbUserType.TabIndex = 96;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(228, 226);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 91;
            this.label27.Text = "Role";
            // 
            // lbxUser
            // 
            this.lbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(140)))));
            this.lbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbxUser.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUser.FormattingEnabled = true;
            this.lbxUser.ItemHeight = 20;
            this.lbxUser.Location = new System.Drawing.Point(0, 375);
            this.lbxUser.Name = "lbxUser";
            this.lbxUser.Size = new System.Drawing.Size(932, 220);
            this.lbxUser.TabIndex = 125;
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
            this.curvedButton3.Location = new System.Drawing.Point(231, 318);
            this.curvedButton3.Name = "curvedButton3";
            this.curvedButton3.Size = new System.Drawing.Size(473, 43);
            this.curvedButton3.TabIndex = 124;
            this.curvedButton3.Text = "Add";
            this.curvedButton3.UseVisualStyleBackColor = false;
            this.curvedButton3.Click += new System.EventHandler(this.btnAddUser_Click);
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
            this.curvedButton2.Location = new System.Drawing.Point(471, 269);
            this.curvedButton2.Name = "curvedButton2";
            this.curvedButton2.Size = new System.Drawing.Size(233, 43);
            this.curvedButton2.TabIndex = 123;
            this.curvedButton2.Text = "Delete";
            this.curvedButton2.UseVisualStyleBackColor = false;
            this.curvedButton2.Click += new System.EventHandler(this.btnDeleteUser_Click);
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
            this.curvedButton1.Location = new System.Drawing.Point(231, 269);
            this.curvedButton1.Name = "curvedButton1";
            this.curvedButton1.Size = new System.Drawing.Size(233, 43);
            this.curvedButton1.TabIndex = 122;
            this.curvedButton1.Text = "Change";
            this.curvedButton1.UseVisualStyleBackColor = false;
            this.curvedButton1.Click += new System.EventHandler(this.btnChangeUser_Click);
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
            this.txtID.Location = new System.Drawing.Point(230, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtID.PlaceholderText = "";
            this.txtID.Size = new System.Drawing.Size(83, 37);
            this.txtID.TabIndex = 120;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = false;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BackColor = System.Drawing.Color.Wheat;
            this.txtUserPassword.BorderColor = System.Drawing.Color.Black;
            this.txtUserPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtUserPassword.BorderRadius = 10;
            this.txtUserPassword.BorderSize = 2;
            this.txtUserPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserPassword.IsFocused = false;
            this.txtUserPassword.Location = new System.Drawing.Point(471, 184);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPassword.Multiline = false;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserPassword.PasswordChar = false;
            this.txtUserPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUserPassword.PlaceholderText = "555-333";
            this.txtUserPassword.Size = new System.Drawing.Size(233, 37);
            this.txtUserPassword.TabIndex = 119;
            this.txtUserPassword.Texts = "";
            this.txtUserPassword.UnderlinedStyle = false;
            // 
            // txtUserLastName
            // 
            this.txtUserLastName.BackColor = System.Drawing.Color.Wheat;
            this.txtUserLastName.BorderColor = System.Drawing.Color.Black;
            this.txtUserLastName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtUserLastName.BorderRadius = 10;
            this.txtUserLastName.BorderSize = 2;
            this.txtUserLastName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserLastName.IsFocused = false;
            this.txtUserLastName.Location = new System.Drawing.Point(471, 117);
            this.txtUserLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserLastName.Multiline = false;
            this.txtUserLastName.Name = "txtUserLastName";
            this.txtUserLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserLastName.PasswordChar = false;
            this.txtUserLastName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUserLastName.PlaceholderText = "Smith";
            this.txtUserLastName.Size = new System.Drawing.Size(233, 37);
            this.txtUserLastName.TabIndex = 118;
            this.txtUserLastName.Texts = "";
            this.txtUserLastName.UnderlinedStyle = false;
            // 
            // txtUserFirstName
            // 
            this.txtUserFirstName.BackColor = System.Drawing.Color.Wheat;
            this.txtUserFirstName.BorderColor = System.Drawing.Color.Black;
            this.txtUserFirstName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtUserFirstName.BorderRadius = 10;
            this.txtUserFirstName.BorderSize = 2;
            this.txtUserFirstName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtUserFirstName.IsFocused = false;
            this.txtUserFirstName.Location = new System.Drawing.Point(230, 117);
            this.txtUserFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserFirstName.Multiline = false;
            this.txtUserFirstName.Name = "txtUserFirstName";
            this.txtUserFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserFirstName.PasswordChar = false;
            this.txtUserFirstName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUserFirstName.PlaceholderText = "John";
            this.txtUserFirstName.Size = new System.Drawing.Size(233, 37);
            this.txtUserFirstName.TabIndex = 117;
            this.txtUserFirstName.Texts = "";
            this.txtUserFirstName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 116;
            this.label1.Text = "ID (Change or Delete)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(467, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 115;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 114;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 113;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 112;
            this.label6.Text = "First Name";
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.BackColor = System.Drawing.Color.Wheat;
            this.txtUserUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUserUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtUserUsername.BorderRadius = 10;
            this.txtUserUsername.BorderSize = 2;
            this.txtUserUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUserUsername.IsFocused = false;
            this.txtUserUsername.Location = new System.Drawing.Point(231, 184);
            this.txtUserUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserUsername.Multiline = false;
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUserUsername.PasswordChar = false;
            this.txtUserUsername.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUserUsername.PlaceholderText = "555-333";
            this.txtUserUsername.Size = new System.Drawing.Size(232, 37);
            this.txtUserUsername.TabIndex = 126;
            this.txtUserUsername.Texts = "";
            this.txtUserUsername.UnderlinedStyle = false;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 595);
            this.Controls.Add(this.txtUserUsername);
            this.Controls.Add(this.lbxUser);
            this.Controls.Add(this.curvedButton3);
            this.Controls.Add(this.curvedButton2);
            this.Controls.Add(this.curvedButton1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserLastName);
            this.Controls.Add(this.txtUserFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.label27);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormUser";
            this.Text = "FormKorisnik";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label label27;
        private UI_Elements.CustomListBox lbxUser;
        private UI_Elements.CustomButton curvedButton3;
        private UI_Elements.CustomButton curvedButton2;
        private UI_Elements.CustomButton curvedButton1;
        private UI_Elements.CustomTextBox txtID;
        private UI_Elements.CustomTextBox txtUserPassword;
        private UI_Elements.CustomTextBox txtUserLastName;
        private UI_Elements.CustomTextBox txtUserFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private UI_Elements.CustomTextBox txtUserUsername;
    }
}