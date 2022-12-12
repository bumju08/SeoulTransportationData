using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

using SeoulTransportationData.Lib.UI;





namespace SeoulTransportationData.UI.MenuPanel
{
    public partial class menu_transport : UserControl
    {
        #region API
        [DllImport("user32")]
        public static extern Int32 GetCursorPos(out POINT pt);

        [DllImport("user32")]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        public struct POINT
        {
            public Int32 x;
            public Int32 y;
        }
        #endregion

        #region Global Variables
        private Lib.Python.Visualizer visualizer = new Lib.Python.Visualizer();
        private Lib.Python.Engine engine = new Lib.Python.Engine();

        private Dictionary<string, string> parameters = new Dictionary<string, string>() 
        { {"버스", "bus"}, {"지하철", "subway"}, {"인구", "population"}, {"이용률", "dailyrate"}, {"이용 수", "all"}, {"승차 수", "in"}, {"하차 수", "out"}, {"없음", "all"}
        };
        #endregion



        public menu_transport()
        {
            InitializeComponent();
        }







        private void menu_browser_Load(object sender, EventArgs e)
        {
            for (int index=0; index<this.Controls.Count; ++index)
            {
                Control control = this.Controls[index];

                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }

            if (!visualizer.IsReady())
            {
                Program.ShowMsgbox("시각화 데이터(visual.db)가 존재하지 않아 기능을 이용할 수 없습니다.", "알림");
                return;
            }

            visualizer.Ready();
        }



        #region Event Handlers - CheckBox
        private void SelectSortOption(CheckBox checkBox)
        {
            if (!checkBox.Checked)
            {
                return;
            }    

            string control_name = checkBox.Name;
            control_name = control_name.Substring(0, control_name.LastIndexOf('_'));

            for (int index = 0; index < this.Controls.Count; ++index)
            {
                Control control = this.Controls[index];

                if (!(control is CheckBox))
                {
                    continue;
                }

                if (!control.Name.StartsWith(control_name))
                {
                    continue;
                }

                if (control.Name != checkBox.Name)
                {
                    ((CheckBox)control).Checked = false;
                }
            }

        }

        private void option_sort_1_Click(object sender, EventArgs e)
        {
            SelectSortOption((CheckBox)sender);
        }

        private void option_sort_2_Click(object sender, EventArgs e)
        {
            SelectSortOption((CheckBox)sender);
        }


        #endregion


        #region Event Handlers - Visualizer
        private void show_Click(object sender, EventArgs e)
        {
            if (dataList.Items.Count == 0)
            {
                show.Checked = false;

                Program.ShowMsgbox("시각화할 데이터를 추가해주세요.", "알림");
                return;
            }

            visualizer.ResetScript();

            if (show.Checked)
            {
                this.Enabled = false;

                for (int index=0; index<dataList.Items.Count; ++index)
                {
                    ListViewItem item = dataList.Items[index];

                    string model = parameters[item.SubItems[0].Text];
                    string type = parameters[item.SubItems[1].Text];
                    byte sortType = 0;
                    string label = item.SubItems[2].Text;
                    string colorCode = item.SubItems[3].Text;

                    if (dataList.Items.Count == 1)
                    {
                        if (option_sort_1.Checked)
                        {
                            sortType = 1;
                        }

                        else if (option_sort_2.Checked)
                        {
                            sortType = 2;
                        }
                    }

                    visualizer.AddChartBar(model, type, sortType, label, colorCode);
                }

                visualizer.AddShowScript(text_title.Text, text_xLabel.Text, text_yLabel.Text);

                engine.Run(visualizer.scriptFilePath);

                Thread _attacher = new Thread(() =>
                {
                    while (true)
                    {
                        IntPtr graphFormHwnd = FindWindow("TkTopLevel", text_title.Text);

                        if (graphFormHwnd != IntPtr.Zero)
                        {
                            break;
                        }

                        Thread.Sleep(200);
                    }


                    while (true)
                    {
                        IntPtr graphFormHwnd = FindWindow("TkTopLevel", text_title.Text);

                        if (graphFormHwnd == IntPtr.Zero)
                        {
                            engine.Quit();

                            visualizer.RemoveScriptFile();

                            this.Invoke((MethodInvoker)delegate ()
                            {
                                show.Checked = false;

                                this.Enabled = true;
                            });

                            return;
                        }

                        Thread.Sleep(333);
                    }
                });
                _attacher.IsBackground = true;
                _attacher.Start();
            }

        }

        private void label_show_Click(object sender, EventArgs e)
        {
            show.Checked = !show.Checked;
            show_Click(show, new EventArgs());
        }

        #endregion

        #region Event Handlers - DataList

        #region Buttons
        private void data_add_Click(object sender, EventArgs e)
        {
            dataList.Items.Add(new ListViewItem(new string[] { box_model.Text, box_type.Text, text_label.Text, select_color.Text }));

            dataList.TopItem = dataList.Items[dataList.Items.Count - 1];
        }

        private void data_remove_Click(object sender, EventArgs e)
        {
            if (dataList.Items.Count < 1)
            {
                Program.ShowMsgbox("데이터가 존재하지 않습니다.", "알림");
                return;
            }

            if (dataList.SelectedItems.Count < 1)
            {
                return;
            }

            int selected_index = dataList.SelectedIndices[0];
            dataList.Items.RemoveAt(selected_index);

            if (dataList.Items.Count == selected_index)
            {
                --selected_index;
            }

            if (dataList.Items.Count > 1)
            {
                dataList.Items[selected_index].Selected = true;
            }
        }
        #endregion

        #region ComboBoxes
        private void box_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = box_model.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            int selected_index = box_type.SelectedIndex;
            if (value == "버스" || value == "지하철")
            {
                box_type.Items.Clear();
                box_type.Items.AddRange(new string[] { "이용률", "이용 수", "승차 수", "하차 수" });
            }

            else if (value == "인구")
            {
                box_type.Items.Clear();
                box_type.Items.Add("없음");

                selected_index = 0;
            }

            box_type.SelectedIndex = selected_index;

            text_label.Text = box_model.SelectedItem.ToString();

        }
        #endregion

        #endregion
    }
}
