using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ZoomIn
{
    class ImageTools
    {
        public enum ColorSpace { grayscale, rgb, yuv };
        
        delegate float scale(float x);

        public class Histogram
        {
            public Histogram()
            {
                a = new int[3, 256];
                min = int.MaxValue;
                max = int.MinValue;
            }

            public int[,] a;
            public int min;
            public int max;
        };

        public static void calcHistogram(Bitmap image, Rectangle rect, ColorSpace colorspace, ref Histogram hist)
        {
            BitmapData data = image.LockBits(rect,
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            IntPtr p = data.Scan0;
            int stride = data.Stride;
            int bytes = stride * rect.Height;

            byte[] rgbbuf = null;
            int bufsize = 0;

            if (rgbbuf == null || bufsize < bytes)
            {
                rgbbuf = new byte[bytes];
                bufsize = bytes;
            }

            System.Runtime.InteropServices.Marshal.Copy(p, rgbbuf, 0, bytes);
            image.UnlockBits(data);

            for (int y = 0; y < rect.Height; ++y)
                for (int x = 0; x < rect.Width; ++x)
                {
                    int idx = x * 4 + y * stride;
                    int r = rgbbuf[idx + 0];
                    int g = rgbbuf[idx + 1];
                    int b = rgbbuf[idx + 2];

                    hist.a[0, r]++;
                    hist.a[1, g]++;
                    hist.a[2, b]++;
                }

            for (int i = 0; i < hist.a.GetLength(0); ++i)
                for (int j = 0; j < hist.a.GetLength(1); ++j)
                {
                    hist.min = Math.Min(hist.min, hist.a[i, j]);
                    hist.max = Math.Max(hist.max, hist.a[i, j]);
                }
        }

        public static void drawHistogram(Graphics g, Rectangle r, ColorSpace colorspace,
            Histogram hist, bool logscale)
        {
            scale scale;
            if (logscale)
                scale = x => (x == 0 ? 0 : (float)Math.Log(x));
            else
                scale = x => x;

            g.FillRectangle(Brushes.White, r);

            SizeF stringSize = g.MeasureString("0000", SystemFonts.DefaultFont);

            float xmargin = stringSize.Width;
            float ymargin = stringSize.Height;

            float xscale = (r.Width - xmargin) / 256f;
            float yscale = (float)(r.Height - ymargin) / scale(hist.max);
            Pen[] pen = new Pen[] { Pens.Red, Pens.Green, Pens.Blue };

            for (int c = 0; c < 3; ++c)
            {
                PointF[] curve = new PointF[256];
                for (int i = 0; i < 256; ++i)
                {
                    curve[i].X = xmargin + i * xscale;
                    curve[i].Y = r.Height - ymargin - scale(hist.a[c, i]) * yscale;
                }
                g.DrawLines(pen[c], curve);
            }
        }

        static void dct2(byte[] p, int offset, int width, int height, int stride, ref byte[] f, ref double[] interm)
        {
            for (int y = 0; y < height; ++y)
            {
                for (int x = 1; x < width - 1; ++x)
                {
                    double X = (p[offset + y * stride] + p[offset + y * stride + width - 1]) / 2;
                    X += p[offset + y * stride + x] * Math.Cos(Math.PI / (width - 1) * x * y);
                }
            }
        }

        static void dct2_rgb(byte[] p, int width, int height, int stride, out byte[] f)
        {
            f = new byte[width * height * 3];
            float[] interm = new float[width * height];

        }

        public static Bitmap calcDct(Bitmap image, Rectangle rect, ColorSpace colorspace)
        {
            BitmapData data = image.LockBits(rect,
               ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            IntPtr p = data.Scan0;
            int stride = data.Stride;
            int bytes = stride * rect.Height;

            byte[] rgbbuf = null;
            int bufsize = 0;

            if (rgbbuf == null || bufsize < bytes)
            {
                rgbbuf = new byte[bytes];
                bufsize = bytes;
            }

            System.Runtime.InteropServices.Marshal.Copy(p, rgbbuf, 0, bytes);
            image.UnlockBits(data);

            if (colorspace == ColorSpace.yuv)
            {
            }

            byte[] fbuf;
            dct2_rgb(rgbbuf, rect.Width, rect.Height, stride, out fbuf);

            return null;
        }
    }
}
