using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private Color defaultBackColor = Color.LightGray;
    private Color hoverBackColor = Color.Gray;
    private Color pressedBackColor = Color.DarkGray;
    private Color borderColor = Color.Black;
    private int cornerRadius = 20;
    private int borderWidth = 2;

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    public Color DefaultBackColor
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    {
        get { return defaultBackColor; }
        set { defaultBackColor = value; Invalidate(); }
    }

    public Color HoverBackColor
    {
        get { return hoverBackColor; }
        set { hoverBackColor = value; Invalidate(); }
    }

    public Color PressedBackColor
    {
        get { return pressedBackColor; }
        set { pressedBackColor = value; Invalidate(); }
    }

    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; Invalidate(); }
    }

    public int CornerRadius
    {
        get { return cornerRadius; }
        set { cornerRadius = value; Invalidate(); }
    }

    public int BorderWidth
    {
        get { return borderWidth; }
        set { borderWidth = value; Invalidate(); }
    }

    public RoundedButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = defaultBackColor;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rect = ClientRectangle;
        rect.Inflate(-1, -1);  // Adjust rectangle for border width

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);

            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                pevent.Graphics.DrawPath(pen, path);
            }

            // Tekst tekenen
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            using (SolidBrush textBrush = new SolidBrush(ForeColor))
            {
                pevent.Graphics.DrawString(Text, Font, textBrush, rect, stringFormat);
            }
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        BackColor = hoverBackColor;
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        BackColor = defaultBackColor;
    }

    protected override void OnMouseDown(MouseEventArgs mevent)
    {
        base.OnMouseDown(mevent);
        BackColor = pressedBackColor;
    }

    protected override void OnMouseUp(MouseEventArgs mevent)
    {
        base.OnMouseUp(mevent);
        BackColor = hoverBackColor;
    }
}