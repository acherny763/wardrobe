using System.ComponentModel;

namespace wardrobe
{
    partial class ConfirmationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.TXT_conf = new System.Windows.Forms.Label();
            this.BTN_reg = new ePOSOne.btnProduct.Button_WOC();
            this.BTN_log = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // TXT_conf
            // 
            this.TXT_conf.AutoSize = true;
            this.TXT_conf.Font = new System.Drawing.Font("Manrope", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TXT_conf.ForeColor = System.Drawing.SystemColors.Window;
            this.TXT_conf.Location = new System.Drawing.Point(31, 23);
            this.TXT_conf.Margin = new System.Windows.Forms.Padding(0);
            this.TXT_conf.Name = "TXT_conf";
            this.TXT_conf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXT_conf.Size = new System.Drawing.Size(301, 26);
            this.TXT_conf.TabIndex = 128;
            this.TXT_conf.Text = "Вы точно хотите снять бронь?";
            // 
            // BTN_reg
            // 
            this.BTN_reg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.BTN_reg.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BTN_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_reg.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_reg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.BTN_reg.Location = new System.Drawing.Point(189, 56);
            this.BTN_reg.Name = "BTN_reg";
            this.BTN_reg.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.BTN_reg.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BTN_reg.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_reg.Size = new System.Drawing.Size(96, 45);
            this.BTN_reg.TabIndex = 130;
            this.BTN_reg.Text = "Отмена";
            this.BTN_reg.TextColor = System.Drawing.Color.White;
            this.BTN_reg.UseVisualStyleBackColor = true;
            // 
            // BTN_log
            // 
            this.BTN_log.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_log.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_log.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.BTN_log.Location = new System.Drawing.Point(67, 56);
            this.BTN_log.Name = "BTN_log";
            this.BTN_log.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_log.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_log.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_log.Size = new System.Drawing.Size(96, 45);
            this.BTN_log.TabIndex = 129;
            this.BTN_log.Text = "Выйти";
            this.BTN_log.TextColor = System.Drawing.Color.White;
            this.BTN_log.UseVisualStyleBackColor = true;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(360, 125);
            this.Controls.Add(this.BTN_reg);
            this.Controls.Add(this.BTN_log);
            this.Controls.Add(this.TXT_conf);
            this.Font = new System.Drawing.Font("Manrope", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ConfirmationForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private ePOSOne.btnProduct.Button_WOC BTN_reg;
        private ePOSOne.btnProduct.Button_WOC BTN_log;

        private System.Windows.Forms.Label TXT_conf;

        #endregion
    }
}