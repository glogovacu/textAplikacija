namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    partial class FormReservations
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
            this.lbxReservations = new ProjekatTVP.UI_Elements.CustomListBox();
            this.curvedButton3 = new ProjekatTVP.UI_Elements.CustomButton();
            this.curvedButton2 = new ProjekatTVP.UI_Elements.CustomButton();
            this.curvedButton1 = new ProjekatTVP.UI_Elements.CustomButton();
            this.dateReservationsDateFrom = new CustomControls.RJControls.CustomDateTimePicker();
            this.txtID = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtReservationsType = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtReservationsIdGuest = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtReservationsIdRoom = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateReservationsDateTo = new CustomControls.RJControls.CustomDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxRezervacije
            // 
            this.lbxReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(140)))));
            this.lbxReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxReservations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxReservations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbxReservations.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxReservations.FormattingEnabled = true;
            this.lbxReservations.ItemHeight = 20;
            this.lbxReservations.Location = new System.Drawing.Point(0, 375);
            this.lbxReservations.Name = "lbxRezervacije";
            this.lbxReservations.Size = new System.Drawing.Size(932, 220);
            this.lbxReservations.TabIndex = 124;
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
            this.curvedButton3.Location = new System.Drawing.Point(251, 326);
            this.curvedButton3.Name = "curvedButton3";
            this.curvedButton3.Size = new System.Drawing.Size(473, 43);
            this.curvedButton3.TabIndex = 123;
            this.curvedButton3.Text = "Add";
            this.curvedButton3.UseVisualStyleBackColor = false;
            this.curvedButton3.Click += new System.EventHandler(this.btnAddRes_Click);
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
            this.curvedButton2.Location = new System.Drawing.Point(491, 277);
            this.curvedButton2.Name = "curvedButton2";
            this.curvedButton2.Size = new System.Drawing.Size(233, 43);
            this.curvedButton2.TabIndex = 122;
            this.curvedButton2.Text = "Delete";
            this.curvedButton2.UseVisualStyleBackColor = false;
            this.curvedButton2.Click += new System.EventHandler(this.btnDeleteRes_Click);
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
            this.curvedButton1.Location = new System.Drawing.Point(251, 277);
            this.curvedButton1.Name = "curvedButton1";
            this.curvedButton1.Size = new System.Drawing.Size(233, 43);
            this.curvedButton1.TabIndex = 121;
            this.curvedButton1.Text = "Change";
            this.curvedButton1.UseVisualStyleBackColor = false;
            this.curvedButton1.Click += new System.EventHandler(this.btnChangeRes_Click);
            // 
            // dateRezervacijeDatumOd
            // 
            this.dateReservationsDateFrom.BorderColor = System.Drawing.Color.Black;
            this.dateReservationsDateFrom.BorderSize = 2;
            this.dateReservationsDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateReservationsDateFrom.Location = new System.Drawing.Point(255, 171);
            this.dateReservationsDateFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateReservationsDateFrom.Name = "dateRezervacijeDatumOd";
            this.dateReservationsDateFrom.Size = new System.Drawing.Size(229, 35);
            this.dateReservationsDateFrom.SkinColor = System.Drawing.Color.Wheat;
            this.dateReservationsDateFrom.TabIndex = 120;
            this.dateReservationsDateFrom.TextColor = System.Drawing.Color.Black;
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
            this.txtID.Location = new System.Drawing.Point(251, 35);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtID.PasswordChar = false;
            this.txtID.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtID.PlaceholderText = "";
            this.txtID.Size = new System.Drawing.Size(83, 37);
            this.txtID.TabIndex = 119;
            this.txtID.Texts = "";
            this.txtID.UnderlinedStyle = false;
            // 
            // txtRezervacijeTip
            // 
            this.txtReservationsType.BackColor = System.Drawing.Color.Wheat;
            this.txtReservationsType.BorderColor = System.Drawing.Color.Black;
            this.txtReservationsType.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtReservationsType.BorderRadius = 10;
            this.txtReservationsType.BorderSize = 2;
            this.txtReservationsType.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationsType.ForeColor = System.Drawing.Color.DimGray;
            this.txtReservationsType.IsFocused = false;
            this.txtReservationsType.Location = new System.Drawing.Point(251, 235);
            this.txtReservationsType.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservationsType.Multiline = false;
            this.txtReservationsType.Name = "txtRezervacijeTip";
            this.txtReservationsType.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReservationsType.PasswordChar = false;
            this.txtReservationsType.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtReservationsType.PlaceholderText = "Day Use, Extended Stay...";
            this.txtReservationsType.Size = new System.Drawing.Size(473, 37);
            this.txtReservationsType.TabIndex = 118;
            this.txtReservationsType.Texts = "";
            this.txtReservationsType.UnderlinedStyle = false;
            // 
            // txtRezervacijeIDGosta
            // 
            this.txtReservationsIdGuest.BackColor = System.Drawing.Color.Wheat;
            this.txtReservationsIdGuest.BorderColor = System.Drawing.Color.Black;
            this.txtReservationsIdGuest.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtReservationsIdGuest.BorderRadius = 10;
            this.txtReservationsIdGuest.BorderSize = 2;
            this.txtReservationsIdGuest.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationsIdGuest.ForeColor = System.Drawing.Color.DimGray;
            this.txtReservationsIdGuest.IsFocused = false;
            this.txtReservationsIdGuest.Location = new System.Drawing.Point(491, 102);
            this.txtReservationsIdGuest.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservationsIdGuest.Multiline = false;
            this.txtReservationsIdGuest.Name = "txtRezervacijeIDGosta";
            this.txtReservationsIdGuest.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReservationsIdGuest.PasswordChar = false;
            this.txtReservationsIdGuest.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtReservationsIdGuest.PlaceholderText = "4, 5, 6...";
            this.txtReservationsIdGuest.Size = new System.Drawing.Size(233, 37);
            this.txtReservationsIdGuest.TabIndex = 117;
            this.txtReservationsIdGuest.Texts = "";
            this.txtReservationsIdGuest.UnderlinedStyle = false;
            // 
            // txtRezervacijeIDSobe
            // 
            this.txtReservationsIdRoom.BackColor = System.Drawing.Color.Wheat;
            this.txtReservationsIdRoom.BorderColor = System.Drawing.Color.Black;
            this.txtReservationsIdRoom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtReservationsIdRoom.BorderRadius = 10;
            this.txtReservationsIdRoom.BorderSize = 2;
            this.txtReservationsIdRoom.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationsIdRoom.ForeColor = System.Drawing.Color.Black;
            this.txtReservationsIdRoom.IsFocused = false;
            this.txtReservationsIdRoom.Location = new System.Drawing.Point(251, 102);
            this.txtReservationsIdRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservationsIdRoom.Multiline = false;
            this.txtReservationsIdRoom.Name = "txtRezervacijeIDSobe";
            this.txtReservationsIdRoom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReservationsIdRoom.PasswordChar = false;
            this.txtReservationsIdRoom.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtReservationsIdRoom.PlaceholderText = "1, 2, 3...";
            this.txtReservationsIdRoom.Size = new System.Drawing.Size(233, 37);
            this.txtReservationsIdRoom.TabIndex = 116;
            this.txtReservationsIdRoom.Texts = "";
            this.txtReservationsIdRoom.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(491, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 115;
            this.label9.Text = "Guest ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 22);
            this.label8.TabIndex = 114;
            this.label8.Text = "Type of reservation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 22);
            this.label7.TabIndex = 113;
            this.label7.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 112;
            this.label6.Text = "Room ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 125;
            this.label1.Text = "ID (Change or Delete)";
            // 
            // dateRezervacijeDatumDo
            // 
            this.dateReservationsDateTo.BorderColor = System.Drawing.Color.Black;
            this.dateReservationsDateTo.BorderSize = 2;
            this.dateReservationsDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateReservationsDateTo.Location = new System.Drawing.Point(495, 171);
            this.dateReservationsDateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateReservationsDateTo.Name = "dateRezervacijeDatumDo";
            this.dateReservationsDateTo.Size = new System.Drawing.Size(229, 35);
            this.dateReservationsDateTo.SkinColor = System.Drawing.Color.Wheat;
            this.dateReservationsDateTo.TabIndex = 126;
            this.dateReservationsDateTo.TextColor = System.Drawing.Color.Black;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 22);
            this.label2.TabIndex = 127;
            this.label2.Text = "To";
            // 
            // FormRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateReservationsDateTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxReservations);
            this.Controls.Add(this.curvedButton3);
            this.Controls.Add(this.curvedButton2);
            this.Controls.Add(this.curvedButton1);
            this.Controls.Add(this.dateReservationsDateFrom);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtReservationsType);
            this.Controls.Add(this.txtReservationsIdGuest);
            this.Controls.Add(this.txtReservationsIdRoom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormRezervacije";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.FormReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private UI_Elements.CustomListBox lbxReservations;
        private UI_Elements.CustomButton curvedButton3;
        private UI_Elements.CustomButton curvedButton2;
        private UI_Elements.CustomButton curvedButton1;
        private CustomControls.RJControls.CustomDateTimePicker dateReservationsDateFrom;
        private UI_Elements.CustomTextBox txtID;
        private UI_Elements.CustomTextBox txtReservationsType;
        private UI_Elements.CustomTextBox txtReservationsIdGuest;
        private UI_Elements.CustomTextBox txtReservationsIdRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.CustomDateTimePicker dateReservationsDateTo;
        private System.Windows.Forms.Label label2;
    }
}