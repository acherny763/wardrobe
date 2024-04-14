using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wardrobe
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class RoundButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(grPath);
                base.OnPaint(e);
            }
        }





        private void Btn_log_Click(object sender, EventArgs e)
        {
            RoundButton roundButton1 = new RoundButton();
            roundButton1.Location = new Point(50, 50);
            roundButton1.Size = new Size(100, 100);
            roundButton1.Text = "Round Button";

            this.Controls.Add(roundButton1);
        }


    }
}
