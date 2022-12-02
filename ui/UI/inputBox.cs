using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;





namespace SeoulTransportationData.UI
{
    /// <summary>
    /// 윈도우 기본 메세지박스가 어울리지 않아 만든 커스텀 메세지박스입니다. Program.ShowMsgBox() 함수를 통해 사용 가능합니다.
    /// </summary>
    public partial class inputBox : Form
    {
        #region API
        [DllImport("user32")]
        public static extern Int32 GetCursorPos(out POINT pt);

        public struct POINT
        {
            public Int32 x;
            public Int32 y;
        }
        #endregion

        #region Global Variables
        public string msg { get; set; } = null;
        public string cap { get; set; } = null;

        public string userInput { get; set; }

        private bool dragging = false;
        private POINT startPoint, currentPoint;
        private int form_left, form_top;

        #endregion


        #region UI
        public inputBox()
        {
            InitializeComponent();
        }



        private int white_space = 25;
        private void messageForm_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(255, 132, 155);
            Size screen = Program.screen;

            Caption.Text = "     " + cap;
            message.Text = msg;
            message.MaximumSize = new Size(screen.Width/2 - (white_space*2), (int)((float)screen.Height*0.9) - (white_space*4));
            
            MinimumSize = new Size(550, 235);
            Width = message.Width + (white_space * 2);
            Height = message.Bottom + okButton.Height + user_input.Height + (white_space * 4);

            Left = (screen.Width - Width) / 2;
            Top = (screen.Height - Height) / 2;

            int buttons_total_width = okButton.Width + noButton.Width + white_space;
            user_input.Location = new Point(message.Left, message.Bottom + white_space*2);
            user_input.Width = Width - (white_space*2);
            okButton.Location = new Point((Width - buttons_total_width) / 2, message.Bottom + user_input.Height + (white_space * 3));
            noButton.Location = new Point(okButton.Right + white_space, okButton.Top);

            title_panel.Width = Width;

            using (var shadowClass = new SeoulTransportationData.Lib.UI.DropShadow())
            {
                shadowClass.ApplyShadows(this, drawType: 1);
            }

            user_input.Focus();
        }

        private void close_top_MouseEnter(object sender, EventArgs e)
        {
            close_top.BackColor = Color.FromArgb(180, 35, 35);
        }

        private void close_top_MouseLeave(object sender, EventArgs e)
        {
            close_top.BackColor = Color.FromArgb(25, 25, 25);
        }
        #endregion


        #region move Form with Dragging
        private void title_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (!dragging)
            {
                dragging = true;

                GetCursorPos(out startPoint);

                form_left = this.Left;
                form_top = this.Top;
            }
        }

        private void title_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                GetCursorPos(out currentPoint);

                this.Left = form_left + currentPoint.x - startPoint.x;
                this.Top = form_top + currentPoint.y - startPoint.y;
            }
        }

        private void title_panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion



        #region Pressed No/Closed
        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_top_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Pressed OK
        private void okButton_Click(object sender, EventArgs e)
        {
            userInput = user_input.Text;

            this.Close();
        }

        #endregion


        private void user_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                okButton_Click(okButton, new EventArgs());
            
        }
    }
}
