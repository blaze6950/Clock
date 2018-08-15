using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    #region Enum's
    enum ClockStyle
    {
        Standart,
        Classic
    }
    enum HandStyle
    {
        Uniform,
        Sharp
    }
    enum Ticks
    {
        All,
        Twelve,
        Quadrick,
        None
    }
    enum Date
    {
        Full,
        DayOfMonth,
        None
    }
    enum Numbers
    {
        All,
        Quadrick,
        None
    }
    #endregion

    public partial class ClockForm : Form
    {
        private ClockStyle _clockStyle = ClockStyle.Standart;
        private HandStyle _handStyle = HandStyle.Uniform;
        private Ticks _ticks = Ticks.All;
        private Date _date = Date.Full;
        private Numbers _numbers = Numbers.All;
        private Color _innerColor = Color.Aquamarine, _outerColor = Color.Aqua, _handColor = Color.Black, _secHandColor = Color.Red, _tickColor = Color.Black, _textColor = Color.Black;
        private String _caption;

        private void standartRB_CheckedChanged(object sender, EventArgs e)
        {
            if (standartRB.Checked)
            {
                _clockStyle = ClockStyle.Standart;
            }
            else
            {
                _clockStyle = ClockStyle.Classic;
            }
        }

        private void uniformRB_CheckedChanged(object sender, EventArgs e)
        {
            if (uniformRB.Checked)
            {
                _handStyle = HandStyle.Uniform;
            }
            else
            {
                _handStyle = HandStyle.Sharp;
            }
        }

        private void innerColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _innerColor = colorDialog.Color;
        }

        private void outerColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _outerColor = colorDialog.Color;
        }

        private void habdColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _handColor = colorDialog.Color;
        }

        private void secHandColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _secHandColor = colorDialog.Color;
        }

        private void tickColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _tickColor = colorDialog.Color;
        }

        private void ticksCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ticks = (Ticks) ticksCB.SelectedIndex;
            timer_Tick(null, null);
        }

        private void dateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _date = (Date) dateCB.SelectedIndex;
            timer_Tick(null, null);
        }

        private void numbersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _numbers = (Numbers) numbersCB.SelectedIndex;
            timer_Tick(null, null);
        }

        private void captionTB_TextChanged(object sender, EventArgs e)
        {
            _caption = captionTB.Text;
        }

        private void textColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _textColor = colorDialog.Color;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.InvokePaint(panel, new PaintEventArgs(Graphics.FromHwnd(panel.Handle), new Rectangle(panel.Location.X, panel.Location.Y, panel.Size.Width, panel.Size.Height)));
        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        public ClockForm()
        {
            InitializeComponent();
            for (int i = 0; i < 4; i++)
            {
                ticksCB.Items.Add((Ticks)i);
            }
            ticksCB.SelectedIndex = 0;

            for (int i = 0; i < 3; i++)
            {
                dateCB.Items.Add((Date)i);
            }
            dateCB.SelectedIndex = 0;

            for (int i = 0; i < 3; i++)
            {
                numbersCB.Items.Add((Numbers)i);
            }
            numbersCB.SelectedIndex = 0;
            DoubleBuffered = true;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            var gOne = e.Graphics;
            BufferedGraphicsContext CurrentContext = BufferedGraphicsManager.Current;
            BufferedGraphics g = CurrentContext.Allocate(gOne, ClientRectangle);
            g.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            g.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.Graphics.Clear(panel.BackColor);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            var Ox = panel.Width / 2;
            var Oy = panel.Height / 2;
            int sideSquare;
            if (panel.Width > panel.Height)
            {
                sideSquare = panel.Height;
            }
            else
            {
                sideSquare = panel.Width;
            }


            #region DrawEllipse
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(panel.Width / 20, panel.Height / 20, panel.Width - (panel.Width / 20) * 2, panel.Height - (panel.Height / 20) * 2));
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterColor = _innerColor;
            Color[] colors = { _outerColor };
            pthGrBrush.SurroundColors = colors;
            g.Graphics.FillEllipse(pthGrBrush, new Rectangle(panel.Width / 20, panel.Height / 20, panel.Width - (panel.Width / 20) * 2, panel.Height - (panel.Height / 20) * 2));
            #endregion

            #region DrawTicks
            g.Graphics.DrawEllipse(new Pen(_tickColor), new Rectangle(panel.Width / 20, panel.Height / 20, panel.Width - (panel.Width / 20) * 2, panel.Height - (panel.Height / 20) * 2));
            g.Graphics.TranslateTransform(Ox, Oy);
            switch (_ticks)
            {
                case Ticks.All:
                    for (int i = 0; i < 4; i++)
                    {
                        g.Graphics.DrawLine(new Pen(_tickColor, 6), new Point((panel.Width / 2 - panel.Width / 20) * -1, 0), new Point((panel.Width / 2 - panel.Width / 20) * -1 + 13, 0));
                        for (int j = 0; j < 15; j++)
                        {
                            g.Graphics.DrawLine(new Pen(_tickColor, 1), new Point((panel.Width / 2 - panel.Width / 20) * -1, 0), new Point((panel.Width / 2 - panel.Width / 20) * -1 + 9, 0));
                            if (j % 5 == 0)
                                g.Graphics.DrawLine(new Pen(_tickColor, 4), new Point((panel.Width / 2 - panel.Width / 20) * -1, 0), new Point((panel.Width / 2 - panel.Width / 20) * -1 + 13, 0));
                            g.Graphics.RotateTransform(6);
                        }
                    }
                    break;
                case Ticks.Twelve:
                    for (int i = 0; i < 4; i++)
                    {
                        g.Graphics.DrawLine(new Pen(_tickColor, 6), new Point((panel.Width / 2 - panel.Width / 20) * -1, 0), new Point((panel.Width / 2 - panel.Width / 20) * -1 + 13, 0));
                        for (int j = 0; j < 3; j++)
                        {
                            g.Graphics.DrawLine(new Pen(_tickColor, 4), new Point((panel.Width / 2 - panel.Width / 20) * -1, 0), new Point((panel.Width / 2 - panel.Width / 20) * -1 + 13, 0));
                            g.Graphics.RotateTransform(30);
                        }
                    }
                    break;
                case Ticks.Quadrick:
                    for (int i = 0; i < 4; i++)
                    {
                        g.Graphics.DrawLine(new Pen(_tickColor, 6), new Point((panel.Width / 2 - panel.Width / 20) * -1, 0), new Point((panel.Width / 2 - panel.Width / 20) * -1 + 13, 0));
                        g.Graphics.RotateTransform(90);
                    }
                    break;
                case Ticks.None:
                    break;
            }
            #endregion

            #region DrawNumbers
            g.Graphics.ResetTransform();
            g.Graphics.TranslateTransform(Ox, Oy);
            double radius = ((panel.Width - panel.Width / 20.0 * 2) / 2 - 28);
            float x0 = 0;
            float y0 = -(float)radius;
            switch (_numbers)
            {
                case Numbers.All:
                    for (int i = 1; i < 13; i++)
                    {
                        if (_clockStyle == ClockStyle.Classic && i == 6 || _date != Date.None && i == 3)
                        {
                            continue;
                        }
                        if (i == 10 || i == 11)
                        {
                            y0 = -(float)(radius - 3);
                        }
                        var rx = x0 - 0;
                        var ry = y0 - 0;
                        var c = Math.Cos((30 * i) * Math.PI / 180);
                        var s = Math.Sin((30 * i) * Math.PI / 180);
                        float x1 = (float)(0 + rx * c - ry * s);
                        float y1 = (float)(0 + rx * s + ry * c);
                        g.Graphics.DrawString(i.ToString(), new Font("Calibri", 20, FontStyle.Bold), new SolidBrush(_textColor), x1, y1, stringFormat);
                    }
                    break;
                case Numbers.Quadrick:
                    for (int i = 1; i < 5; i++)
                    {
                        if (_clockStyle == ClockStyle.Classic && i == 2 || _date != Date.None && i == 1)
                        {
                            continue;
                        }
                        var rx = x0 - 0;
                        var ry = y0 - 0;
                        var c = Math.Cos((90 * i) * Math.PI / 180);
                        var s = Math.Sin((90 * i) * Math.PI / 180);
                        float x1 = (float)(0 + rx * c - ry * s);
                        float y1 = (float)(0 + rx * s + ry * c);
                        g.Graphics.DrawString((i * 3).ToString(), new Font("Calibri", 20, FontStyle.Bold), new SolidBrush(_textColor), x1, y1, stringFormat);
                    }
                    break;
                case Numbers.None:
                    break;
            }
            #endregion

            #region DrawCaption
            g.Graphics.ResetTransform();
            g.Graphics.TranslateTransform(Ox, (float)(Oy - radius / 2 - 15));
            g.Graphics.DrawString(_caption, new Font("Calibri", 20, FontStyle.Bold), new SolidBrush(_textColor), 0, 0, stringFormat);
            #endregion

            #region DrawDate
            g.Graphics.ResetTransform();
            g.Graphics.TranslateTransform(Ox, Oy);
            switch (_date)
            {
                case Date.DayOfMonth:
                    g.Graphics.FillRectangle(new SolidBrush(Color.White), (float)radius - 13, -10, 23, 20);
                    g.Graphics.DrawRectangle(new Pen(Color.Black), (float)radius - 13, -10, 23, 20);
                    g.Graphics.DrawString(DateTime.Today.Day.ToString(), new Font("Calibri", 15, FontStyle.Bold), new SolidBrush(Color.Black), (float)radius, 1, stringFormat);
                    break;
                case Date.Full:
                    g.Graphics.FillRectangle(new SolidBrush(Color.White), (float)radius - 50, -10, 40, 20);
                    g.Graphics.DrawRectangle(new Pen(Color.Black), (float)radius - 50, -10, 40, 20);
                    g.Graphics.DrawString(DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToUpper(), new Font("Calibri", 15, FontStyle.Bold), new SolidBrush(Color.Black), (float)radius - 30, 1, stringFormat);
                    g.Graphics.FillRectangle(new SolidBrush(Color.White), (float)radius - 13, -10, 23, 20);
                    g.Graphics.DrawRectangle(new Pen(Color.Black), (float)radius - 13, -10, 23, 20);
                    g.Graphics.DrawString(DateTime.Today.Day.ToString(), new Font("Calibri", 15, FontStyle.Bold), new SolidBrush(Color.Black), (float)radius, 1, stringFormat);
                    break;
                case Date.None:
                    break;
            }
            #endregion

            #region DrawSmallSecEllipse
            if (_clockStyle == ClockStyle.Classic)
            {
                g.Graphics.ResetTransform();
                g.Graphics.TranslateTransform(Ox, (float)(Oy + radius / 2 + 30));
                g.Graphics.FillEllipse(new SolidBrush(_outerColor), -35, -35, 70, 70);
                for (int j = 0; j < 60; j++)
                {
                    g.Graphics.DrawLine(new Pen(_tickColor, 1), new Point(-35, 0), new Point(-35 + 1, 0));
                    g.Graphics.RotateTransform(6);
                }
            }
            #endregion

            #region DrawSecHand
            var angleSec = DateTime.Now.Second * 6;
            switch (_clockStyle)
            {
                case ClockStyle.Standart:
                    g.Graphics.ResetTransform();
                    g.Graphics.TranslateTransform(Ox, Oy);
                    g.Graphics.RotateTransform(angleSec);
                    g.Graphics.DrawLine(new Pen(_secHandColor), 0, 30, 0, -133);
                    break;
                case ClockStyle.Classic:
                    g.Graphics.FillEllipse(new SolidBrush(_secHandColor), -3, -3, 6, 6);
                    g.Graphics.RotateTransform(angleSec);
                    g.Graphics.DrawLine(new Pen(_secHandColor), -10, 0, 35, 0);
                    break;
            }
            #endregion

            #region DrawBigHands
            g.Graphics.ResetTransform();
            g.Graphics.TranslateTransform(Ox, Oy);
            var angleMin = DateTime.Now.Minute * 6;
            var angleHour = DateTime.Now.Hour * 30 + 30.0 / 100.0 * (DateTime.Now.Minute / (60.0 / 100.0));
            switch (_handStyle)
            {
                case HandStyle.Uniform:
                    g.Graphics.FillEllipse(new SolidBrush(_handColor), -7, -7, 14, 14);
                    g.Graphics.RotateTransform(angleMin);
                    g.Graphics.DrawLine(new Pen(_handColor, 5), 0, -100, 0, 20);
                    g.Graphics.ResetTransform();
                    g.Graphics.TranslateTransform(Ox, Oy);
                    g.Graphics.RotateTransform((float)angleHour);
                    g.Graphics.DrawLine(new Pen(_handColor, 7), 0, -80, 0, 15);
                    break;
                case HandStyle.Sharp:
                    g.Graphics.FillEllipse(new SolidBrush(_handColor), -7, -7, 14, 14);
                    g.Graphics.RotateTransform(angleMin);
                    g.Graphics.FillPolygon(new SolidBrush(_handColor), new Point[]{new Point(0, 0), new Point(5, -30), new Point(0, -105), new Point(-5, -30)});
                    g.Graphics.ResetTransform();
                    g.Graphics.TranslateTransform(Ox, Oy);
                    g.Graphics.RotateTransform((float)angleHour);
                    g.Graphics.FillPolygon(new SolidBrush(_handColor), new Point[] { new Point(0, 0), new Point(5, -24), new Point(0, -75), new Point(-5, -24) });
                    break;
            }
            g.Graphics.FillEllipse(new SolidBrush(_secHandColor), -4, -4, 8, 8);
            #endregion

            g.Render();

            g.Dispose();
        }
    }
}
