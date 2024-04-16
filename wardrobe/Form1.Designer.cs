using System.Drawing;
using System.Windows.Forms;
using wardrobe;

namespace wardrobe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heading = new System.Windows.Forms.Label();
            this.TB_login = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.BTN_log = new ePOSOne.btnProduct.Button_WOC();
            this.BTN_reg = new ePOSOne.btnProduct.Button_WOC();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LB_close = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.LB_roll = new System.Windows.Forms.Label();
            this.LB_header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Manrope", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.heading.ForeColor = System.Drawing.SystemColors.Window;
            this.heading.Location = new System.Drawing.Point(22, 61);
            this.heading.Margin = new System.Windows.Forms.Padding(0);
            this.heading.Name = "heading";
            this.heading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.heading.Size = new System.Drawing.Size(229, 44);
            this.heading.TabIndex = 2;
            this.heading.Text = "Авторизация";
            // 
            // TB_login
            // 
            this.TB_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.TB_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_login.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(134)))));
            this.TB_login.Location = new System.Drawing.Point(52, 144);
            this.TB_login.Margin = new System.Windows.Forms.Padding(20);
            this.TB_login.MaxLength = 25;
            this.TB_login.Name = "TB_login";
            this.TB_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TB_login.Size = new System.Drawing.Size(320, 26);
            this.TB_login.TabIndex = 3;
            this.TB_login.Text = "Логин";
            this.TB_login.Click += new System.EventHandler(this.TB_login_Click);
            this.TB_login.TextChanged += new System.EventHandler(this.TB_login_TextChanged);
            this.TB_login.Enter += new System.EventHandler(this.TB_login_Enter);
            this.TB_login.Leave += new System.EventHandler(this.TB_login_Leave);
            // 
            // TB_pass
            // 
            this.TB_pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.TB_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.TB_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(134)))));
            this.TB_pass.Location = new System.Drawing.Point(52, 210);
            this.TB_pass.Margin = new System.Windows.Forms.Padding(20);
            this.TB_pass.MaxLength = 20;
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(320, 25);
            this.TB_pass.TabIndex = 4;
            this.TB_pass.Text = "Пароль";
            this.TB_pass.Click += new System.EventHandler(this.TB_pass_Click);
            this.TB_pass.Enter += new System.EventHandler(this.TB_pass_Enter);
            this.TB_pass.Leave += new System.EventHandler(this.TB_pass_Leave);
            // 
            // BTN_log
            // 
            this.BTN_log.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_log.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.BTN_log.Location = new System.Drawing.Point(32, 271);
            this.BTN_log.Name = "BTN_log";
            this.BTN_log.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_log.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_log.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_log.Size = new System.Drawing.Size(360, 56);
            this.BTN_log.TabIndex = 5;
            this.BTN_log.Text = "Войти";
            this.BTN_log.TextColor = System.Drawing.Color.White;
            this.BTN_log.UseVisualStyleBackColor = true;
            this.BTN_log.Click += new System.EventHandler(this.BTN_log_Click);
            // 
            // BTN_reg
            // 
            this.BTN_reg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.BTN_reg.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BTN_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.BTN_reg.Location = new System.Drawing.Point(32, 338);
            this.BTN_reg.Name = "BTN_reg";
            this.BTN_reg.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.BTN_reg.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BTN_reg.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_reg.Size = new System.Drawing.Size(360, 56);
            this.BTN_reg.TabIndex = 6;
            this.BTN_reg.Text = "Зарегистрироваться";
            this.BTN_reg.TextColor = System.Drawing.Color.White;
            this.BTN_reg.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(31, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(20);
            this.textBox1.MaxLength = 25;
            this.textBox1.MinimumSize = new System.Drawing.Size(360, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(360, 56);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(32, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(20, 15, 0, 16);
            this.textBox2.MaxLength = 20;
            this.textBox2.MinimumSize = new System.Drawing.Size(360, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(360, 56);
            this.textBox2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(347, 145);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(347, 211);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
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
            this.LB_close.Click += new System.EventHandler(this.LB_close_Click);
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
            this.header.TabIndex = 11;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSignIn_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSignIn_MouseMove);
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
            this.LB_roll.Click += new System.EventHandler(this.LB_roll_Click);
            // 
            // LB_header
            // 
            this.LB_header.AutoSize = true;
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(420, 423);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_reg);
            this.Controls.Add(this.BTN_log);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.heading);
            this.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Гардероб ТПК";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LB_roll;

        private System.Windows.Forms.Label LB_header;

        private System.Windows.Forms.Label LB_close;

        private System.Windows.Forms.Panel header;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;

        private ePOSOne.btnProduct.Button_WOC BTN_reg;

        private ePOSOne.btnProduct.Button_WOC BTN_log;

        #endregion

        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.TextBox TB_pass;

    }
}

