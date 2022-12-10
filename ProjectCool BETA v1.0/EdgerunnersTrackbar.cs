using System;
using System.Drawing;
using System.Windows.Forms;
namespace ProgressBar_test
{
    public class EdgerunnersTrackbar : System.Windows.Forms.PictureBox
        {

            private static readonly object EVENT_SCROLL = new object();
            private static readonly object EVENT_VALUECHANGED = new object();
        
            private int iterator = 5;
            private int maximum = 10;
            private int minimum = 0;
            private int _value = 0;



            public EdgerunnersTrackbar()
            {
                this.Size = new Size(100, 40);
                this.BackColor = Color.Transparent;
                this.RenderChart();
            }

            public int Minimum
            {
                get { return minimum; }
                set { minimum = this.constrain(value, 0, maximum - 1); this.RenderChart(); }
            }

            public int Maximum
            {
                get { return maximum; }
                set { if (value <= minimum) { maximum = value + 1; } else maximum = value; }
            }

            public int Value
            {
                get { return _value; }
                set { _value = this.constrain(value, minimum, maximum); this.RenderChart(); }
            }

            public int Iterator
            {
                get { return iterator; }
                set { iterator = this.constrain(value, 0, maximum);}
            }

            private int map(int x, int in_min, int in_max, int out_min, int out_max)
            {
                return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min;
            }

            private int constrain(int x, int a, int b) {
                if(x<a) {
                    return a;
                }
                else if(b<x) {
                    return b;
                }
                else
                return x;
                }

            private void RenderChart()
            {
                Pen outline = new Pen(Color.FromArgb(255, 211, 98, 98));
                System.Drawing.SolidBrush bar = new SolidBrush(Color.FromArgb(255, 211, 132, 132));
                Bitmap Chart = new Bitmap(this.Width, this.Height);
                using (Graphics formGraphics = Graphics.FromImage(Chart))
                {
                    formGraphics.DrawRectangle(outline, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                    formGraphics.FillRectangle(bar, new Rectangle(4, 3, map(_value, 0, maximum, 0, this.Width - 7), this.Height - 6));
                    outline.Dispose();
                    bar.Dispose();
                    formGraphics.Dispose();
                }
            this.Image = Chart;
            }

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                this.RenderChart();
            }

            //method mouse enter  
            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
            }
            //method mouse leave  
            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
            }

            protected override void OnMouseDown(MouseEventArgs mevent)
            {
                base.OnMouseDown(mevent);
                this.Invalidate();
            }

            protected override void OnMouseUp(MouseEventArgs mevent)
            {
                base.OnMouseUp(mevent);
                OnMouseLeave(mevent);
                this.Invalidate();
            }

            protected override void OnLostFocus(EventArgs e)
            {
                base.OnLostFocus(e);
                this.Invalidate();
            }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            _value = this.map(e.Location.X, 0, this.Size.Width, minimum, maximum);
            RenderChart();
        }
        protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
            }

            protected override void OnMouseWheel(MouseEventArgs e)
            {
                base.OnMouseWheel(e);

                HandledMouseEventArgs hme = e as HandledMouseEventArgs;
                if (hme != null)
                {
                    if (hme.Handled)
                    {
                        return;
                    }
                    hme.Handled = true;
                }

                if ((ModifierKeys & (Keys.Shift | Keys.Alt)) != 0 || MouseButtons != MouseButtons.None)
                {
                    return; // Do not scroll when Shift or Alt key is down, or when a mouse button is down.
                }

                int wheelScrollLines = SystemInformation.MouseWheelScrollLines;
                if (wheelScrollLines == 0)
                {
                    return; // Do not scroll when the user system setting is 0 lines per notch
                }

                int increment_temp = (e.Delta * SystemInformation.MouseWheelScrollLines);
                //MAgic
                if (increment_temp > 0)
                {
                    _value = constrain(_value += iterator, minimum, maximum);
                    RenderChart();
                }
                else
                    if (increment_temp < 0)
                {
                    _value = constrain(_value -= iterator, minimum, maximum);
                    RenderChart();
                }
            }
        }
}
