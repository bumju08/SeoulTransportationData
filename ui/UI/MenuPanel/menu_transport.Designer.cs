
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
            this.label_show = new System.Windows.Forms.Label();
            this.line_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sort = new System.Windows.Forms.Label();
            this.description_sort = new System.Windows.Forms.Label();
            this.option_sort_2 = new SeoulTransportationData.Lib.UI.FlatCheckBox();
            this.option_sort_1 = new SeoulTransportationData.Lib.UI.FlatCheckBox();
            this.show = new SeoulTransportationData.Lib.UI.FlatCheckBox();
            this.description_data = new System.Windows.Forms.Label();
            this.label_data = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_model = new System.Windows.Forms.Label();
            this.box_model = new System.Windows.Forms.ComboBox();
            this.box_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_label = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.text_label = new System.Windows.Forms.TextBox();
            this.select_color = new SeoulTransportationData.Lib.UI.ColorLabel();
            this.data_add = new System.Windows.Forms.Button();
            this.data_remove = new System.Windows.Forms.Button();
            this.description_settings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_settings = new System.Windows.Forms.Label();
            this.text_title = new System.Windows.Forms.TextBox();
            this.label_title = new System.Windows.Forms.Label();
            this.text_xLabel = new System.Windows.Forms.TextBox();
            this.label_xLabel = new System.Windows.Forms.Label();
            this.text_yLabel = new System.Windows.Forms.TextBox();
            this.label_yLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_show
            // 
            this.label_show.BackColor = System.Drawing.Color.Transparent;
            this.label_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_show.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_show.ForeColor = System.Drawing.Color.White;
            this.label_show.Location = new System.Drawing.Point(15, 15);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(570, 35);
            this.label_show.TabIndex = 8;
            this.label_show.Text = "시각화 창 표시";
            this.label_show.Click += new System.EventHandler(this.label_show_Click);
            // 
            // line_1
            // 
            this.line_1.AutoSize = true;
            this.line_1.BackColor = System.Drawing.Color.Transparent;
            this.line_1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.line_1.Location = new System.Drawing.Point(17, 58);
            this.line_1.Name = "line_1";
            this.line_1.Size = new System.Drawing.Size(568, 17);
            this.line_1.TabIndex = 31;
            this.line_1.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------";
            // 
            // label_sort
            // 
            this.label_sort.BackColor = System.Drawing.Color.Transparent;
            this.label_sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_sort.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_sort.ForeColor = System.Drawing.Color.White;
            this.label_sort.Location = new System.Drawing.Point(15, 95);
            this.label_sort.Name = "label_sort";
            this.label_sort.Size = new System.Drawing.Size(570, 35);
            this.label_sort.TabIndex = 41;
            this.label_sort.Text = "단일 데이터 정렬";
            // 
            // description_sort
            // 
            this.description_sort.AutoSize = true;
            this.description_sort.Cursor = System.Windows.Forms.Cursors.Default;
            this.description_sort.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.description_sort.ForeColor = System.Drawing.Color.DarkGray;
            this.description_sort.Location = new System.Drawing.Point(22, 132);
            this.description_sort.Name = "description_sort";
            this.description_sort.Size = new System.Drawing.Size(428, 15);
            this.description_sort.TabIndex = 66;
            this.description_sort.Text = "시각화할 데이터셋 개수가 1개일 때, 값을 기준으로 정렬할 방식을 선택합니다.";
            // 
            // option_sort_2
            // 
            this.option_sort_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option_sort_2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.option_sort_2.ForeColor = System.Drawing.Color.White;
            this.option_sort_2.Location = new System.Drawing.Point(20, 197);
            this.option_sort_2.Name = "option_sort_2";
            this.option_sort_2.Size = new System.Drawing.Size(140, 30);
            this.option_sort_2.TabIndex = 67;
            this.option_sort_2.Text = "내림차순";
            this.option_sort_2.UseVisualStyleBackColor = true;
            this.option_sort_2.Click += new System.EventHandler(this.option_sort_2_Click);
            // 
            // option_sort_1
            // 
            this.option_sort_1.Checked = true;
            this.option_sort_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.option_sort_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option_sort_1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.option_sort_1.ForeColor = System.Drawing.Color.White;
            this.option_sort_1.Location = new System.Drawing.Point(20, 161);
            this.option_sort_1.Name = "option_sort_1";
            this.option_sort_1.Size = new System.Drawing.Size(140, 30);
            this.option_sort_1.TabIndex = 43;
            this.option_sort_1.Text = "오름차순";
            this.option_sort_1.UseVisualStyleBackColor = true;
            this.option_sort_1.Click += new System.EventHandler(this.option_sort_1_Click);
            // 
            // show
            // 
            this.show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show.Location = new System.Drawing.Point(555, 15);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(30, 30);
            this.show.TabIndex = 40;
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // description_data
            // 
            this.description_data.AutoSize = true;
            this.description_data.Cursor = System.Windows.Forms.Cursors.Default;
            this.description_data.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.description_data.ForeColor = System.Drawing.Color.DarkGray;
            this.description_data.Location = new System.Drawing.Point(22, 577);
            this.description_data.Name = "description_data";
            this.description_data.Size = new System.Drawing.Size(186, 15);
            this.description_data.TabIndex = 69;
            this.description_data.Text = "시각화할 데이터들을 관리합니다.";
            // 
            // label_data
            // 
            this.label_data.BackColor = System.Drawing.Color.Transparent;
            this.label_data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_data.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_data.ForeColor = System.Drawing.Color.White;
            this.label_data.Location = new System.Drawing.Point(15, 540);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(570, 35);
            this.label_data.TabIndex = 68;
            this.label_data.Text = "데이터셋 관리";
            // 
            // dataList
            // 
            this.dataList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.dataList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataList.ForeColor = System.Drawing.Color.LightGray;
            this.dataList.FullRowSelect = true;
            this.dataList.HideSelection = false;
            this.dataList.Location = new System.Drawing.Point(20, 656);
            this.dataList.MultiSelect = false;
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(544, 158);
            this.dataList.TabIndex = 70;
            this.dataList.UseCompatibleStateImageBehavior = false;
            this.dataList.View = System.Windows.Forms.View.Details;
            // 
            // col1
            // 
            this.col1.Text = "모델";
            this.col1.Width = 100;
            // 
            // col2
            // 
            this.col2.Text = "유형";
            this.col2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col2.Width = 133;
            // 
            // col3
            // 
            this.col3.Text = "범례명";
            this.col3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col3.Width = 133;
            // 
            // col4
            // 
            this.col4.Text = "색상";
            this.col4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col4.Width = 133;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_model.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_model.ForeColor = System.Drawing.Color.White;
            this.label_model.Location = new System.Drawing.Point(22, 840);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(34, 15);
            this.label_model.TabIndex = 71;
            this.label_model.Text = "모델:";
            // 
            // box_model
            // 
            this.box_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.box_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_model.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_model.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.box_model.ForeColor = System.Drawing.Color.White;
            this.box_model.FormattingEnabled = true;
            this.box_model.Items.AddRange(new object[] {
            "버스",
            "지하철",
            "인구"});
            this.box_model.Location = new System.Drawing.Point(84, 837);
            this.box_model.Name = "box_model";
            this.box_model.Size = new System.Drawing.Size(353, 23);
            this.box_model.TabIndex = 72;
            this.box_model.SelectedIndexChanged += new System.EventHandler(this.box_model_SelectedIndexChanged);
            // 
            // box_type
            // 
            this.box_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.box_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_type.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.box_type.ForeColor = System.Drawing.Color.White;
            this.box_type.FormattingEnabled = true;
            this.box_type.Items.AddRange(new object[] {
            "이용률",
            "이용 수",
            "승차 수",
            "하차 수"});
            this.box_type.Location = new System.Drawing.Point(84, 872);
            this.box_type.Name = "box_type";
            this.box_type.Size = new System.Drawing.Size(353, 23);
            this.box_type.TabIndex = 74;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_type.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_type.ForeColor = System.Drawing.Color.White;
            this.label_type.Location = new System.Drawing.Point(22, 876);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(34, 15);
            this.label_type.TabIndex = 73;
            this.label_type.Text = "유형:";
            // 
            // label_label
            // 
            this.label_label.AutoSize = true;
            this.label_label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_label.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_label.ForeColor = System.Drawing.Color.White;
            this.label_label.Location = new System.Drawing.Point(22, 910);
            this.label_label.Name = "label_label";
            this.label_label.Size = new System.Drawing.Size(46, 15);
            this.label_label.TabIndex = 75;
            this.label_label.Text = "범례명:";
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_color.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_color.ForeColor = System.Drawing.Color.White;
            this.label_color.Location = new System.Drawing.Point(22, 949);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(34, 15);
            this.label_color.TabIndex = 77;
            this.label_color.Text = "색상:";
            // 
            // text_label
            // 
            this.text_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.text_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_label.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_label.ForeColor = System.Drawing.Color.LightGray;
            this.text_label.Location = new System.Drawing.Point(84, 908);
            this.text_label.MaxLength = 100;
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(353, 23);
            this.text_label.TabIndex = 78;
            this.text_label.Text = "범례명";
            // 
            // select_color
            // 
            this.select_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select_color.ForeColor = System.Drawing.Color.LightGray;
            this.select_color.Location = new System.Drawing.Point(82, 942);
            this.select_color.Name = "select_color";
            this.select_color.Size = new System.Drawing.Size(355, 30);
            this.select_color.TabIndex = 79;
            this.select_color.Text = "#FF0000";
            this.select_color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // data_add
            // 
            this.data_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.data_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.data_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.data_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.data_add.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.data_add.ForeColor = System.Drawing.Color.White;
            this.data_add.Image = global::SeoulTransportationData.Properties.Resources.plus_small;
            this.data_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.data_add.Location = new System.Drawing.Point(20, 619);
            this.data_add.Name = "data_add";
            this.data_add.Size = new System.Drawing.Size(70, 31);
            this.data_add.TabIndex = 80;
            this.data_add.Text = "추가";
            this.data_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.data_add.UseVisualStyleBackColor = false;
            this.data_add.Click += new System.EventHandler(this.data_add_Click);
            // 
            // data_remove
            // 
            this.data_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.data_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data_remove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.data_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.data_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.data_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.data_remove.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.data_remove.ForeColor = System.Drawing.Color.White;
            this.data_remove.Image = global::SeoulTransportationData.Properties.Resources.remove_small;
            this.data_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.data_remove.Location = new System.Drawing.Point(96, 619);
            this.data_remove.Name = "data_remove";
            this.data_remove.Size = new System.Drawing.Size(70, 31);
            this.data_remove.TabIndex = 81;
            this.data_remove.Text = "제거";
            this.data_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.data_remove.UseVisualStyleBackColor = false;
            this.data_remove.Click += new System.EventHandler(this.data_remove_Click);
            // 
            // description_settings
            // 
            this.description_settings.AutoSize = true;
            this.description_settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.description_settings.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.description_settings.ForeColor = System.Drawing.Color.DarkGray;
            this.description_settings.Location = new System.Drawing.Point(22, 326);
            this.description_settings.Name = "description_settings";
            this.description_settings.Size = new System.Drawing.Size(218, 15);
            this.description_settings.TabIndex = 85;
            this.description_settings.Text = "그래프의 제목과 축 이름을 설정합니다.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(17, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(568, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------";
            // 
            // label_settings
            // 
            this.label_settings.BackColor = System.Drawing.Color.Transparent;
            this.label_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_settings.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_settings.ForeColor = System.Drawing.Color.White;
            this.label_settings.Location = new System.Drawing.Point(15, 289);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(570, 35);
            this.label_settings.TabIndex = 82;
            this.label_settings.Text = "기본 설정";
            // 
            // text_title
            // 
            this.text_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.text_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_title.ForeColor = System.Drawing.Color.LightGray;
            this.text_title.Location = new System.Drawing.Point(84, 384);
            this.text_title.MaxLength = 200;
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(353, 23);
            this.text_title.TabIndex = 87;
            this.text_title.Text = "서울 대중교통 이용률";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_title.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(22, 386);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(34, 15);
            this.label_title.TabIndex = 86;
            this.label_title.Text = "제목:";
            // 
            // text_xLabel
            // 
            this.text_xLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.text_xLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_xLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_xLabel.ForeColor = System.Drawing.Color.LightGray;
            this.text_xLabel.Location = new System.Drawing.Point(84, 431);
            this.text_xLabel.MaxLength = 200;
            this.text_xLabel.Name = "text_xLabel";
            this.text_xLabel.Size = new System.Drawing.Size(353, 23);
            this.text_xLabel.TabIndex = 89;
            this.text_xLabel.Text = "자치구";
            // 
            // label_xLabel
            // 
            this.label_xLabel.AutoSize = true;
            this.label_xLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_xLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_xLabel.ForeColor = System.Drawing.Color.White;
            this.label_xLabel.Location = new System.Drawing.Point(22, 433);
            this.label_xLabel.Name = "label_xLabel";
            this.label_xLabel.Size = new System.Drawing.Size(29, 15);
            this.label_xLabel.TabIndex = 88;
            this.label_xLabel.Text = "X축:";
            // 
            // text_yLabel
            // 
            this.text_yLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.text_yLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_yLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_yLabel.ForeColor = System.Drawing.Color.LightGray;
            this.text_yLabel.Location = new System.Drawing.Point(84, 460);
            this.text_yLabel.MaxLength = 200;
            this.text_yLabel.Name = "text_yLabel";
            this.text_yLabel.Size = new System.Drawing.Size(353, 23);
            this.text_yLabel.TabIndex = 91;
            this.text_yLabel.Text = "일일 이용률";
            // 
            // label_yLabel
            // 
            this.label_yLabel.AutoSize = true;
            this.label_yLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_yLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_yLabel.ForeColor = System.Drawing.Color.White;
            this.label_yLabel.Location = new System.Drawing.Point(22, 462);
            this.label_yLabel.Name = "label_yLabel";
            this.label_yLabel.Size = new System.Drawing.Size(29, 15);
            this.label_yLabel.TabIndex = 90;
            this.label_yLabel.Text = "Y축:";
            // 
            // menu_transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Controls.Add(this.text_yLabel);
            this.Controls.Add(this.label_yLabel);
            this.Controls.Add(this.text_xLabel);
            this.Controls.Add(this.label_xLabel);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.description_settings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_settings);
            this.Controls.Add(this.data_remove);
            this.Controls.Add(this.data_add);
            this.Controls.Add(this.select_color);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label_label);
            this.Controls.Add(this.box_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.box_model);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.description_data);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.option_sort_2);
            this.Controls.Add(this.description_sort);
            this.Controls.Add(this.option_sort_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_sort);
            this.Controls.Add(this.show);
            this.Controls.Add(this.line_1);
            this.Controls.Add(this.label_show);
            this.Name = "menu_transport";
            this.Size = new System.Drawing.Size(630, 1007);
            this.Load += new System.EventHandler(this.menu_browser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_show;
        private Lib.UI.FlatCheckBox open_overlay;
        private System.Windows.Forms.Label line_1;
        private Lib.UI.ColorLabel setBackColor;
        private Lib.UI.FlatCheckBox setTransparent_backColor;
        private Lib.UI.ColorLabel setForeColor;
        private Lib.UI.FlatCheckBox show;
        private Lib.UI.FlatCheckBox option_sort_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sort;
        private System.Windows.Forms.Label description_sort;
        private Lib.UI.FlatCheckBox option_sort_2;
        private System.Windows.Forms.Label description_data;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.ListView dataList;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ColumnHeader col3;
        private System.Windows.Forms.ColumnHeader col4;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.ComboBox box_model;
        private System.Windows.Forms.ComboBox box_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_label;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.TextBox text_label;
        private Lib.UI.ColorLabel select_color;
        private System.Windows.Forms.Button data_add;
        private System.Windows.Forms.Button data_remove;
        private System.Windows.Forms.Label description_settings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_settings;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox text_xLabel;
        private System.Windows.Forms.Label label_xLabel;
        private System.Windows.Forms.TextBox text_yLabel;
        private System.Windows.Forms.Label label_yLabel;
    }
}
