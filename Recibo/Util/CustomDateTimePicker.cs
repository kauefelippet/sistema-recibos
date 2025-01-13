using System;
using System.Drawing;
using System.Windows.Forms;

namespace Recibo.Util
{
    public class CustomDateTimePicker : DateTimePicker
    {
        private Color _backColor = Color.FromArgb(108, 117, 125);
        private Color _foreColor = Color.FromArgb(206, 212, 218);

        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.CalendarFont = new Font("JetBrains Mono", 10F);
            this.CalendarForeColor = _foreColor;
            this.CalendarMonthBackground = _backColor;
            this.CustomFormat = "dd/MM/yyyy";
            this.Font = new Font("JetBrains Mono", 9F);
            this.Format = DateTimePickerFormat.Short;
            this.ForeColor = _foreColor;
            this.BackColor = _backColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = this.ClientRectangle;

            // Draw the background
            using (SolidBrush brush = new SolidBrush(_backColor))
            {
                g.FillRectangle(brush, rect);
            }

            // Draw the text
            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor);

            // Draw the drop-down button
            Rectangle buttonRect = new Rectangle(rect.Width - 17, 0, 17, rect.Height);
            using (SolidBrush brush = new SolidBrush(_backColor))
            {
                g.FillRectangle(brush, buttonRect);
            }
            ControlPaint.DrawComboButton(g, buttonRect, ButtonState.Flat);
        }

        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            this.Invalidate();
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            this.Invalidate();
        }
    }
}
