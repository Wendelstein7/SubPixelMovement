using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubPixelMovement
{
    public partial class Form1 : Form
    {

        private static Color backColor;
        private static Pen normalPen;
        private static Pen[,] subPens;
        private static Pen[,] subPensHalf;
        private static Pen[] subPensSingle;
        private static Pen grayPen;

        private static int step = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void generatePens()
        {
            if (!checkBoxInvert.Checked)
            {
                backColor = Color.FromArgb(0, 0, 0);

                normalPen = new Pen(Color.FromArgb(255, 255, 255));

                subPens = new Pen[,]
                {
                    {new Pen(Color.FromArgb(255, 255, 255)), new Pen(Color.FromArgb(0, 0, 0))},
                    {new Pen(Color.FromArgb(0, 255, 255)), new Pen(Color.FromArgb(255, 0, 0))},
                    {new Pen(Color.FromArgb(0, 0, 255)), new Pen(Color.FromArgb(255, 255, 0))},
                };

                subPensHalf = new Pen[,]
                {
                    {new Pen(Color.FromArgb(127, 255, 255)), new Pen(Color.FromArgb(127, 0, 0))},
                    {new Pen(Color.FromArgb(0, 127, 255)), new Pen(Color.FromArgb(255, 127, 0))},
                    {new Pen(Color.FromArgb(0, 0, 127)), new Pen(Color.FromArgb(255, 255, 127))},
                };

                subPensSingle = new Pen[]
                {
                    new Pen(Color.FromArgb(255, 0, 0)),
                    new Pen(Color.FromArgb(0, 255, 0)),
                    new Pen(Color.FromArgb(0, 0, 255))
                };

                grayPen = new Pen(Color.FromArgb(127, 127, 127));
            }
            else
            {
                backColor = Color.FromArgb( 255,255,255 );

                normalPen = new Pen( Color.FromArgb( 0, 0, 0 ) );

                subPens = new Pen[,]
                {
                    {new Pen(Color.FromArgb(0, 0, 0)), new Pen(Color.FromArgb(255, 255, 255))},
                    {new Pen(Color.FromArgb(255, 0, 0)), new Pen(Color.FromArgb(0, 255, 255))},
                    {new Pen(Color.FromArgb(255, 255, 0)), new Pen(Color.FromArgb(0, 0, 255))},
                };

                subPensHalf = new Pen[,]
                {
                    {new Pen(Color.FromArgb(127, 0, 0)), new Pen(Color.FromArgb(127, 255, 255))},
                    {new Pen(Color.FromArgb(255, 127, 0)), new Pen(Color.FromArgb(0, 127, 255))},
                    {new Pen(Color.FromArgb(255, 255, 127)), new Pen(Color.FromArgb(0, 0, 127))},
                };

                subPensSingle = new Pen[]
                {
                    new Pen(Color.FromArgb(0, 255, 255)),
                    new Pen(Color.FromArgb(255, 0, 255)),
                    new Pen(Color.FromArgb(255, 255, 0))
                };

                grayPen = new Pen( Color.FromArgb( 127, 127, 127 ) );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generatePens();

            timerMain.Enabled = true;
        }

        private void draw(Graphics graphics)
        {
            int rx = pictureBox.Width;
            int ry = pictureBox.Height;

            int[] ypts = {0, ry / 4, ry / 2, ry / 4 * 3, ry};

            graphics.Clear(backColor);

            graphics.DrawLine(normalPen, step / 3, ypts[0], step / 3, ypts[1] - 1);

            graphics.DrawLine(subPens[step % 3, 0], (step / 3) + 0, ypts[1], (step / 3) + 0, ypts[2] - 1);
            graphics.DrawLine(subPens[step % 3, 1], (step / 3) + 1, ypts[1], (step / 3) + 1, ypts[2] - 1);

            graphics.DrawLine(subPensHalf[step % 3, 0], (step / 3) + 0, ypts[2], (step / 3) + 0, ypts[3] - 1);
            graphics.DrawLine(subPensHalf[step % 3, 1], (step / 3) + 1, ypts[2], (step / 3) + 1, ypts[3] - 1);

            graphics.DrawLine(subPensSingle[step % 3], (step / 3), ypts[3], (step / 3), ypts[4] - 1);

            if (checkBoxSeperators.Checked)
                foreach (int ypt in ypts)
                    graphics.DrawLine(grayPen, 0, ypt, rx, ypt);
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            step++;
            step %= pictureBox.Width * 3;

            pictureBox.Invalidate();

            labelValues.Text = string.Format("Frame: {0}; Pixel: {1}; Sub: {2}; target fps: {3}", step.ToString("0000"), (step / 3).ToString("0000"), (step % 3).ToString("0"), (1000 / timerMain.Interval).ToString("0000"));
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            checkBoxTurbo.Checked = false;
            timerMain.Interval = 1000 / trackBarSpeed.Value;
        }

        private void checkBoxRun_CheckedChanged(object sender, EventArgs e)
        {
            timerMain.Enabled = checkBoxRun.Checked;
        }

        private void checkBoxTurbo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTurbo.Checked)
                timerMain.Interval = 1;
            else
                trackBarSpeed_Scroll(sender, e);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            draw(e.Graphics);
        }

        private void checkBoxInvert_CheckedChanged(object sender, EventArgs e)
        {
            generatePens();
        }

        private void linkLabelWiki_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            System.Diagnostics.Process.Start( @"https://en.wikipedia.org/wiki/Subpixel_rendering#Example_with_the_common_RGB_stripes_layout" );
        }
    }
}