namespace wardrobe
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TB_search = new System.Windows.Forms.TextBox();
            this.PN_search = new System.Windows.Forms.Panel();
            this.LB_close = new System.Windows.Forms.Label();
            this.LB_header = new System.Windows.Forms.Label();
            this.LB_roll = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.BTN_search = new System.Windows.Forms.Button();
            this.LN_header = new System.Windows.Forms.Button();
            this.BTN_free = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.DGV_user = new System.Windows.Forms.DataGridView();
            this.TB_delete = new ePOSOne.btnProduct.Button_WOC();
            this.button7 = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_user)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_search
            // 
            this.TB_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.TB_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(134)))));
            this.TB_search.Location = new System.Drawing.Point(60, 86);
            this.TB_search.Margin = new System.Windows.Forms.Padding(20);
            this.TB_search.MaxLength = 25;
            this.TB_search.Name = "TB_search";
            this.TB_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_search.Size = new System.Drawing.Size(320, 22);
            this.TB_search.TabIndex = 13;
            this.TB_search.Text = "Логин";
            this.TB_search.TextChanged += new System.EventHandler(this.TB_login_TextChanged);
            // 
            // PN_search
            // 
            this.PN_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.PN_search.Location = new System.Drawing.Point(30, 72);
            this.PN_search.Name = "PN_search";
            this.PN_search.Size = new System.Drawing.Size(1488, 56);
            this.PN_search.TabIndex = 15;
            // 
            // LB_close
            // 
            this.LB_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LB_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.LB_close.Location = new System.Drawing.Point(1498, 10);
            this.LB_close.Name = "LB_close";
            this.LB_close.Size = new System.Drawing.Size(22, 22);
            this.LB_close.TabIndex = 0;
            this.LB_close.Text = "×";
            // 
            // LB_header
            // 
            this.LB_header.AutoSize = true;
            this.LB_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LB_header.ForeColor = System.Drawing.SystemColors.Window;
            this.LB_header.Location = new System.Drawing.Point(10, 10);
            this.LB_header.Margin = new System.Windows.Forms.Padding(0);
            this.LB_header.Name = "LB_header";
            this.LB_header.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_header.Size = new System.Drawing.Size(122, 18);
            this.LB_header.TabIndex = 12;
            this.LB_header.Text = "Гардероб ТПК";
            // 
            // LB_roll
            // 
            this.LB_roll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LB_roll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.LB_roll.Location = new System.Drawing.Point(1467, 9);
            this.LB_roll.Name = "LB_roll";
            this.LB_roll.Size = new System.Drawing.Size(22, 22);
            this.LB_roll.TabIndex = 13;
            this.LB_roll.Text = "—";
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
            this.header.Size = new System.Drawing.Size(1532, 42);
            this.header.TabIndex = 16;
            // 
            // BTN_search
            // 
            this.BTN_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.BTN_search.FlatAppearance.BorderSize = 0;
            this.BTN_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_search.Image = ((System.Drawing.Image)(resources.GetObject("BTN_search.Image")));
            this.BTN_search.Location = new System.Drawing.Point(1470, 86);
            this.BTN_search.Name = "BTN_search";
            this.BTN_search.Size = new System.Drawing.Size(25, 25);
            this.BTN_search.TabIndex = 17;
            this.BTN_search.UseVisualStyleBackColor = false;
            // 
            // LN_header
            // 
            this.LN_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.LN_header.FlatAppearance.BorderSize = 0;
            this.LN_header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LN_header.Location = new System.Drawing.Point(0, 155);
            this.LN_header.Name = "LN_header";
            this.LN_header.Size = new System.Drawing.Size(1548, 1);
            this.LN_header.TabIndex = 124;
            this.LN_header.UseVisualStyleBackColor = false;
            // 
            // BTN_free
            // 
            this.BTN_free.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_free.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.BTN_free.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_free.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_free.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_free.Location = new System.Drawing.Point(30, 183);
            this.BTN_free.Name = "BTN_free";
            this.BTN_free.Size = new System.Drawing.Size(155, 40);
            this.BTN_free.TabIndex = 125;
            this.BTN_free.Text = "Номер\r\n";
            this.BTN_free.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(191, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 126;
            this.button1.Text = "Группа";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(334, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 40);
            this.button2.TabIndex = 127;
            this.button2.Text = "Фамилия";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(505, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 40);
            this.button3.TabIndex = 128;
            this.button3.Text = "Имя";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(651, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 40);
            this.button4.TabIndex = 129;
            this.button4.Text = "Отчество";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(1097, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(264, 40);
            this.button5.TabIndex = 130;
            this.button5.Text = "Дата окончания номера\r\n";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Location = new System.Drawing.Point(857, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(234, 40);
            this.button6.TabIndex = 131;
            this.button6.Text = "Дата взятия номера";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // DGV_user
            // 
            this.DGV_user.AllowUserToAddRows = false;
            this.DGV_user.AllowUserToDeleteRows = false;
            this.DGV_user.AllowUserToResizeColumns = false;
            this.DGV_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DGV_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_user.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.DGV_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_user.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_user.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_user.EnableHeadersVisualStyles = false;
            this.DGV_user.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DGV_user.Location = new System.Drawing.Point(0, 250);
            this.DGV_user.MultiSelect = false;
            this.DGV_user.Name = "DGV_user";
            this.DGV_user.ReadOnly = true;
            this.DGV_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGV_user.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_user.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DGV_user.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_user.ShowCellErrors = false;
            this.DGV_user.ShowCellToolTips = false;
            this.DGV_user.ShowEditingIcon = false;
            this.DGV_user.ShowRowErrors = false;
            this.DGV_user.Size = new System.Drawing.Size(1548, 647);
            this.DGV_user.TabIndex = 140;
            this.DGV_user.TabStop = false;
            // 
            // TB_delete
            // 
            this.TB_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.TB_delete.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.TB_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TB_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TB_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TB_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.TB_delete.Location = new System.Drawing.Point(1367, 183);
            this.TB_delete.Name = "TB_delete";
            this.TB_delete.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.TB_delete.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.TB_delete.OnHoverTextColor = System.Drawing.Color.White;
            this.TB_delete.Size = new System.Drawing.Size(134, 45);
            this.TB_delete.TabIndex = 141;
            this.TB_delete.Text = "Снять бронь";
            this.TB_delete.TextColor = System.Drawing.Color.White;
            this.TB_delete.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 249);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(1548, 1);
            this.button7.TabIndex = 142;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1532, 858);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.TB_delete);
            this.Controls.Add(this.DGV_user);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_free);
            this.Controls.Add(this.LN_header);
            this.Controls.Add(this.BTN_search);
            this.Controls.Add(this.header);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.PN_search);
            this.Name = "admin";
            this.Text = "Гардероб ТПК";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button7;

        private ePOSOne.btnProduct.Button_WOC TB_delete;

        private System.Windows.Forms.DataGridView DGV_user;

        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button BTN_free;

        private System.Windows.Forms.Button LN_header;

        private System.Windows.Forms.Button BTN_search;

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label LB_roll;
        private System.Windows.Forms.Label LB_header;
        private System.Windows.Forms.Label LB_close;

        private System.Windows.Forms.TextBox TB_search;
        private System.Windows.Forms.Panel PN_search;

        #endregion
    }
}