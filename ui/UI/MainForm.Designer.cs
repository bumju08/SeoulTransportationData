
namespace SeoulTransportationData.UI
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.top_panel = new System.Windows.Forms.Panel();
            this.menu_panel_1 = new System.Windows.Forms.Panel();
            this.menu_panel_2 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.폼보이기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu_overlay = new System.Windows.Forms.Button();
            this.menu_decorate = new System.Windows.Forms.Button();
            this.menu_transport = new System.Windows.Forms.Button();
            this.top_title = new System.Windows.Forms.Label();
            this.minimize_top = new System.Windows.Forms.PictureBox();
            this.close_top = new System.Windows.Forms.PictureBox();
            this.colorLabel1 = new SeoulTransportationData.Lib.UI.ColorLabel();
            this.top_panel.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_top)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.top_panel.Controls.Add(this.top_title);
            this.top_panel.Controls.Add(this.minimize_top);
            this.top_panel.Controls.Add(this.close_top);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1034, 27);
            this.top_panel.TabIndex = 18;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // menu_panel_1
            // 
            this.menu_panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menu_panel_1.Location = new System.Drawing.Point(3, 36);
            this.menu_panel_1.Name = "menu_panel_1";
            this.menu_panel_1.Size = new System.Drawing.Size(5, 50);
            this.menu_panel_1.TabIndex = 21;
            // 
            // menu_panel_2
            // 
            this.menu_panel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menu_panel_2.Location = new System.Drawing.Point(3, 88);
            this.menu_panel_2.Name = "menu_panel_2";
            this.menu_panel_2.Size = new System.Drawing.Size(5, 50);
            this.menu_panel_2.TabIndex = 26;
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼보이기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(69, 48);
            // 
            // 폼보이기ToolStripMenuItem
            // 
            this.폼보이기ToolStripMenuItem.Name = "폼보이기ToolStripMenuItem";
            this.폼보이기ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.Menu;
            this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
            this.TrayIcon.Text = "Lococo";
            this.TrayIcon.Visible = true;
            // 
            // menu_overlay
            // 
            this.menu_overlay.Location = new System.Drawing.Point(0, 0);
            this.menu_overlay.Name = "menu_overlay";
            this.menu_overlay.Size = new System.Drawing.Size(75, 23);
            this.menu_overlay.TabIndex = 28;
            // 
            // menu_decorate
            // 
            this.menu_decorate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_decorate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menu_decorate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.menu_decorate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_decorate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_decorate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_decorate.ForeColor = System.Drawing.Color.White;
            this.menu_decorate.Image = global::SeoulTransportationData.Properties.Resources.bus;
            this.menu_decorate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_decorate.Location = new System.Drawing.Point(10, 88);
            this.menu_decorate.Name = "menu_decorate";
            this.menu_decorate.Size = new System.Drawing.Size(196, 50);
            this.menu_decorate.TabIndex = 30;
            this.menu_decorate.Text = "그럴듯한 메뉴          ";
            this.menu_decorate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_decorate.UseVisualStyleBackColor = true;
            this.menu_decorate.Click += new System.EventHandler(this.menu_decorate_Click);
            // 
            // menu_transport
            // 
            this.menu_transport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_transport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.menu_transport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.menu_transport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menu_transport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_transport.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menu_transport.ForeColor = System.Drawing.Color.White;
            this.menu_transport.Image = global::SeoulTransportationData.Properties.Resources.bus;
            this.menu_transport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menu_transport.Location = new System.Drawing.Point(10, 36);
            this.menu_transport.Name = "menu_transport";
            this.menu_transport.Size = new System.Drawing.Size(196, 50);
            this.menu_transport.TabIndex = 29;
            this.menu_transport.Text = "대중교통               ";
            this.menu_transport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu_transport.UseVisualStyleBackColor = true;
            this.menu_transport.Click += new System.EventHandler(this.menu_transport_Click);
            // 
            // top_title
            // 
            this.top_title.AutoSize = true;
            this.top_title.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.top_title.ForeColor = System.Drawing.Color.White;
            this.top_title.Image = global::SeoulTransportationData.Properties.Resources.pie_chart_small;
            this.top_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.top_title.Location = new System.Drawing.Point(4, 6);
            this.top_title.Name = "top_title";
            this.top_title.Size = new System.Drawing.Size(103, 17);
            this.top_title.TabIndex = 31;
            this.top_title.Text = "     멋있는 제목";
            this.top_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_title_MouseDown);
            this.top_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_title_MouseMove);
            this.top_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_title_MouseUp);
            // 
            // minimize_top
            // 
            this.minimize_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.minimize_top.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_top.Image = global::SeoulTransportationData.Properties.Resources.minimize;
            this.minimize_top.Location = new System.Drawing.Point(978, 2);
            this.minimize_top.Name = "minimize_top";
            this.minimize_top.Size = new System.Drawing.Size(25, 25);
            this.minimize_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_top.TabIndex = 19;
            this.minimize_top.TabStop = false;
            this.minimize_top.Click += new System.EventHandler(this.minimize_top_Click);
            this.minimize_top.MouseEnter += new System.EventHandler(this.minimize_top_MouseEnter);
            this.minimize_top.MouseLeave += new System.EventHandler(this.minimize_top_MouseLeave);
            // 
            // close_top
            // 
            this.close_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.close_top.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_top.Image = global::SeoulTransportationData.Properties.Resources.close;
            this.close_top.Location = new System.Drawing.Point(1006, 2);
            this.close_top.Name = "close_top";
            this.close_top.Size = new System.Drawing.Size(25, 25);
            this.close_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_top.TabIndex = 20;
            this.close_top.TabStop = false;
            this.close_top.Click += new System.EventHandler(this.close_top_Click);
            this.close_top.MouseEnter += new System.EventHandler(this.close_top_MouseEnter);
            this.close_top.MouseLeave += new System.EventHandler(this.close_top_MouseLeave);
            // 
            // colorLabel1
            // 
            this.colorLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.colorLabel1.Location = new System.Drawing.Point(12, 153);
            this.colorLabel1.Name = "colorLabel1";
            this.colorLabel1.Size = new System.Drawing.Size(127, 30);
            this.colorLabel1.TabIndex = 31;
            this.colorLabel1.Text = "색상을 선택";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1034, 718);
            this.ControlBox = false;
            this.Controls.Add(this.colorLabel1);
            this.Controls.Add(this.menu_decorate);
            this.Controls.Add(this.menu_transport);
            this.Controls.Add(this.menu_panel_2);
            this.Controls.Add(this.menu_panel_1);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.menu_overlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lococo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button menu_overlay;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.PictureBox minimize_top;
        private System.Windows.Forms.PictureBox close_top;
        private System.Windows.Forms.Panel menu_panel_1;
        private System.Windows.Forms.Panel menu_panel_2;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem 폼보이기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.Button menu_transport;
        private System.Windows.Forms.Button menu_decorate;
        private System.Windows.Forms.Label top_title;
        private Lib.UI.ColorLabel colorLabel1;
    }
}

