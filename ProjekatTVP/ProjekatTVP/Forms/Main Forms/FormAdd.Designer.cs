namespace ProjekatTVP
{
    partial class FormAdd
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbxGuest = new ProjekatTVP.UI_Elements.CustomListBox();
            this.curvedButton3 = new ProjekatTVP.UI_Elements.CustomButton();
            this.dateGuestDateOfBirth = new CustomControls.RJControls.CustomDateTimePicker();
            this.txtGuestPhone = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtGuestLastName = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtGuestFirstName = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateReservationsDateTo = new CustomControls.RJControls.CustomDateTimePicker();
            this.curvedButton1 = new ProjekatTVP.UI_Elements.CustomButton();
            this.dateReservationsDateFrom = new CustomControls.RJControls.CustomDateTimePicker();
            this.txtReservationsType = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtReservationsIdGuest = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.txtReservationsIdRoom = new ProjekatTVP.UI_Elements.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbxReservations = new ProjekatTVP.UI_Elements.CustomListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.curvedButton2 = new ProjekatTVP.UI_Elements.CustomButton();
            this.curvedButton4 = new ProjekatTVP.UI_Elements.CustomButton();
            this.lbxRoom = new ProjekatTVP.UI_Elements.CustomListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "standard",
            "lux"});
            this.comboBox1.Location = new System.Drawing.Point(970, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 113;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1088, 300);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 20);
            this.numericUpDown1.TabIndex = 115;
            // 
            // lbxGuest
            // 
            this.lbxGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(140)))));
            this.lbxGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxGuest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbxGuest.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxGuest.FormattingEnabled = true;
            this.lbxGuest.ItemHeight = 20;
            this.lbxGuest.Location = new System.Drawing.Point(0, 320);
            this.lbxGuest.Name = "lbxGuest";
            this.lbxGuest.Size = new System.Drawing.Size(485, 395);
            this.lbxGuest.TabIndex = 128;
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
            this.curvedButton3.Location = new System.Drawing.Point(6, 258);
            this.curvedButton3.Name = "curvedButton3";
            this.curvedButton3.Size = new System.Drawing.Size(473, 43);
            this.curvedButton3.TabIndex = 127;
            this.curvedButton3.Text = "Add";
            this.curvedButton3.UseVisualStyleBackColor = false;
            this.curvedButton3.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // dateGostDatumRodjenja
            // 
            this.dateGuestDateOfBirth.BorderColor = System.Drawing.Color.Black;
            this.dateGuestDateOfBirth.BorderSize = 2;
            this.dateGuestDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateGuestDateOfBirth.Location = new System.Drawing.Point(246, 152);
            this.dateGuestDateOfBirth.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateGuestDateOfBirth.Name = "dateGostDatumRodjenja";
            this.dateGuestDateOfBirth.Size = new System.Drawing.Size(233, 35);
            this.dateGuestDateOfBirth.SkinColor = System.Drawing.Color.Wheat;
            this.dateGuestDateOfBirth.TabIndex = 124;
            this.dateGuestDateOfBirth.TextColor = System.Drawing.Color.Black;
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.BackColor = System.Drawing.Color.Wheat;
            this.txtGuestPhone.BorderColor = System.Drawing.Color.Black;
            this.txtGuestPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtGuestPhone.BorderRadius = 10;
            this.txtGuestPhone.BorderSize = 2;
            this.txtGuestPhone.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtGuestPhone.IsFocused = false;
            this.txtGuestPhone.Location = new System.Drawing.Point(246, 214);
            this.txtGuestPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestPhone.Multiline = false;
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGuestPhone.PasswordChar = false;
            this.txtGuestPhone.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtGuestPhone.PlaceholderText = "555-333";
            this.txtGuestPhone.Size = new System.Drawing.Size(233, 37);
            this.txtGuestPhone.TabIndex = 122;
            this.txtGuestPhone.Texts = "";
            this.txtGuestPhone.UnderlinedStyle = false;
            // 
            // txtGuestLastName
            // 
            this.txtGuestLastName.BackColor = System.Drawing.Color.Wheat;
            this.txtGuestLastName.BorderColor = System.Drawing.Color.Black;
            this.txtGuestLastName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtGuestLastName.BorderRadius = 10;
            this.txtGuestLastName.BorderSize = 2;
            this.txtGuestLastName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtGuestLastName.IsFocused = false;
            this.txtGuestLastName.Location = new System.Drawing.Point(6, 214);
            this.txtGuestLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestLastName.Multiline = false;
            this.txtGuestLastName.Name = "txtGuestLastName";
            this.txtGuestLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGuestLastName.PasswordChar = false;
            this.txtGuestLastName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtGuestLastName.PlaceholderText = "Smith";
            this.txtGuestLastName.Size = new System.Drawing.Size(233, 37);
            this.txtGuestLastName.TabIndex = 121;
            this.txtGuestLastName.Texts = "";
            this.txtGuestLastName.UnderlinedStyle = false;
            // 
            // txtGuestFirstName
            // 
            this.txtGuestFirstName.BackColor = System.Drawing.Color.Wheat;
            this.txtGuestFirstName.BorderColor = System.Drawing.Color.Black;
            this.txtGuestFirstName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(166)))), ((int)(((byte)(92)))));
            this.txtGuestFirstName.BorderRadius = 10;
            this.txtGuestFirstName.BorderSize = 2;
            this.txtGuestFirstName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtGuestFirstName.IsFocused = false;
            this.txtGuestFirstName.Location = new System.Drawing.Point(6, 150);
            this.txtGuestFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestFirstName.Multiline = false;
            this.txtGuestFirstName.Name = "txtGuestFirstName";
            this.txtGuestFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGuestFirstName.PasswordChar = false;
            this.txtGuestFirstName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtGuestFirstName.PlaceholderText = "John";
            this.txtGuestFirstName.Size = new System.Drawing.Size(233, 37);
            this.txtGuestFirstName.TabIndex = 120;
            this.txtGuestFirstName.Texts = "";
            this.txtGuestFirstName.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 119;
            this.label9.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 22);
            this.label8.TabIndex = 118;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 117;
            this.label7.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 116;
            this.label6.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 40);
            this.label1.TabIndex = 129;
            this.label1.Text = "Guests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(727, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 22);
            this.label3.TabIndex = 143;
            this.label3.Text = "To";
            // 
            // dateRezervacijeDatumDo
            // 
            this.dateReservationsDateTo.BorderColor = System.Drawing.Color.Black;
            this.dateReservationsDateTo.BorderSize = 2;
            this.dateReservationsDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateReservationsDateTo.Location = new System.Drawing.Point(731, 220);
            this.dateReservationsDateTo.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateReservationsDateTo.Name = "dateRezervacijeDatumDo";
            this.dateReservationsDateTo.Size = new System.Drawing.Size(229, 35);
            this.dateReservationsDateTo.SkinColor = System.Drawing.Color.Wheat;
            this.dateReservationsDateTo.TabIndex = 142;
            this.dateReservationsDateTo.TextColor = System.Drawing.Color.Black;
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
            this.curvedButton1.Location = new System.Drawing.Point(491, 326);
            this.curvedButton1.Name = "curvedButton1";
            this.curvedButton1.Size = new System.Drawing.Size(473, 43);
            this.curvedButton1.TabIndex = 140;
            this.curvedButton1.Text = "Add";
            this.curvedButton1.UseVisualStyleBackColor = false;
            this.curvedButton1.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // dateRezervacijeDatumOd
            // 
            this.dateReservationsDateFrom.BorderColor = System.Drawing.Color.Black;
            this.dateReservationsDateFrom.BorderSize = 2;
            this.dateReservationsDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateReservationsDateFrom.Location = new System.Drawing.Point(491, 220);
            this.dateReservationsDateFrom.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateReservationsDateFrom.Name = "dateRezervacijeDatumOd";
            this.dateReservationsDateFrom.Size = new System.Drawing.Size(229, 35);
            this.dateReservationsDateFrom.SkinColor = System.Drawing.Color.Wheat;
            this.dateReservationsDateFrom.TabIndex = 137;
            this.dateReservationsDateFrom.TextColor = System.Drawing.Color.Black;
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
            this.txtReservationsType.Location = new System.Drawing.Point(491, 282);
            this.txtReservationsType.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservationsType.Multiline = false;
            this.txtReservationsType.Name = "txtRezervacijeTip";
            this.txtReservationsType.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReservationsType.PasswordChar = false;
            this.txtReservationsType.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtReservationsType.PlaceholderText = "Day Use, Extended Stay...";
            this.txtReservationsType.Size = new System.Drawing.Size(473, 37);
            this.txtReservationsType.TabIndex = 136;
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
            this.txtReservationsIdGuest.Location = new System.Drawing.Point(727, 149);
            this.txtReservationsIdGuest.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservationsIdGuest.Multiline = false;
            this.txtReservationsIdGuest.Name = "txtRezervacijeIDGosta";
            this.txtReservationsIdGuest.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReservationsIdGuest.PasswordChar = false;
            this.txtReservationsIdGuest.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtReservationsIdGuest.PlaceholderText = "4, 5, 6...";
            this.txtReservationsIdGuest.Size = new System.Drawing.Size(233, 37);
            this.txtReservationsIdGuest.TabIndex = 135;
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
            this.txtReservationsIdRoom.Location = new System.Drawing.Point(487, 149);
            this.txtReservationsIdRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservationsIdRoom.Multiline = false;
            this.txtReservationsIdRoom.Name = "txtRezervacijeIDSobe";
            this.txtReservationsIdRoom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtReservationsIdRoom.PasswordChar = false;
            this.txtReservationsIdRoom.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtReservationsIdRoom.PlaceholderText = "1, 2, 3...";
            this.txtReservationsIdRoom.Size = new System.Drawing.Size(233, 37);
            this.txtReservationsIdRoom.TabIndex = 134;
            this.txtReservationsIdRoom.Texts = "";
            this.txtReservationsIdRoom.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(727, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 133;
            this.label4.Text = "Guest ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(487, 256);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 22);
            this.label5.TabIndex = 132;
            this.label5.Text = "Type of reservation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(487, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 22);
            this.label10.TabIndex = 131;
            this.label10.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(487, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 22);
            this.label11.TabIndex = 130;
            this.label11.Text = "Room ID";
            // 
            // lbxReservations
            // 
            this.lbxReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(140)))));
            this.lbxReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxReservations.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbxReservations.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxReservations.FormattingEnabled = true;
            this.lbxReservations.ItemHeight = 20;
            this.lbxReservations.Location = new System.Drawing.Point(485, 375);
            this.lbxReservations.Name = "lbxReservations";
            this.lbxReservations.Size = new System.Drawing.Size(485, 340);
            this.lbxReservations.TabIndex = 141;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(621, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 40);
            this.label12.TabIndex = 144;
            this.label12.Text = "Reservations";
            // 
            // curvedButton2
            // 
            this.curvedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.curvedButton2.BorderColor = System.Drawing.Color.Black;
            this.curvedButton2.BorderOffset = 1;
            this.curvedButton2.CurveSize = 10;
            this.curvedButton2.FlatAppearance.BorderSize = 0;
            this.curvedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curvedButton2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curvedButton2.Location = new System.Drawing.Point(970, 326);
            this.curvedButton2.Name = "curvedButton2";
            this.curvedButton2.Size = new System.Drawing.Size(112, 43);
            this.curvedButton2.TabIndex = 145;
            this.curvedButton2.Text = "Filter by type";
            this.curvedButton2.UseVisualStyleBackColor = false;
            this.curvedButton2.Click += new System.EventHandler(this.btnFilterByType_Click);
            // 
            // curvedButton4
            // 
            this.curvedButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.curvedButton4.BorderColor = System.Drawing.Color.Black;
            this.curvedButton4.BorderOffset = 1;
            this.curvedButton4.CurveSize = 10;
            this.curvedButton4.FlatAppearance.BorderSize = 0;
            this.curvedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curvedButton4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curvedButton4.Location = new System.Drawing.Point(1083, 326);
            this.curvedButton4.Name = "curvedButton4";
            this.curvedButton4.Size = new System.Drawing.Size(112, 43);
            this.curvedButton4.TabIndex = 146;
            this.curvedButton4.Text = "Filter by bed number";
            this.curvedButton4.UseVisualStyleBackColor = false;
            this.curvedButton4.Click += new System.EventHandler(this.btnFilterByNumberOfBeds_Click);
            // 
            // lbxRoom
            // 
            this.lbxRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(188)))), ((int)(((byte)(140)))));
            this.lbxRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbxRoom.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxRoom.FormattingEnabled = true;
            this.lbxRoom.ItemHeight = 20;
            this.lbxRoom.Location = new System.Drawing.Point(970, 375);
            this.lbxRoom.Name = "lbxRoom";
            this.lbxRoom.Size = new System.Drawing.Size(234, 340);
            this.lbxRoom.TabIndex = 147;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1200, 715);
            this.Controls.Add(this.lbxRoom);
            this.Controls.Add(this.curvedButton4);
            this.Controls.Add(this.curvedButton2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateReservationsDateTo);
            this.Controls.Add(this.lbxReservations);
            this.Controls.Add(this.curvedButton1);
            this.Controls.Add(this.dateReservationsDateFrom);
            this.Controls.Add(this.txtReservationsType);
            this.Controls.Add(this.txtReservationsIdGuest);
            this.Controls.Add(this.txtReservationsIdRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxGuest);
            this.Controls.Add(this.curvedButton3);
            this.Controls.Add(this.dateGuestDateOfBirth);
            this.Controls.Add(this.txtGuestPhone);
            this.Controls.Add(this.txtGuestLastName);
            this.Controls.Add(this.txtGuestFirstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormAdd";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private UI_Elements.CustomListBox lbxGuest;
        private UI_Elements.CustomButton curvedButton3;
        private CustomControls.RJControls.CustomDateTimePicker dateGuestDateOfBirth;
        private UI_Elements.CustomTextBox txtGuestPhone;
        private UI_Elements.CustomTextBox txtGuestLastName;
        private UI_Elements.CustomTextBox txtGuestFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.CustomDateTimePicker dateReservationsDateTo;
        private UI_Elements.CustomButton curvedButton1;
        private CustomControls.RJControls.CustomDateTimePicker dateReservationsDateFrom;
        private UI_Elements.CustomTextBox txtReservationsType;
        private UI_Elements.CustomTextBox txtReservationsIdGuest;
        private UI_Elements.CustomTextBox txtReservationsIdRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private UI_Elements.CustomListBox lbxReservations;
        private System.Windows.Forms.Label label12;
        private UI_Elements.CustomButton curvedButton2;
        private UI_Elements.CustomButton curvedButton4;
        private UI_Elements.CustomListBox lbxRoom;
    }
}