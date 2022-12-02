
namespace SeoulTransportationData.UI
{
    partial class inputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.message = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.close_top = new System.Windows.Forms.PictureBox();
            this.Caption = new System.Windows.Forms.Label();
            this.title_panel = new System.Windows.Forms.Panel();
            this.user_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.close_top)).BeginInit();
            this.title_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.message.ForeColor = System.Drawing.SystemColors.Control;
            this.message.Location = new System.Drawing.Point(25, 65);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(133, 17);
            this.message.TabIndex = 0;
            this.message.Text = "테스트 메세지입니다.";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(100)))));
            this.okButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(160)))));
            this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(130)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Location = new System.Drawing.Point(267, 169);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(120, 40);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "확인";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.noButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(165)))), ((int)(((byte)(100)))));
            this.noButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.noButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noButton.ForeColor = System.Drawing.Color.White;
            this.noButton.Location = new System.Drawing.Point(405, 169);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(120, 40);
            this.noButton.TabIndex = 8;
            this.noButton.Text = "취소";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // close_top
            // 
            this.close_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.close_top.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_top.Image = global::SeoulTransportationData.Properties.Resources.close;
            this.close_top.Location = new System.Drawing.Point(769, 0);
            this.close_top.Name = "close_top";
            this.close_top.Size = new System.Drawing.Size(30, 35);
            this.close_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_top.TabIndex = 21;
            this.close_top.TabStop = false;
            this.close_top.Click += new System.EventHandler(this.close_top_Click);
            this.close_top.MouseEnter += new System.EventHandler(this.close_top_MouseEnter);
            this.close_top.MouseLeave += new System.EventHandler(this.close_top_MouseLeave);
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Caption.ForeColor = System.Drawing.Color.DarkGray;
            this.Caption.Image = global::SeoulTransportationData.Properties.Resources.pie_chart_small;
            this.Caption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Caption.Location = new System.Drawing.Point(8, 8);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(74, 20);
            this.Caption.TabIndex = 22;
            this.Caption.Text = "대충 제목";
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.title_panel.Controls.Add(this.close_top);
            this.title_panel.Controls.Add(this.Caption);
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(799, 35);
            this.title_panel.TabIndex = 23;
            this.title_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseDown);
            this.title_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseMove);
            this.title_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseUp);
            // 
            // user_input
            // 
            this.user_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.user_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_input.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_input.ForeColor = System.Drawing.Color.LightGray;
            this.user_input.Location = new System.Drawing.Point(25, 115);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(500, 25);
            this.user_input.TabIndex = 73;
            this.user_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_input_KeyDown);
            // 
            // inputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 235);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.title_panel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inputBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.messageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_top)).EndInit();
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.PictureBox close_top;
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.TextBox user_input;
    }
}