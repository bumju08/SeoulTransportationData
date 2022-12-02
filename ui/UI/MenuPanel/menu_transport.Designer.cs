
namespace SeoulTransportationData.UI.MenuPanel
{
    partial class menu_transport
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_map = new System.Windows.Forms.Label();
            this.line_1 = new System.Windows.Forms.Label();
            this.exp_overlay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_map
            // 
            this.label_map.BackColor = System.Drawing.Color.Transparent;
            this.label_map.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_map.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_map.ForeColor = System.Drawing.Color.White;
            this.label_map.Location = new System.Drawing.Point(15, 15);
            this.label_map.Name = "label_map";
            this.label_map.Size = new System.Drawing.Size(570, 35);
            this.label_map.TabIndex = 8;
            this.label_map.Text = "제목";
            // 
            // line_1
            // 
            this.line_1.AutoSize = true;
            this.line_1.BackColor = System.Drawing.Color.Transparent;
            this.line_1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.line_1.Location = new System.Drawing.Point(17, 112);
            this.line_1.Name = "line_1";
            this.line_1.Size = new System.Drawing.Size(568, 17);
            this.line_1.TabIndex = 31;
            this.line_1.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------";
            // 
            // exp_overlay
            // 
            this.exp_overlay.AutoSize = true;
            this.exp_overlay.BackColor = System.Drawing.Color.Transparent;
            this.exp_overlay.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exp_overlay.ForeColor = System.Drawing.Color.DarkGray;
            this.exp_overlay.Location = new System.Drawing.Point(17, 55);
            this.exp_overlay.Name = "exp_overlay";
            this.exp_overlay.Size = new System.Drawing.Size(34, 17);
            this.exp_overlay.TabIndex = 39;
            this.exp_overlay.Text = "설명";
            // 
            // menu_transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.exp_overlay);
            this.Controls.Add(this.line_1);
            this.Controls.Add(this.label_map);
            this.Name = "menu_transport";
            this.Size = new System.Drawing.Size(630, 800);
            this.Load += new System.EventHandler(this.menu_browser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_map;
        private Lib.UI.flatCheckBox open_overlay;
        private System.Windows.Forms.Label line_1;
        private System.Windows.Forms.Label exp_overlay;
        private Lib.UI.ColorLabel setBackColor;
        private Lib.UI.flatCheckBox setTransparent_backColor;
        private Lib.UI.ColorLabel setForeColor;
    }
}
