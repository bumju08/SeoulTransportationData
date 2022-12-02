using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Threading;



namespace SeoulTransportationData.UI
{
    /// <summary>
    /// 프로그램의 메인 UI 폼입니다.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Windows API
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32")]
        public static extern Int32 GetCursorPos(out POINT pt);

        public struct POINT
        {
            public Int32 x;
            public Int32 y;
        }

        #endregion

        #region Private Variables
        private bool form_dragging = false;
        private POINT firstPoint;
        private int form_left, form_top;
        #endregion








        public MainForm()
        {
            InitializeComponent();
        }


        #region Form - Make Borderless Form as Resizable
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084:
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13 ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12 ;
                            else
                                m.Result = (IntPtr)14 ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10 ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2 ;
                            else
                                m.Result = (IntPtr)11 ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16 ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15 ;
                            else
                                m.Result = (IntPtr)17 ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        #endregion


        #region Event Handlers - Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Lock
            File.Open(Application.ExecutablePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            this.Size = new Size(825, 555);

            LayoutPanel();
            resizeControls();

            this.Resize += (sen, evt) =>
            { resizeControls(); };

            
            using (var shadowClass = new Lib.UI.DropShadow())
            { 
                shadowClass.ApplyShadows(this, drawType: 1);
            }

            Focus();

            menu_transport_Click(menu_transport, new EventArgs());
        }


        private void resizeControls()
        {
            int white_space = close_top.Width + 3;

            close_top.Left = Width - white_space;
            minimize_top.Left = close_top.Left - white_space;

            panel_transport.Size = new Size(Width - (panel_transport.Left + 5), Height - (panel_transport.Top + 5));

        }

        public MenuPanel.menu_transport m_transport;

        private Panel panel_transport;
        private void LayoutPanel()
        {
            m_transport = new MenuPanel.menu_transport();

            panel_transport = new Panel
            {
                Name = "panel_transport",
                BackColor = Color.FromArgb(22, 22, 22),
                Location = new Point(menu_transport.Right + 5, menu_transport.Top),
                Width = this.Width - (216),
                Height = this.Height - (36)
            };

            panel_transport.Controls.Add(m_transport);

            this.Controls.Add(panel_transport);
        }
        #endregion

        #region Event Handlers - Title Bar Panel Controls
        private void minimize_top_MouseEnter(object sender, EventArgs e)
        {
            minimize_top.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void minimize_top_MouseLeave(object sender, EventArgs e)
        {
            minimize_top.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void minimize_top_Click(object sender, EventArgs e)
        {
            minimize_top.BackColor = Color.FromArgb(60, 60, 60);
            this.WindowState = FormWindowState.Minimized;
        }



        private void close_top_MouseEnter(object sender, EventArgs e)
        {
            close_top.BackColor = Color.FromArgb(180, 35, 35);
        }

        private void close_top_MouseLeave(object sender, EventArgs e)
        {
            close_top.BackColor = Color.FromArgb(25, 25, 25);
        }

        private void close_top_Click(object sender, EventArgs e)
        {
            close_top.BackColor = Color.FromArgb(255, 15, 15);

            Environment.Exit(0);
        }


        private void MoveForm_MouseDown()
        {
            if (!form_dragging)
            {
                form_dragging = true;
                form_left = this.Left;
                form_top = this.Top;

                GetCursorPos(out firstPoint);
            }
        }

        private void MoveForm_MouseMove()
        {
            POINT secondPoint;

            if (form_dragging)
            {
                GetCursorPos(out secondPoint);

                this.Left = form_left + secondPoint.x - firstPoint.x;
                this.Top = form_top + secondPoint.y - firstPoint.y;
            }
        }

        private void MoveForm_MouseUp()
        {
            form_dragging = false;
        }

        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm_MouseDown();
        }

        private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm_MouseMove();
        }

        private void top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm_MouseUp();
        }


        private void top_title_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm_MouseDown();
        }

        private void top_title_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm_MouseMove();
        }

        private void top_title_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm_MouseUp();
        }

        #endregion


        #region Event Handlers - Menu
        private void highlightMenu(Button current_menu)
        {
            string menu_name = current_menu.Name.Remove(0, 5);


            for (ushort index = 0; index < this.Controls.Count; ++index)
            {
                Control current_control = this.Controls[index];

                if (current_control is Panel)
                {
                    if (current_control.Size == menu_panel_1.Size)
                    {
                        if (current_control.Top == current_menu.Top)
                            current_control.BackColor = Color.FromArgb(255, 81, 36);

                        else
                            current_control.BackColor = Color.FromArgb(17, 17, 17);

                    }


                    else if (current_control.Name == "panel_" + menu_name)
                    {
                        current_control.BringToFront();
                    }

                }

            }

        }

        private void menu_transport_Click(object sender, EventArgs e)
        {
            highlightMenu((Button)sender);
        }

        private void menu_decorate_Click(object sender, EventArgs e)
        {
            using (var python = new Lib.Python.Visualizer())
            {
                python.GenerateData();
            }

            Program.ShowMsgbox("테스트에용", "제목입니당");

        }
        #endregion

    }
}
