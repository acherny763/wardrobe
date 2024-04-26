namespace wardrobe
{
    partial class Persona
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_occupied = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_expire = new System.Windows.Forms.Label();
            this.LB_num = new System.Windows.Forms.Label();
            this.LB_hi = new System.Windows.Forms.Label();
            this.LN_header = new System.Windows.Forms.Button();
            this.BTN_free = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LB_countDays = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_signUp = new ePOSOne.btnProduct.Button_WOC();
            this.BTN_registration = new ePOSOne.btnProduct.Button_WOC();
            this.BTN_all = new System.Windows.Forms.Button();
            this.DGV_number = new System.Windows.Forms.DataGridView();
            this.LB_header = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.LB_roll = new System.Windows.Forms.Label();
            this.LB_close = new System.Windows.Forms.Label();
            this.BTN_30 = new System.Windows.Forms.Button();
            this.BTN_7 = new System.Windows.Forms.Button();
            this.BTN_1 = new System.Windows.Forms.Button();
            this.PN_countDays = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LB_userName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_number)).BeginInit();
            this.header.SuspendLayout();
            this.PN_countDays.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_occupied
            // 
            this.BTN_occupied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_occupied.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_occupied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_occupied.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_occupied.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_occupied.Location = new System.Drawing.Point(255, 192);
            this.BTN_occupied.Name = "BTN_occupied";
            this.BTN_occupied.Size = new System.Drawing.Size(146, 42);
            this.BTN_occupied.TabIndex = 128;
            this.BTN_occupied.Text = "Занятые";
            this.BTN_occupied.UseVisualStyleBackColor = true;
            this.BTN_occupied.Click += new System.EventHandler(this.BTN_occupied_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 127;
            this.label4.Text = "Номерки";
            // 
            // LB_expire
            // 
            this.LB_expire.AutoSize = true;
            this.LB_expire.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_expire.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LB_expire.Location = new System.Drawing.Point(210, 101);
            this.LB_expire.Margin = new System.Windows.Forms.Padding(0);
            this.LB_expire.Name = "LB_expire";
            this.LB_expire.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_expire.Size = new System.Drawing.Size(117, 26);
            this.LB_expire.TabIndex = 126;
            this.LB_expire.Text = "Истекает —";
            // 
            // LB_num
            // 
            this.LB_num.AutoSize = true;
            this.LB_num.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_num.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LB_num.Location = new System.Drawing.Point(25, 101);
            this.LB_num.Margin = new System.Windows.Forms.Padding(0);
            this.LB_num.Name = "LB_num";
            this.LB_num.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_num.Size = new System.Drawing.Size(135, 26);
            this.LB_num.TabIndex = 125;
            this.LB_num.Text = "Твой номер —";
            // 
            // LB_hi
            // 
            this.LB_hi.AutoSize = true;
            this.LB_hi.Font = new System.Drawing.Font("Manrope", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_hi.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_hi.Location = new System.Drawing.Point(22, 50);
            this.LB_hi.Margin = new System.Windows.Forms.Padding(0);
            this.LB_hi.Name = "LB_hi";
            this.LB_hi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_hi.Size = new System.Drawing.Size(153, 45);
            this.LB_hi.TabIndex = 124;
            this.LB_hi.Text = "Привет, ";
            // 
            // LN_header
            // 
            this.LN_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.LN_header.FlatAppearance.BorderSize = 0;
            this.LN_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LN_header.Location = new System.Drawing.Point(0, 134);
            this.LN_header.Name = "LN_header";
            this.LN_header.Size = new System.Drawing.Size(420, 1);
            this.LN_header.TabIndex = 123;
            this.LN_header.UseVisualStyleBackColor = false;
            // 
            // BTN_free
            // 
            this.BTN_free.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_free.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_free.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_free.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_free.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_free.Location = new System.Drawing.Point(108, 192);
            this.BTN_free.Name = "BTN_free";
            this.BTN_free.Size = new System.Drawing.Size(146, 42);
            this.BTN_free.TabIndex = 120;
            this.BTN_free.Text = "Свободные";
            this.BTN_free.UseVisualStyleBackColor = true;
            this.BTN_free.Click += new System.EventHandler(this.BTN_free_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(30, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 1);
            this.button1.TabIndex = 133;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LB_countDays
            // 
            this.LB_countDays.AutoSize = true;
            this.LB_countDays.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_countDays.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_countDays.Location = new System.Drawing.Point(22, 517);
            this.LB_countDays.Margin = new System.Windows.Forms.Padding(0);
            this.LB_countDays.Name = "LB_countDays";
            this.LB_countDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_countDays.Size = new System.Drawing.Size(222, 33);
            this.LB_countDays.TabIndex = 134;
            this.LB_countDays.Text = "Количество дней";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(30, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(360, 1);
            this.button2.TabIndex = 135;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BTN_signUp
            // 
            this.BTN_signUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.BTN_signUp.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BTN_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_signUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_signUp.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_signUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_signUp.Location = new System.Drawing.Point(30, 733);
            this.BTN_signUp.Name = "BTN_signUp";
            this.BTN_signUp.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.BTN_signUp.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BTN_signUp.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_signUp.Size = new System.Drawing.Size(360, 56);
            this.BTN_signUp.TabIndex = 137;
            this.BTN_signUp.Text = "Выйти с аккаунта";
            this.BTN_signUp.TextColor = System.Drawing.Color.White;
            this.BTN_signUp.UseVisualStyleBackColor = true;
            // 
            // BTN_registration
            // 
            this.BTN_registration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_registration.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_registration.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_registration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_registration.Location = new System.Drawing.Point(30, 667);
            this.BTN_registration.Name = "BTN_registration";
            this.BTN_registration.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_registration.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_registration.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_registration.Size = new System.Drawing.Size(360, 56);
            this.BTN_registration.TabIndex = 136;
            this.BTN_registration.Text = "Забронировать";
            this.BTN_registration.TextColor = System.Drawing.Color.White;
            this.BTN_registration.UseVisualStyleBackColor = true;
            // 
            // BTN_all
            // 
            this.BTN_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.BTN_all.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_all.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_all.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_all.Location = new System.Drawing.Point(30, 192);
            this.BTN_all.Name = "BTN_all";
            this.BTN_all.Size = new System.Drawing.Size(72, 42);
            this.BTN_all.TabIndex = 138;
            this.BTN_all.Text = "Все";
            this.BTN_all.UseVisualStyleBackColor = false;
            this.BTN_all.Click += new System.EventHandler(this.BTN_all_Click);
            // 
            // DGV_number
            // 
            this.DGV_number.AllowUserToAddRows = false;
            this.DGV_number.AllowUserToDeleteRows = false;
            this.DGV_number.AllowUserToResizeColumns = false;
            this.DGV_number.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DGV_number.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_number.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.DGV_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_number.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_number.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_number.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_number.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_number.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_number.EnableHeadersVisualStyles = false;
            this.DGV_number.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_number.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DGV_number.Location = new System.Drawing.Point(30, 240);
            this.DGV_number.MultiSelect = false;
            this.DGV_number.Name = "DGV_number";
            this.DGV_number.ReadOnly = true;
            this.DGV_number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_number.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_number.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_number.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DGV_number.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_number.ShowCellErrors = false;
            this.DGV_number.ShowCellToolTips = false;
            this.DGV_number.ShowEditingIcon = false;
            this.DGV_number.ShowRowErrors = false;
            this.DGV_number.Size = new System.Drawing.Size(369, 240);
            this.DGV_number.TabIndex = 139;
            this.DGV_number.TabStop = false;
            // 
            // LB_header
            // 
            this.LB_header.AutoSize = true;
            this.LB_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.LB_header.Font = new System.Drawing.Font("Manrope", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LB_header.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_header.Location = new System.Drawing.Point(10, 10);
            this.LB_header.Margin = new System.Windows.Forms.Padding(0);
            this.LB_header.Name = "LB_header";
            this.LB_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_header.Size = new System.Drawing.Size(114, 21);
            this.LB_header.TabIndex = 12;
            this.LB_header.Text = "Гардероб ТПК";
            this.LB_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_header_MouseDown);
            this.LB_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LB_header_MouseMove);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.header.Controls.Add(this.LB_roll);
            this.header.Controls.Add(this.LB_header);
            this.header.Controls.Add(this.LB_close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(420, 42);
            this.header.TabIndex = 140;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown_1);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            // 
            // LB_roll
            // 
            this.LB_roll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_roll.Font = new System.Drawing.Font("Manrope", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LB_roll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.LB_roll.Location = new System.Drawing.Point(355, 3);
            this.LB_roll.Name = "LB_roll";
            this.LB_roll.Size = new System.Drawing.Size(22, 22);
            this.LB_roll.TabIndex = 13;
            this.LB_roll.Text = "—";
            // 
            // LB_close
            // 
            this.LB_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_close.Font = new System.Drawing.Font("Manrope", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LB_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.LB_close.Location = new System.Drawing.Point(386, 4);
            this.LB_close.Name = "LB_close";
            this.LB_close.Size = new System.Drawing.Size(22, 22);
            this.LB_close.TabIndex = 0;
            this.LB_close.Text = "×";
            // 
            // BTN_30
            // 
            this.BTN_30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.BTN_30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_30.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_30.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_30.Location = new System.Drawing.Point(270, 564);
            this.BTN_30.Name = "BTN_30";
            this.BTN_30.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTN_30.Size = new System.Drawing.Size(120, 52);
            this.BTN_30.TabIndex = 129;
            this.BTN_30.Text = "30";
            this.BTN_30.UseVisualStyleBackColor = false;
            // 
            // BTN_7
            // 
            this.BTN_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.BTN_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_7.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_7.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_7.Location = new System.Drawing.Point(150, 564);
            this.BTN_7.Name = "BTN_7";
            this.BTN_7.Size = new System.Drawing.Size(120, 52);
            this.BTN_7.TabIndex = 132;
            this.BTN_7.Text = "7";
            this.BTN_7.UseVisualStyleBackColor = false;
            // 
            // BTN_1
            // 
            this.BTN_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.BTN_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_1.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.BTN_1.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_1.Location = new System.Drawing.Point(30, 564);
            this.BTN_1.Name = "BTN_1";
            this.BTN_1.Size = new System.Drawing.Size(120, 52);
            this.BTN_1.TabIndex = 131;
            this.BTN_1.Text = "1";
            this.BTN_1.UseVisualStyleBackColor = false;
            // 
            // PN_countDays
            // 
            this.PN_countDays.Controls.Add(this.panel1);
            this.PN_countDays.Location = new System.Drawing.Point(30, 564);
            this.PN_countDays.Name = "PN_countDays";
            this.PN_countDays.Size = new System.Drawing.Size(360, 52);
            this.PN_countDays.TabIndex = 141;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 52);
            this.panel1.TabIndex = 142;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 52);
            this.panel2.TabIndex = 142;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 52);
            this.panel3.TabIndex = 143;
            // 
            // LB_userName
            // 
            this.LB_userName.AutoSize = true;
            this.LB_userName.Font = new System.Drawing.Font("Manrope", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LB_userName.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_userName.Location = new System.Drawing.Point(162, 50);
            this.LB_userName.Margin = new System.Windows.Forms.Padding(0);
            this.LB_userName.Name = "LB_userName";
            this.LB_userName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_userName.Size = new System.Drawing.Size(0, 45);
            this.LB_userName.TabIndex = 142;
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(420, 835);
            this.Controls.Add(this.LB_userName);
            this.Controls.Add(this.header);
            this.Controls.Add(this.DGV_number);
            this.Controls.Add(this.BTN_all);
            this.Controls.Add(this.BTN_signUp);
            this.Controls.Add(this.BTN_registration);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LB_countDays);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_7);
            this.Controls.Add(this.BTN_1);
            this.Controls.Add(this.BTN_30);
            this.Controls.Add(this.BTN_occupied);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_expire);
            this.Controls.Add(this.LB_num);
            this.Controls.Add(this.LB_hi);
            this.Controls.Add(this.LN_header);
            this.Controls.Add(this.BTN_free);
            this.Controls.Add(this.PN_countDays);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Persona";
            this.Load += new System.EventHandler(this.Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_number)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.PN_countDays.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LB_userName;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel PN_countDays;

        private System.Windows.Forms.Button BTN_30;
        private System.Windows.Forms.Button BTN_1;
        private System.Windows.Forms.Button BTN_7;

        private System.Windows.Forms.Label LB_header;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label LB_roll;
        private System.Windows.Forms.Label LB_close;

        private System.Windows.Forms.DataGridView DGV_number;

        private System.Windows.Forms.Button BTN_all;

        private ePOSOne.btnProduct.Button_WOC BTN_signUp;
        private ePOSOne.btnProduct.Button_WOC BTN_registration;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LB_countDays;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_expire;
        private System.Windows.Forms.Label LB_hi;
        private System.Windows.Forms.Button LN_header;
        private System.Windows.Forms.Button BTN_occupied;

        #endregion

        private System.Windows.Forms.Label LB_num;
        private System.Windows.Forms.Button BTN_free;
       
    }
}