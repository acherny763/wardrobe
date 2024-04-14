using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wardrobe
{
    public partial class persona : Form
    {
        public persona()
        {
            InitializeComponent();
            //pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Создаем объект Graphics из элемента PictureBox
            Graphics g = e.Graphics;

            // Создаем перо для рисования линии
            Pen pen = new Pen(Color.Black);

            // Рисуем линию от точки (10, 10) до точки (200, 200)
            g.DrawLine(pen, 10, 10, 200, 200);

            // Освобождаем ресурсы
            pen.Dispose();
            g.Dispose();
        }

    }
}
