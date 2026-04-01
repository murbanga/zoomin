using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;

namespace ZoomIn
{
    public partial class ZoomIn : Form
    {
        Point mousePos = new Point(-1, -1);

        Bitmap picture = null;
        Size actualPictureBlock = new Size();


        Size areaAnalyze = new Size();

        int zoom = 2;
        Timer timer = new Timer();
        bool locked = false;

        bool dragging = false;

        Cursor prevCursor = null;

        public ZoomIn()
        {
            InitializeComponent();
            KeyPreview = true;

            comboColorspace.Items.Add(ImageTools.ColorSpace.grayscale);
            comboColorspace.Items.Add(ImageTools.ColorSpace.rgb);
            comboColorspace.Items.Add(ImageTools.ColorSpace.yuv);
            comboColorspace.SelectedItem = ImageTools.ColorSpace.rgb;
        }

        private void ZoomIn_Load(object sender, EventArgs e)
        {
            updatePicture();

            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = !toolDragDrop.Checked;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Point pos = System.Windows.Forms.Cursor.Position;
            if (pos != mousePos || toolRefresh.Checked)
            {
                if (!locked)
                {
                    mousePos = pos;
                }
                updatePicture();
            }
        }

        private void updatePicture()
        {
            try
            {
                Text = string.Format("ZoomIn x{0} {1} ({2}x{3})", zoom, (locked ? "locked" : ""), areaAnalyze.Width, areaAnalyze.Height);
                Rectangle dst = pictureBox.ClientRectangle;
                if (dst.Width > 0 && dst.Height > 0)
                {
                    actualPictureBlock = new Size(dst.Width / zoom, dst.Height / zoom);
                    int sourceX = mousePos.X - dst.Width / 2 / zoom;//Math.Max(mousePos.X - dst.Width / 2 / zoom, 0);
                    int sourceY = mousePos.Y - dst.Height / 2 / zoom;//Math.Max(mousePos.Y - dst.Height / 2 / zoom, 0);

                    if (picture == null || picture.Size != actualPictureBlock)
                    {
                        if (picture != null) picture.Dispose();
                        picture = new Bitmap(actualPictureBlock.Width, actualPictureBlock.Height, PixelFormat.Format32bppArgb);
                    }

                    Graphics g = Graphics.FromImage(picture);
                    g.Clear(Color.Black);
                    g.CopyFromScreen(sourceX, sourceY, 0, 0, actualPictureBlock, CopyPixelOperation.SourceCopy);
                    //pictureBox.Invalidate();
                    picture_Paint(this, null);
                    if ((tabControl1.SelectedTab.Tag as string) == "histogram")
                    {
                        pictureHistogram_Paint(this,
                            new PaintEventArgs(pictureHistogram.CreateGraphics(),
                                pictureHistogram.ClientRectangle));
                    }
                    else if ((tabControl1.SelectedTab.Tag as string) == "dct")
                    {
                        pictureDct_Paint(this, new PaintEventArgs(pictureHistogram.CreateGraphics(),
                                pictureHistogram.ClientRectangle));
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("updatePicture exception {0}", e.ToString());
            }
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            if (picture != null)
            {
                Graphics g;
                if (e != null) g = e.Graphics;
                else g = pictureBox.CreateGraphics();

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(picture, pictureBox.ClientRectangle);
                //g.DrawRectangle(
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            zoom++;
            updatePicture();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            zoom--;
            if (zoom == 0) zoom = 1;
            updatePicture();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            toolButtonTop.Checked = !toolButtonTop.Checked;
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            toolRefresh.Checked = !toolRefresh.Checked;
        }

        private void toolDragDrop_Click(object sender, EventArgs e)
        {
            toolDragDrop.Checked = !toolDragDrop.Checked;
            timer.Enabled = !toolDragDrop.Checked;
        }

        private void ZoomIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Debug.WriteLine("key {0}", (int)e.KeyChar);
            if (e.KeyChar == 32)
            {
                locked = !locked;
                updatePicture();
                e.Handled = true;
            }
        }

        private void pictureHistogram_Paint(object sender, PaintEventArgs e)
        {
            ImageTools.Histogram histogram = new ImageTools.Histogram();
            ImageTools.calcHistogram(picture,
                new Rectangle(0, 0, actualPictureBlock.Width, actualPictureBlock.Height),
                ImageTools.ColorSpace.rgb, ref histogram);

            // TODO: optimize me! do not create bitmap every time.
            Bitmap image = new Bitmap(pictureHistogram.ClientRectangle.Width, pictureHistogram.ClientRectangle.Height);

            ImageTools.drawHistogram(Graphics.FromImage(image), pictureHistogram.ClientRectangle,
                ImageTools.ColorSpace.rgb, histogram, checkLogHistogram.Checked);

            e.Graphics.DrawImage(image, new Point(0, 0));

            image.Dispose();
        }

        private void pictureDct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string[] s = textArea.Text.Split('x');
            if (s.Length == 2)
            {
                int width;
                int height;
                if (int.TryParse(s[0], out width) && int.TryParse(s[1], out height))
                {
                    if (width > 0 && height > 0)
                    {
                        areaAnalyze = new Size(width, height);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("both with and height should be positive");
                        return;
                    }
                }
            }
            MessageBox.Show("area format is %dx%d");
        }

        private void pictureBox_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            Debug.WriteLine("pictureBox_QueryContinueDrag");
        }

        private void ZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("mouse down at {0}x{1}", e.X, e.Y);
            dragging = true;

            Bitmap cursorImage = new Bitmap(actualPictureBlock.Width, actualPictureBlock.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(cursorImage);
            Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
            g.FillRectangle(brush, 0, 0, cursorImage.Width, cursorImage.Height);

            Pen pen0 = new Pen(Color.White);
            pen0.DashPattern = new float[] { 1, 1 };
            g.DrawRectangle(pen0, 0, 0, cursorImage.Width - 1, cursorImage.Height - 1);

            Pen pen1 = new Pen(Color.Black);
            pen1.DashOffset = 1;
            pen1.DashPattern = new float[] { 1, 1 };
            g.DrawRectangle(pen1, 0, 0, cursorImage.Width - 1, cursorImage.Height - 1);

            g.Flush();
            prevCursor = Cursor;
            Cursor = new Cursor(cursorImage.GetHicon());
        }

        private void ZoomIn_MouseUp(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("mouse up at {0}x{1}", e.X, e.Y);
            if (dragging)
            {
                Cursor = prevCursor;
            }
            dragging = false;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Debug.WriteLine("mouse moving {0}x{1}", e.X, e.Y);

                mousePos = System.Windows.Forms.Cursor.Position;
                updatePicture();
            }
        }

        private void checkLogHistogram_CheckedChanged(object sender, EventArgs e)
        {
            updatePicture();
        }

        private void ZoomIn_Resize(object sender, EventArgs e)
        {
            updatePicture();
        }
    }
}
