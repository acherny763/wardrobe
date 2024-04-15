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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Manrope", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.heading.ForeColor = System.Drawing.SystemColors.Window;
            this.heading.Location = new System.Drawing.Point(20, 20);
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
            this.TB_login.Font = new System.Drawing.Font("Manrope SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(134)))));
            this.TB_login.Location = new System.Drawing.Point(50, 103);
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
            this.TB_pass.Font = new System.Drawing.Font("Manrope SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(125)))), ((int)(((byte)(134)))));
            this.TB_pass.Location = new System.Drawing.Point(50, 169);
            this.TB_pass.Margin = new System.Windows.Forms.Padding(20);
            this.TB_pass.MaxLength = 20;
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(320, 26);
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
            this.BTN_log.Location = new System.Drawing.Point(30, 230);
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
            this.BTN_reg.Location = new System.Drawing.Point(30, 297);
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
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(29, 89);
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
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(30, 155);
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
            this.pictureBox1.Location = new System.Drawing.Point(345, 104);
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
            this.pictureBox2.Location = new System.Drawing.Point(345, 170);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(420, 383);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Гардероб ТПК";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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

