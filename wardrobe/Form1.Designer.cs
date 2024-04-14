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
            this.BTN_log = new System.Windows.Forms.Button();
            this.BTN_reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_login = new System.Windows.Forms.TextBox();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_log
            // 
            this.BTN_log.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BTN_log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_log.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTN_log.FlatAppearance.BorderSize = 0;
            this.BTN_log.Location = new System.Drawing.Point(34, 217);
            this.BTN_log.Name = "BTN_log";
            this.BTN_log.Size = new System.Drawing.Size(208, 34);
            this.BTN_log.TabIndex = 0;
            this.BTN_log.Text = "Войти";
            this.BTN_log.UseCompatibleTextRendering = true;
            this.BTN_log.UseVisualStyleBackColor = false;
            this.BTN_log.Click += new System.EventHandler(this.Btn_log_Click);
            // 
            // BTN_reg
            // 
            this.BTN_reg.BackColor = System.Drawing.SystemColors.WindowText;
            this.BTN_reg.ForeColor = System.Drawing.SystemColors.Window;
            this.BTN_reg.Location = new System.Drawing.Point(34, 257);
            this.BTN_reg.Name = "BTN_reg";
            this.BTN_reg.Size = new System.Drawing.Size(208, 34);
            this.BTN_reg.TabIndex = 1;
            this.BTN_reg.Text = "Зарегистрироваться";
            this.BTN_reg.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // TB_login
            // 
            this.TB_login.Location = new System.Drawing.Point(34, 87);
            this.TB_login.MaxLength = 25;
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(208, 20);
            this.TB_login.TabIndex = 3;
            this.TB_login.Text = "Логин";
            // 
            // TB_pass
            // 
            this.TB_pass.Location = new System.Drawing.Point(34, 133);
            this.TB_pass.MaxLength = 20;
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(208, 20);
            this.TB_pass.TabIndex = 4;
            this.TB_pass.Text = "Пароль";
            this.TB_pass.TextChanged += new System.EventHandler(this.TB_pass_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(301, 341);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_reg);
            this.Controls.Add(this.BTN_log);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Гардероб ТПК";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button BTN_log;
        private System.Windows.Forms.Button BTN_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.TextBox TB_pass;

    }
}

