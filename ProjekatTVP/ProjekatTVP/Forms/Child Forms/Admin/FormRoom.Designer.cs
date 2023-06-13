namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    partial class FormRoom
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
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtID = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomNumberOfRooms = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoomNumberOfBeds = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomDiscount = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomPrice = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomMinStayTime = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.curvedButton3 = new ProjekatTVP.UI_Elements.CustomButton();
            this.curvedButton2 = new ProjekatTVP.UI_Elements.CustomButton();
            this.curvedButton1 = new ProjekatTVP.UI_Elements.CustomButton();
            this.lbxRoom = new ProjekatTVP.UI_Elements.CustomListBox();
            this.SuspendLayout();
            // 
            // cmbSobaTip
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "standard",
            "lux"});
            this.cmbRoomType.Location = new System.Drawing.Point(237, 236);
            this.cmbRoomType.Name = "cmbSobaTip";
            this.cmbRoomType.Size = new System.Drawing.Size(100, 21);
            this.cmbRoomType.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Type of room";
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
            this.txtID.Location = new System.Drawing.Point(237, 36);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtID.PlaceholderText = "";
            this.txtID.Size = new System.Drawing.Size(83, 37);
            this.txtID.TabIndex = 113;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 112;
            this.label1.Text = "ID (Change or Delete)";
            // 
            // txtSobaBroj
            // 
            this.txtRoomNumberOfRooms.BackColor = System.Drawing.Color.Wheat;
            this.txtRoomNumberOfRooms.BorderColor = System.Drawing.Color.Black;
            this.txtRoomNumberOfRooms.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtRoomNumberOfRooms.BorderRadius = 10;
            this.txtRoomNumberOfRooms.BorderSize = 2;
            this.txtRoomNumberOfRooms.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumberOfRooms.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNumberOfRooms.IsFocused = false;
            this.txtRoomNumberOfRooms.Location = new System.Drawing.Point(233, 102);
            this.txtRoomNumberOfRooms.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNumberOfRooms.Multiline = false;
            this.txtRoomNumberOfRooms.Name = "txtSobaBroj";
            this.txtRoomNumberOfRooms.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRoomNumberOfRooms.PasswordChar = false;
            this.txtRoomNumberOfRooms.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRoomNumberOfRooms.PlaceholderText = "1, 2, 3...";
            this.txtRoomNumberOfRooms.Size = new System.Drawing.Size(233, 37);
            this.txtRoomNumberOfRooms.TabIndex = 115;
            this.txtRoomNumberOfRooms.Texts = "";
            this.txtRoomNumberOfRooms.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 22);
            this.label6.TabIndex = 114;
            this.label6.Text = "Number of rooms";
            // 
            // txtSobaBrojKreveta
            // 
            this.txtRoomNumberOfBeds.BackColor = System.Drawing.Color.Wheat;
            this.txtRoomNumberOfBeds.BorderColor = System.Drawing.Color.Black;
            this.txtRoomNumberOfBeds.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtRoomNumberOfBeds.BorderRadius = 10;
            this.txtRoomNumberOfBeds.BorderSize = 2;
            this.txtRoomNumberOfBeds.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumberOfBeds.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNumberOfBeds.IsFocused = false;
            this.txtRoomNumberOfBeds.Location = new System.Drawing.Point(233, 169);
            this.txtRoomNumberOfBeds.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNumberOfBeds.Multiline = false;
            this.txtRoomNumberOfBeds.Name = "txtSobaBrojKreveta";
            this.txtRoomNumberOfBeds.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRoomNumberOfBeds.PasswordChar = false;
            this.txtRoomNumberOfBeds.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRoomNumberOfBeds.PlaceholderText = "2, 3, 4...";
            this.txtRoomNumberOfBeds.Size = new System.Drawing.Size(233, 37);
            this.txtRoomNumberOfBeds.TabIndex = 117;
            this.txtRoomNumberOfBeds.Texts = "";
            this.txtRoomNumberOfBeds.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 116;
            this.label3.Text = "Number of beds";
            // 
            // txtSobaPopust
            // 
            this.txtRoomDiscount.BackColor = System.Drawing.Color.Wheat;
            this.txtRoomDiscount.BorderColor = System.Drawing.Color.Black;
            this.txtRoomDiscount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtRoomDiscount.BorderRadius = 10;
            this.txtRoomDiscount.BorderSize = 2;
            this.txtRoomDiscount.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtRoomDiscount.IsFocused = false;
            this.txtRoomDiscount.Location = new System.Drawing.Point(474, 169);
            this.txtRoomDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomDiscount.Multiline = false;
            this.txtRoomDiscount.Name = "txtSobaPopust";
            this.txtRoomDiscount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRoomDiscount.PasswordChar = false;
            this.txtRoomDiscount.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRoomDiscount.PlaceholderText = "200, 300, 400...";
            this.txtRoomDiscount.Size = new System.Drawing.Size(233, 37);
            this.txtRoomDiscount.TabIndex = 119;
            this.txtRoomDiscount.Texts = "";
            this.txtRoomDiscount.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 118;
            this.label4.Text = "Discount";
            // 
            // txtSobaCena
            // 
            this.txtRoomPrice.BackColor = System.Drawing.Color.Wheat;
            this.txtRoomPrice.BorderColor = System.Drawing.Color.Black;
            this.txtRoomPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtRoomPrice.BorderRadius = 10;
            this.txtRoomPrice.BorderSize = 2;
            this.txtRoomPrice.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomPrice.ForeColor = System.Drawing.Color.Black;
            this.txtRoomPrice.IsFocused = false;
            this.txtRoomPrice.Location = new System.Drawing.Point(474, 102);
            this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomPrice.Multiline = false;
            this.txtRoomPrice.Name = "txtSobaCena";
            this.txtRoomPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRoomPrice.PasswordChar = false;
            this.txtRoomPrice.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRoomPrice.PlaceholderText = "1000, 2000, 3000...";
            this.txtRoomPrice.Size = new System.Drawing.Size(233, 37);
            this.txtRoomPrice.TabIndex = 121;
            this.txtRoomPrice.Texts = "";
            this.txtRoomPrice.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 120;
            this.label5.Text = "Price";
            // 
            // txtSobaMin
            // 
            this.txtRoomMinStayTime.BackColor = System.Drawing.Color.Wheat;
            this.txtRoomMinStayTime.BorderColor = System.Drawing.Color.Black;
            this.txtRoomMinStayTime.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtRoomMinStayTime.BorderRadius = 10;
            this.txtRoomMinStayTime.BorderSize = 2;
            this.txtRoomMinStayTime.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomMinStayTime.ForeColor = System.Drawing.Color.Black;
            this.txtRoomMinStayTime.IsFocused = false;
            this.txtRoomMinStayTime.Location = new System.Drawing.Point(474, 236);
            this.txtRoomMinStayTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomMinStayTime.Multiline = false;
            this.txtRoomMinStayTime.Name = "txtSobaMin";
            this.txtRoomMinStayTime.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRoomMinStayTime.PasswordChar = false;
            this.txtRoomMinStayTime.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRoomMinStayTime.PlaceholderText = "8, 9, 10...";
            this.txtRoomMinStayTime.Size = new System.Drawing.Size(233, 37);
            this.txtRoomMinStayTime.TabIndex = 123;
            this.txtRoomMinStayTime.Texts = "";
            this.txtRoomMinStayTime.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 22);
            this.label7.TabIndex = 122;
            this.label7.Text = "Minimum stay time";
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
            this.curvedButton3.Location = new System.Drawing.Point(233, 328);
            this.curvedButton3.Name = "curvedButton3";
            this.curvedButton3.Size = new System.Drawing.Size(473, 43);
            this.curvedButton3.TabIndex = 126;
            this.curvedButton3.Text = "Add";
            this.curvedButton3.UseVisualStyleBackColor = false;
            this.curvedButton3.Click += new System.EventHandler(this.btnAddRoom_Click);
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
            this.curvedButton2.Location = new System.Drawing.Point(474, 279);
            this.curvedButton2.Name = "curvedButton2";
            this.curvedButton2.Size = new System.Drawing.Size(233, 43);
            this.curvedButton2.TabIndex = 125;
            this.curvedButton2.Text = "Delete";
            this.curvedButton2.UseVisualStyleBackColor = false;
            this.curvedButton2.Click += new System.EventHandler(this.btnDeleteRoom_Click);
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
            this.curvedButton1.Location = new System.Drawing.Point(233, 279);
            this.curvedButton1.Name = "curvedButton1";
            this.curvedButton1.Size = new System.Drawing.Size(233, 43);
            this.curvedButton1.TabIndex = 124;
            this.curvedButton1.Text = "Change";
            this.curvedButton1.UseVisualStyleBackColor = false;
            this.curvedButton1.Click += new System.EventHandler(this.btnChangeRoom_Click);
            // 
            // lbxSoba
            // 
            this.lbxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(140)))));
            this.lbxRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbxRoom.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRoom.FormattingEnabled = true;
            this.lbxRoom.ItemHeight = 20;
            this.lbxRoom.Location = new System.Drawing.Point(0, 375);
            this.lbxRoom.Name = "lbxSoba";
            this.lbxRoom.Size = new System.Drawing.Size(932, 220);
            this.lbxRoom.TabIndex = 128;
            // 
            // FormSoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 595);
            this.Controls.Add(this.lbxRoom);
            this.Controls.Add(this.curvedButton3);
            this.Controls.Add(this.curvedButton2);
            this.Controls.Add(this.curvedButton1);
            this.Controls.Add(this.txtRoomMinStayTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRoomNumberOfBeds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomNumberOfRooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.label12);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormSoba";
            this.Text = "FormSoba";
            this.Load += new System.EventHandler(this.FormSoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label label12;
        private UI_Elements.CustomTextBox txtID;
        private System.Windows.Forms.Label label1;
        private UI_Elements.CustomTextBox txtRoomNumberOfRooms;
        private System.Windows.Forms.Label label6;
        private UI_Elements.CustomTextBox txtRoomNumberOfBeds;
        private System.Windows.Forms.Label label3;
        private UI_Elements.CustomTextBox txtRoomDiscount;
        private System.Windows.Forms.Label label4;
        private UI_Elements.CustomTextBox txtRoomPrice;
        private System.Windows.Forms.Label label5;
        private UI_Elements.CustomTextBox txtRoomMinStayTime;
        private System.Windows.Forms.Label label7;
        private UI_Elements.CustomButton curvedButton3;
        private UI_Elements.CustomButton curvedButton2;
        private UI_Elements.CustomButton curvedButton1;
        private UI_Elements.CustomListBox lbxRoom;
    }
}