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
            this.BTN_no = new ePOSOne.btnProduct.Button_WOC();
            this.BTN_yes = new ePOSOne.btnProduct.Button_WOC();
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
            // BTN_no
            // 
            this.BTN_no.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.BTN_no.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.BTN_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_no.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.BTN_no.Location = new System.Drawing.Point(189, 56);
            this.BTN_no.Name = "BTN_no";
            this.BTN_no.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.BTN_no.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.BTN_no.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_no.Size = new System.Drawing.Size(96, 45);
            this.BTN_no.TabIndex = 130;
            this.BTN_no.Text = "Отмена";
            this.BTN_no.TextColor = System.Drawing.Color.White;
            this.BTN_no.UseVisualStyleBackColor = true;
            // 
            // BTN_yes
            // 
            this.BTN_yes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_yes.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(241)))));
            this.BTN_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_yes.Font = new System.Drawing.Font("Manrope", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTN_yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.BTN_yes.Location = new System.Drawing.Point(67, 56);
            this.BTN_yes.Name = "BTN_yes";
            this.BTN_yes.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_yes.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.BTN_yes.OnHoverTextColor = System.Drawing.Color.White;
            this.BTN_yes.Size = new System.Drawing.Size(96, 45);
            this.BTN_yes.TabIndex = 129;
            this.BTN_yes.Text = "Выйти";
            this.BTN_yes.TextColor = System.Drawing.Color.White;
            this.BTN_yes.UseVisualStyleBackColor = true;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(360, 125);
            this.Controls.Add(this.BTN_no);
            this.Controls.Add(this.BTN_yes);
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

        private ePOSOne.btnProduct.Button_WOC BTN_no;
        private ePOSOne.btnProduct.Button_WOC BTN_yes;

        private System.Windows.Forms.Label TXT_conf;

        #endregion
    }
}